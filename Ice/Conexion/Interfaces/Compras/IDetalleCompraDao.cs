using System.Collections.Generic;
using Conexion.Base;
using Modelos.Compras;

namespace Conexion.Interfaces.Compras
{
    /// <summary>
    /// Conexión a base de datos con el objeto Detalle de Compra.
    /// </summary>
    public interface IDetalleCompraDao : IDao<DetalleCompa>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Compra dentro de la base de datos hasta
        /// encontrar uno que posea el ID de Compra y Materia Prima a buscar.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra asociada al registro.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima asociada al registro.</param>
        /// <returns>Objeto de tipo Detalle de Compra que resulte de la búsqueda.</returns>
        DetalleCompa Read(int idCompra, int idMateriaPrima);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Compra dentro de la base de datos hasta
        /// encontrar uno que posea el ID de Compra a buscar.
        /// </summary>
        /// <param name="idCompra">Identificador único de la Compra.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulte de la búsqueda.</returns>
        IEnumerable<DetalleCompa> GetByIdCompra(int idCompra);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Detalle de Compra dentro de la base de datos hasta
        /// encontrar uno que posea el ID de Materia Prima a buscar.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulte de la búsqueda.</returns>
        IEnumerable<DetalleCompa> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
