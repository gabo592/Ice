using Modelos.Interfaces;

namespace Modelos.Ventas
{
    /// <summary>
    /// Objeti simple de tipo Cliente.
    /// </summary>
    public class Cliente : IIdentity, IPerson, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IPerson.PrimerNombre"/>
        public string PrimerNombre { get; set; }

        /// <inheritdoc cref="IPerson.SegundoNombre"/>
        public string SegundoNombre { get; set; }

        /// <inheritdoc cref="IPerson.PrimerApellido"/>
        public string PrimerApellido { get; set; }

        /// <inheritdoc cref="IPerson.SegundoApellido"/>
        public string SegundoApellido { get; set; }

        /// <inheritdoc cref="IPerson.Telefono"/>
        public string Telefono { get; set; }

        /// <inheritdoc cref="IPerson.Direccion"/>
        public string Direccion { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <inheritdoc cref="IPerson.IdMunicipio"/>
        public int IdMunicipio { get; set; }
    }
}
