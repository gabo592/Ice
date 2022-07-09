using Modelos.Seguridad;

namespace Ice.Servicios.Base
{
    /// <summary>
    /// Clase encargada de administrar los inicios de sesión dentro del sistema.
    /// Esta clase no puede heredarse.
    /// </summary>
    internal sealed class Session
    {
        /// <summary>
        /// Objeto simple de tipo Usuario.
        /// </summary>
        public static Usuario Usuario { get; private set; }

        /// <summary>
        /// Indica si existe un inicio de sesión activo dentro del sistema.
        /// </summary>
        public static bool IsLoggedIn => Usuario != null;

        /// <summary>
        /// Establece un nuevo inicio de sesión para un determinado usuario.
        /// </summary>
        /// <param name="usuario">Usuario a iniciar sesión.</param>
        public static void SetSession(Usuario usuario)
        {
            if (usuario is null)
            {
                CloseSession();
                return;
            }

            Usuario = usuario;
        }

        /// <summary>
        /// Cierra la sesión actual.
        /// </summary>
        public static void CloseSession() => Usuario = null;
    }
}
