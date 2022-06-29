using System.Collections.Generic;
using Conexion.Base;
using Modelos.Inventario;

namespace Conexion.Interfaces.Inventario
{
    /// <summary>
    /// Acceso a base de datos con el objeto Producto.
    /// </summary>
    public interface IProductoDao : IDao<Producto>
    {
        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar un registro de tipo
        /// Producto que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Producto.</param>
        /// <returns>Objeto de tipo Producto que resulte de la búsqueda.</returns>
        Producto GetById(int id);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo
        /// Producto que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda.</returns>
        IEnumerable<Producto> Read(string descripcion);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo
        /// Producto que coincidan el ID de la Categoría a filtrar.
        /// </summary>
        /// <param name="idCategoria">Identificador único de la Categoría asociada al registro.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda.</returns>
        IEnumerable<Producto> GetByIdCategoria(int idCategoria);
    }
}
