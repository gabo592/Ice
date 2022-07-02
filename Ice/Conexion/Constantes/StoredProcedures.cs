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

        #endregion
    }
}
