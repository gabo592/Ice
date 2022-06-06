namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un nombre por el cual se identifica.
    /// </summary>
    internal interface INameable
    {
        /// <summary>
        /// Nombre de la clase o registro.
        /// </summary>
        string Nombre { get; set; }
    }
}
