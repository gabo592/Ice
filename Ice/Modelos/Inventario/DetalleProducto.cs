using Modelos.Interfaces;

namespace Modelos.Inventario
{
    /// <summary>
    /// Objeti simple de tipo Detalle de Producto
    /// </summary>
    internal class DetalleProducto : IActivable
    {
        /// <summary>
        /// Identificador único del producto asociado al detalle.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Identificador único de la materia prima asociada al detalle del producto.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Cantidad a utilizar de materia prima para la elaboración del producto.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
