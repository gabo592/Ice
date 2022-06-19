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
        /// <param name="IdCompra">Identificador único de la Compra asociada al registro.</param>
        /// <param name="IdMateriaPrima">Identificador único de la Materia Prima asociada al registro.</param>
        /// <returns>Objeto de tipo Detalle de Compra que resulte de la búsqueda.</returns>
        DetalleCompa Read(int IdCompra, int IdMateriaPrima);
    }
}
