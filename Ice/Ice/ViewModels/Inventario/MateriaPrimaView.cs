namespace Ice.ViewModels.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima desde una vista personalizada.
    /// </summary>
    internal class MateriaPrimaView
    {
        /// <summary>
        /// Identificador único de la materia prima.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripción de la materia prima.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio en catálogo de la materia prima.
        /// </summary>
        public float Precio { get; set; }

        /// <summary>
        /// Cantidad en stock de la materia prima.
        /// </summary>
        public float Cantidad { get; set; }
    }
}
