using Conexion;
using Comun.Utilidades;
using Ice.Properties;

namespace Ice.Servicios
{
    /// <summary>
    /// Clase encargada de fabricar los DAO.
    /// </summary>
    internal static class DaoFactory
    {
        /// <summary>
        /// Cadena de conexión a base de datos.
        /// </summary>
        private static readonly string ConnectionString;

        static DaoFactory()
        {
            ConnectionString = Settings.Default.connectionString;
        }

        /// <summary>
        /// Método encargado de buscar y obtener el DAO del tipo especificado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a buscar.</typeparam>
        /// <param name="handler">Instancia del administrador de errores.</param>
        /// <returns>DAO del tipo especificado que se encuentre mapeado por el sistema.</returns>
        public static TDao Get<TDao>(ErrorHandler handler) => Factory.Invoke<TDao>(ConnectionString, handler);
    }
}
