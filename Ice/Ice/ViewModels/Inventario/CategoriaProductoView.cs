namespace Ice.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Categoría de Producto desde una vista personalizada.
    /// </summary>
    internal class CategoriaProductoView
    {
        /// <summary>
        /// Identificador único de la categoría de producto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la categoría.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción de la categoría.
        /// </summary>
        public string Descripcion { get; set; }
    }
}
