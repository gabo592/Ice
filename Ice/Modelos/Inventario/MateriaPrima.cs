using Modelos.Interfaces;

namespace Modelos.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima.
    /// </summary>
    internal class MateriaPrima : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <summary>
        /// Atributo que describe a la materia prima.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio en catálogo de la materia prima.
        /// </summary>
        public float Precio { get; set; }

        /// <summary>
        /// Cantidad en stock de la materia prima.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
