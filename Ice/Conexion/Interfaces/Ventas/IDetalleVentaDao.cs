using System.Collections.Generic;
using Conexion.Base;
using Modelos.Ventas;

namespace Conexion.Interfaces.Ventas
{
    /// <summary>
    /// Acceso a base de datos con el objeto Detalle de Venta.
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Venta dentro de la base de datos
        /// hasta encontrar el que coincida con el ID de Venta y Producto a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta.</param>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Objeto de tipo Detalle de Venta que resulte de la búsqueda.</returns>
        DetalleVenta Read(int idVenta, int idProducto);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Venta dentro de la base de datos
        /// hasta encontrar el que coincida con el ID de Venta a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda.</returns>
        IEnumerable<DetalleVenta> GetByIdVenta(int idVenta);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Venta dentro de la base de datos
        /// hasta encontrar el que coincida con el ID de Producto a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda.</returns>
        IEnumerable<DetalleVenta> GetByIdProducto(int idProducto);
    }
}
