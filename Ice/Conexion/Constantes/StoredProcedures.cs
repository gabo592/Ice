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

        #region Inventario

        public static readonly string CategoriaProductoCreate = "CATEGORIA_PRODUCTO_CREATE";
        public static readonly string CategoriaProductoRead = "CATEGORIA_PRODUCTO_READ";
        public static readonly string CategoriaProductoUpdate = "CATEGORIA_PRODUCTO_UPDATE";
        public static readonly string CategoriaProductoDelete = "CATEGORIA_PRODUCTO_DELETE";

        public static readonly string DetalleProductoCreate = "DETALLE_PRODUCTO_CREATE";
        public static readonly string DetalleProductoRead = "DETALLE_PRODUCTO_READ";
        public static readonly string DetalleProductoUpdate = "DETALLE_PRODUCTO_UPDATE";
        public static readonly string DetalleProductoDelete = "DETALLE_PRODUCTO_DELETE";

        public static readonly string MateriaPrimaCreate = "MATERIA_PRIMA_CREATE";
        public static readonly string MateriaPrimaRead = "MATERIA_PRIMA_READ";
        public static readonly string MateriaPrimaUpdate = "MATERIA_PRIMA_UPDATE";
        public static readonly string MateriaPrimaDelete = "MATERIA_PRIMA_DELETE";

        public static readonly string ProductoCreate = "PRODUCTO_CREATE";
        public static readonly string ProductoRead = "PRODUCTO_READ";
        public static readonly string ProductoUpdate = "PRODUCTO_UPDATE";
        public static readonly string ProductoDelete = "PRODUCTO_DELETE";

        #endregion
    }
}
