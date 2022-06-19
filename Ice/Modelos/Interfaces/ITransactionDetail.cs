namespace Modelos.Interfaces
{
    /// <summary>
    /// Indica que una clase es el detalle de otra clase transaccional del sistema.
    /// </summary>
    public interface ITransactionDetail
    {
        /// <summary>
        /// Cantidad especificada en la transacción.
        /// </summary>
        float Cantidad { get; set; }

        /// <summary>
        /// Descuento aplicado en la transacción.
        /// </summary>
        float Descuento { get; set; }
    }
}
