using System;
using System.Collections.Generic;
using Conexion.Base;
using Modelos.Compras;

namespace Conexion.Interfaces.Compras
{
    /// <summary>
    /// Conexión a base de datos con el objeto Compra.
    /// </summary>
    public interface ICompraDao : IDao<Compra>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Compra dentro de la base de datos hasta
        /// encontrar el registro que posea el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del objeto de tipo Compra.</param>
        /// <returns>Objeto de tipo Compra que coincida con el parámetro de búsqueda.</returns>
        Compra GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Compra dentro de la base de datos hasta
        /// encontrar el registro que posea la fecha a buscar.
        /// </summary>
        /// <param name="fecha">Fecha de compra del registro.</param>
        /// <returns>Colección genérica de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Compra dentro de la base de datos hasta
        /// encontrar el registro que posea el ID del Proveedor a buscar.
        /// </summary>
        /// <param name="idProveedor">Identificador único del Proveedor asociado al registro.</param>
        /// <returns>Colección genérica de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> GetByIdProveedor(int idProveedor);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Compra dentro de la base de datos hasta
        /// encontrar el registro que posea el ID del Empleado a buscar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado al registro.</param>
        /// <returns>Colección genérica de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> GetByIdEmpleado(int idEmpleado);
    }
}
