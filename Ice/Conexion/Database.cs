using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using Comun.Utilidades;

namespace Conexion
{
    /// <summary>
    /// Clase encargada de comunicarse directamente con la base de datos. Esta clase no puede heredarse.
    /// </summary>
    internal sealed class Database
    {
        #region Campos Privados

        /// <summary>
        /// Cadena de conexión para la base de datos.
        /// </summary>
        private readonly string Conexion;

        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler ErrorHandler;

        #endregion

        #region Contructor

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la conexión para la base de datos y una instancia del controlador
        /// de errores.
        /// </summary>
        /// <param name="conexion">Cadena de conexión para la base de datos.</param>
        /// <param name="handler">Instancia del controlador de errores.</param>
        public Database(string conexion, ErrorHandler handler)
        {
            Conexion = conexion;
            ErrorHandler = handler;
        }

        #endregion

        #region Método público

        /// <summary>
        /// Método encargado de realizar lectura y ejecución de un procedimiento almacenado
        /// tomando en cuenta el nombre del procedimiento y una colección de valores.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo resultante de la ejecución del procedimiento.</typeparam>
        /// <param name="procedure">Nombre del procedimiento almacenado.</param>
        /// <param name="parameters">Colección genérica de pares clave-valor que conforman los parámetros del procedimiento.</param>
        /// <returns>Colección genérica de objetos del tipo especificado.</returns>
        /// <exception cref="NullReferenceException">Se dispara cuando el nombre del procedimiento almacenado no se especifica.</exception>
        /// <exception cref="ArgumentException">Se dispara cuando no se logra establecer la conexión.</exception>
        public IEnumerable<TModel> Read<TModel>(string procedure, IDictionary<string, object> parameters) where TModel : new()
        {
            if (string.IsNullOrEmpty(procedure)) throw new NullReferenceException("El nombre del procedimiento almacenado no puede estar vacío.");

            if (parameters is null) parameters = new Dictionary<string, object>();

            using (SqlConnection connection = new SqlConnection(Conexion))
            {
                try
                {
                    connection.Open();
                }
                catch
                {
                    throw new ArgumentException("No se logró establecer la conexión.");
                }

                using (SqlCommand command = new SqlCommand(procedure, connection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 20
                })
                {
                    SqlCommandBuilder.DeriveParameters(command);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        parameters.TryGetValue(RemueveSigno(parameter.ParameterName), out object value);

                        if (value is null)
                        {
                            parameter.Value = DBNull.Value;
                            continue;
                        }

                        if (value is Image image)
                        {
                            parameter.Value = ImageUtil.GetBytesImage(image);
                            continue;
                        }

                        parameter.Value = value;
                    }

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        return MapToObject<TModel>(reader).ToArray();
                    }
                    catch (Exception ex)
                    {
                        ErrorHandler.Add(ex);
                        return Enumerable.Empty<TModel>();
                    }
                }
            }
        }

        #endregion

        #region Métodos privados

        /// <summary>
        /// Remueve el primer caracter de una cadena, suponiendo que es un arroba.
        /// </summary>
        /// <param name="value">Cadena de texto a modificar.</param>
        /// <returns>Cadena de texto modificada sin el primer caracter.</returns>
        private string RemueveSigno(string value) => value.Substring(1);

        /// <summary>
        /// Método encargado de realizar el mapping de un objeto como resultado de la ejecución
        /// de un procedimiento almacenado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a realizar el mapping.</typeparam>
        /// <param name="reader">Letor de registros.</param>
        /// <returns>Colección de modelos del tipo especificado como resultado de la ejecución del procedimiento almacenado.</returns>
        private IEnumerable<TModel> MapToObject<TModel>(IDataReader reader) where TModel : new()
        {
            Type type = typeof(TModel);

            while(reader.Read())
            {
                TModel model = new TModel();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string nombre = reader.GetString(i);
                    PropertyInfo property = type.GetProperty(nombre);

                    if (property is null) continue;

                    object value = reader.IsDBNull(i) ? null : reader.GetValue(i);

                    if (value is decimal && property.PropertyType == typeof(double)) value = Convert.ToDouble(value);

                    if (value is double && property.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);

                    if (value is decimal && property.PropertyType == typeof(float)) value = Convert.ToSingle(value);

                    if (value is float && property.PropertyType == typeof(decimal)) value = Convert.ToDecimal(value);

                    if (value is double && property.PropertyType == typeof(float)) value = Convert.ToSingle(value);

                    if (value is float && property.PropertyType == typeof(double)) value = Convert.ToDouble(value);

                    if (value is byte[] && property.PropertyType == typeof(string)) value = string.Empty;

                    if ((value is byte[]) && property.PropertyType == typeof(Image))
                    {
                        byte[] bytesImagen = (byte[])value;
                        value = ImageUtil.GetImage(bytesImagen);
                    }

                    if (value is null && property.PropertyType == typeof(DateTime)) value = DateTime.Now;

                    property.SetValue(value, model);
                }

                yield return model;
            }
        }

        #endregion
    }
}
