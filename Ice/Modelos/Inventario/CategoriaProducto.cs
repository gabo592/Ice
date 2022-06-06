using Modelos.Interfaces;

namespace Modelos.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Categoría de Productos
    /// </summary>
    internal class CategoriaProducto : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción de la categoría del producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
