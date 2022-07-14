namespace Conexion.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados que ejecutará
    /// el programa
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region Compras

        public const string CompraCreate = "Compras.COMPRA_CREATE";
        public const string CompraRead = "Compras.COMPRA_READ";
        public const string CompraUpdate = "Compras.COMPRA_UPDATE";
        public const string CompraDelete = "Compras.COMPRA_DELETE";

        public const string DetalleCompraCreate = "Compras.DETALLE_COMPRA_CREATE";
        public const string DetalleCompraRead = "Compras.DETALLE_COMPRA_READ";
        public const string DetalleCompraUpdate = "Compras.DETALLE_COMPRA_UPDATE";
        public const string DetalleCompraDelete = "Compras.DETALLE_COMPRA_DELETE";

        public const string ProveedorCreate = "Compras.PROVEEDOR_CREATE";
        public const string ProveedorRead = "Compras.PROVEEDOR_READ";
        public const string ProveedorUpdate = "Compras.PROVEEDOR_UPDATE";
        public const string ProveedorDelete = "Compras.PROVEEDOR_DELETE";

        #endregion

        #region Inventario

        public const string CategoriaProductoCreate = "Inventario.CATEGORIA_PRODUCTO_CREATE";
        public const string CategoriaProductoRead = "Inventario.CATEGORIA_PRODUCTO_READ";
        public const string CategoriaProductoUpdate = "Inventario.CATEGORIA_PRODUCTO_UPDATE";
        public const string CategoriaProductoDelete = "Inventario.CATEGORIA_PRODUCTO_DELETE";

        public const string DetalleProductoCreate = "Inventario.DETALLE_PRODUCTO_CREATE";
        public const string DetalleProductoRead = "Inventario.DETALLE_PRODUCTO_READ";
        public const string DetalleProductoUpdate = "Inventario.DETALLE_PRODUCTO_UPDATE";
        public const string DetalleProductoDelete = "Inventario.DETALLE_PRODUCTO_DELETE";

        public const string MateriaPrimaCreate = "Inventario.MATERIA_PRIMA_CREATE";
        public const string MateriaPrimaRead = "Inventario.MATERIA_PRIMA_READ";
        public const string MateriaPrimaUpdate = "Inventario.MATERIA_PRIMA_UPDATE";
        public const string MateriaPrimaDelete = "Inventario.MATERIA_PRIMA_DELETE";

        public const string ProductoCreate = "Inventario.PRODUCTO_CREATE";
        public const string ProductoRead = "Inventario.PRODUCTO_READ";
        public const string ProductoUpdate = "Inventario.PRODUCTO_UPDATE";
        public const string ProductoDelete = "Inventario.PRODUCTO_DELETE";

        #endregion

        #region RecursosHumanos

        public const string EmpleadoCreate = "RecursosHumanos.EMPLEADO_CREATE";
        public const string EmpleadoRead = "RecursosHumanos.EMPLEADO_READ";
        public const string EmpleadoUpdate = "RecursosHumanos.EMPLEADO_UPDATE";
        public const string EmpleadoDelete = "RecursosHumanos.EMPLEADO_DELETE";

        #endregion

        #region Seguridad

        public const string DetalleUsuarioCreate = "Seguridad.DETALLE_USUARIO_CREATE";
        public const string DetalleUsuarioRead = "Seguridad.DETALLE_USUARIO_READ";
        public const string DetalleUsuarioUpdate = "Seguridad.DETALLE_USUARIO_UPDATE";
        public const string DetalleUsuarioDelete = "Seguridad.DETALLE_USUARIO_DELETE";

        public const string RolCreate = "Seguridad.ROL_CREATE";
        public const string RolRead = "Seguridad.ROL_READ";
        public const string RolUpdate = "Seguridad.ROL_UPDATE";
        public const string RolDelete = "Seguridad.ROL_DELETE";

        public const string UsuarioCrete = "Seguridad.USUARIO_CREATE";
        public const string UsuarioRead = "Seguridad.USUARIO_READ";
        public const string UsuarioUpdate = "Seguridad.USUARIO_UPDATE";
        public const string UsuarioDelete = "Seguridad.USUARIO_DELETE";
        public const string UsuarioLogin = "Seguridad.USUARIO_LOGIN";

        #endregion

        #region Ubicacion

        public const string DepartamentoCreate = "Ubicacion.DEPARTAMENTO_CREATE";
        public const string DepartamentoRead = "Ubicacion.DEPARTAMENTO_READ";
        public const string DepartamentoUpdate = "DEPARTAMENOT_UPDATE";
        public const string DepartamentoDelete = "Ubicacion.DEPARTAMENTO_DELETE";

        public const string MunicipioCreate = "Ubicacion.MUNICIPIO_CREATE";
        public const string MunicipioRead = "Ubicacion.MUNICIPIO_READ";
        public const string MunicipioUpdate = "Ubicacion.MUNICIPIO_UPDATE";
        public const string MunicipioDelete = "Ubicacion.MUNICIPIO_DELETE";

        #endregion

        #region Ventas

        public const string ClienteCreate = "Ventas.CLIENTE_CREATE";
        public const string ClienteRead = "Ventas.CLIENTE_READ";
        public const string ClienteUpdate = "Ventas.CLIENTE_UPDATE";
        public const string ClienteDelete = "Ventas.CLIENTE_DELETE";

        public const string DetalleVentaCreate = "Ventas.DETALLE_VENTA_CREATE";
        public const string DetalleVentaRead = "Ventas.DETALLE_VENTA_READ";
        public const string DetalleVentaUpdate = "Ventas.DETALLE_VENTA_UPDATE";
        public const string DetalleVentaDelete = "Ventas.DETALLE_VENTA_DELETE";

        public const string VentaCreate = "Ventas.VENTA_CREATE";
        public const string VentaRead = "Ventas.VENTA_READ";
        public const string VentaUpdate = "Ventas.VENTA_UPDATE";
        public const string VentaDelete = "Ventas.VENTA_DELETE";

        #endregion
    }
}
