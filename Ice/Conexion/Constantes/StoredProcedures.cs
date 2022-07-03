namespace Conexion.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados que ejecutará
    /// el programa
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region Compras

        public static readonly string CompraCreate = "COMPRA_CREATE";
        public static readonly string CompraRead = "COMPRA_READ";
        public static readonly string CompraUpdate = "COMPRA_UPDATE";
        public static readonly string CompraDelete = "COMPRA_DELETE";

        public static readonly string DetalleCompraCreate = "DETALLE_COMPRA_CREATE";
        public static readonly string DetalleCompraRead = "DETALLE_COMPRA_READ";
        public static readonly string DetalleCompraUpdate = "DETALLE_COMPRA_UPDATE";
        public static readonly string DetalleCompraDelete = "DETALLE_COMPRA_DELETE";

        public static readonly string ProveedorCreate = "PROVEEDOR_CREATE";
        public static readonly string ProveedorRead = "PROVEEDOR_READ";
        public static readonly string ProveedorUpdate = "PROVEEDOR_UPDATE";
        public static readonly string ProveedorDelete = "PROVEEDOR_DELETE";

        #endregion
    }
}
