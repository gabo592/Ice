using Modelos.Interfaces;

namespace Modelos.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Municipio.
    /// </summary>
    public class Municipio : IIdentity, INameable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador único del departamento que contiene al municipio.
        /// </summary>
        public int IdDepartamento { get; set; }
    }
}
