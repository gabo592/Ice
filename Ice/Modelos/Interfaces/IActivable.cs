namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que un objeto posee un estado ya sea activo o inactivo.
    /// </summary>
    public interface IActivable
    {
        /// <summary>
        /// Estado del objeto. El cual puede ser activo o inactivo.
        /// </summary>
        bool Estado { get; set; }
    }
}
