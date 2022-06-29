using System.Collections.Generic;
using Conexion.Base;
using Modelos.Inventario;

namespace Conexion.Interfaces.Inventario
{
    /// <summary>
    /// Acceso a base de datos con el objeto Detalle de Producto.
    /// </summary>
    public interface IDetalleProductoDao : IDao<DetalleProducto>
    {
        /// <summary>
        /// Reliza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo
        /// Detalle de Producto que coincidan con el ID del Producto a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al registro.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda.</returns>
        IEnumerable<DetalleProducto> GetByIdProducto(int idProducto);

        /// <summary>
        /// Reliza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo
        /// Detalle de Producto que coincidan con el ID de la Materia Prima a filtrar.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al registro.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulten de la búsqueda.</returns>
        IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar un registro de tipo Detalle de Producto
        /// que coincida con los ID de Producto y Materia Prima a filtrar. 
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto asociado al registro.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al registro.</param>
        /// <returns>Objeto de tipo Detalle de Producto que resulte de la búsqueda.</returns>
        DetalleProducto GetDetalleProducto(int idProducto, int idMateriaPrima);
    }
}
