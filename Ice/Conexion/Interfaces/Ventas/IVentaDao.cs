using System;
using System.Collections.Generic;
using Conexion.Base;
using Modelos.Ventas;

namespace Conexion.Interfaces.Ventas
{
    /// <summary>
    /// Acceso a base de datos con el objeto Venta.
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Venta dentro de la base de datos
        /// hasta encontrar el que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Venta.</param>
        /// <returns>Objeto de tipo Venta que resulte de la búsqueda.</returns>
        Venta GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Venta dentro de la base de datos
        /// hasta encontrar los que coincidan con la fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha de la Venta registrada.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Venta dentro de la base de datos
        /// hasta encontrar los que coincidan con el ID del Cliente a filtrar.
        /// </summary>
        /// <param name="idCliente">Identificador único del Cliente asociado a la Venta.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> GetByIdCliente(int idCliente);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Venta dentro de la base de datos
        /// hasta encontrar los que coincidan con el ID del Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado a la Venta.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> GetByIdEmpleado(int idEmpleado);
    }
}
