using Modelos.Interfaces;

namespace Modelos.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Usuario.
    /// </summary>
    public class DetalleUsuario : IActivable
    {
        /// <summary>
        /// Identificador único del usuario asociado al detalle.
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Identificador único del rol asociado al detalle.
        /// </summary>
        public int IdRol { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
