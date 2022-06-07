namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de seguridad como una contraseña.
    /// </summary>
    interface ISecurity
    {
        /// <summary>
        /// Clave de seguridad o contraseña que posee la clase o registro que garantiza
        /// su seguridad.
        /// </summary>
        string Clave { get; set; }
    }
}
