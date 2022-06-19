using Modelos.Interfaces;

namespace Modelos.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta.
    /// </summary>
    public class DetalleVenta : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único de la venta asociada al detalle.
        /// </summary>
        public int IdVenta { get; set; }

        /// <summary>
        /// Identificador único del producto asociado al detalle de venta.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Precio de venta del producto.
        /// </summary>
        public float Precio { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Cantidad"/>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Descuento"/>
        public float Descuento { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}