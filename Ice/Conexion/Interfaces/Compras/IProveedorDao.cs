using System.Collections.Generic;
using Conexion.Base;
using Modelos.Compras;

namespace Conexion.Interfaces.Compras
{
    /// <summary>
    /// Conexión a la base de datos con el objeto Proveedor
    /// </summary>
    public interface IProveedorDao : IDao<Proveedor>
    {
        /// <summary>
        /// Realiza la búsqueda de proveedores dentro de la base de datos
        /// que coincidan con el ID a buscar.
        /// </summary>
        /// <param name="id">Identificador único del proveedor.</param>
        /// <returns>Objeto de tipo Proveedor que coincida con el ID a buscar.</returns>
        Proveedor GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de proveedores dentro de la base de datos que coincidan
        /// con el valor a buscar. Puede ser por: nombre, dirección, etc.
        /// </summary>
        /// <param name="value">Valor a buscar dentro de la base de datos.</param>
        /// <returns>Colección genérica de objetos de tipo Proveedor que resulten de la búsqueda.</returns>
        IEnumerable<Proveedor> Read(string value);
    }
}
