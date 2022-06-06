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

        public float Cantidad { get; set; }
        public float Descuento { get; set; }
        public bool Estado { get; set; }
    }
}
