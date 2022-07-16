namespace Ice.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Producto desde una vista personalizada.
    /// </summary>
    internal class ProductoView
    {
        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio en catálogo del producto.
        /// </summary>
        public float Precio { get; set; }

        /// <summary>
        /// Cantidad en stock del producto.
        /// </summary>
        public float Cantidad { get; set; }

        /// <summary>
        /// Nombre de la categoría a la que pertenece el producto.
        /// </summary>
        public string Categoria { get; set; }
    }
}
