using Modelos.Interfaces;

namespace Modelos.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Departamento.
    /// </summary>
    public class Departamento : IIdentity, INameable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }
    }
}
