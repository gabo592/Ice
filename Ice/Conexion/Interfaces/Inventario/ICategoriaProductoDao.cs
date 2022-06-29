using System.Collections.Generic;
using Conexion.Base;
using Modelos.Inventario;

namespace Conexion.Interfaces.Inventario
{
    /// <summary>
    /// Acceso a base de datos con objeto Categoría de Productos.
    /// </summary>
    public interface ICategoriaProductoDao : IDao<CategoriaProducto>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que
        /// contenga el ID especificado.
        /// </summary>
        /// <param name="id">Identificador único de la Categoría de Producto.</param>
        /// <returns>Objeto de tipo Categoría de Producto que resulte de la búsqueda.</returns>
        CategoriaProducto GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que
        /// contengan el valor especificado, puede ser por nombre o descripción.
        /// </summary>
        /// <param name="value">Filtro de búsqueda.</param>
        /// <returns>Colección genérica de objetos de tipo Categoría de Productos</returns>
        IEnumerable<CategoriaProducto> Read(string value);
    }
}
