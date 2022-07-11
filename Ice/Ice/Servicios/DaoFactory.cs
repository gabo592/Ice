using Comun.Utilidades;
using Conexion;
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
        private static readonly string connectionString;

        static DaoFactory()
        {
            connectionString = Settings.Default.connectionString;
        }

        /// <summary>
        /// Busca y obtiene el DAO de tipo especificado en base al mapping ya configurado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a obtener.</typeparam>
        /// <param name="handler">Instancia del administrador de errores.</param>
        /// <returns>DAO del tipo especificado que se encuentre mapeado por el sistema.</returns>
        public static TDao Get<TDao>(ErrorHandler handler) => Factory.Invoke<TDao>(connectionString, handler);
    }
}
