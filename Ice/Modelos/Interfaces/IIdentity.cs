namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de identificación único como un ID.
    /// </summary>
    internal interface IIdentity
    {
        /// <summary>
        /// Identificador único de un objeto.
        /// </summary>
        int Id { get; set; }
    }
}
