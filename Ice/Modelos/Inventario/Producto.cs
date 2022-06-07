using Modelos.Interfaces;

namespace Modelos.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Producto.
    /// </summary>
    public class Producto : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <summary>
        /// Atributo que describe al producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Precio en catálogo del Producto.
        /// </summary>
        public float Precio { get; set; }

        /// <summary>
        /// Cantidad en stock del producto.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único de la categoría asociada al producto.
        /// </summary>
        public int IdCategoria { get; set; }
    }
}
