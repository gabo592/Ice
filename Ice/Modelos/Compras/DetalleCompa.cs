using Modelos.Interfaces;

namespace Modelos.Compras
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra.
    /// </summary>
    internal class DetalleCompa : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único de la compra.
        /// </summary>
        public int IdCompra { get; set; }

        /// <summary>
        /// Identificador único de la materia prima asociada al registro.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Costo de adquisición del producto en la compra realizada.
        /// </summary>
        public float Costo { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Cantidad"/>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Descuento"/>
        public float Descuento { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
