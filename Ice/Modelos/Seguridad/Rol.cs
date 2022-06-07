using Modelos.Interfaces;

namespace Modelos.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Rol.
    /// </summary>
    public class Rol : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Establece la descripción que especifica y diferencia al rol.
        /// </summary>
        public string Descripcion { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
