using Modelos.Interfaces;

namespace Modelos.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Usuario.
    /// </summary>
    public class Usuario : IIdentity, INameable, ISecurity, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <inheritdoc cref="ISecurity.Clave"/>
        public string Clave { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
