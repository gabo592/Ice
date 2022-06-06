namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase tiene asociada otra clase de tipo Empleado.
    /// </summary>
    internal interface IEmpleable
    {
        /// <summary>
        /// Identificador único del empleado asociado a esta clase.
        /// </summary>
        int IdEmpleado { get; set; }
    }
}
