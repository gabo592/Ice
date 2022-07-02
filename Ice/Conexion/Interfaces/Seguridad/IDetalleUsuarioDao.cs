using System.Collections.Generic;
using Conexion.Base;
using Modelos.Seguridad;

namespace Conexion.Interfaces.Seguridad
{
    /// <summary>
    /// Acceso a base de datos con el objeto Detalle de Usuario.
    /// </summary>
    public interface IDetalleUsuarioDao : IDao<DetalleUsuario>
    {
        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Usuario dentro de la base de datos
        /// hasta encontrar uno que coincida con los parámetros de búsqueda.
        /// </summary>
        /// <param name="idUsuario">Identificador único del usuario asociado al registro.</param>
        /// <param name="idRol">Identificador único del rol asociado al registro.</param>
        /// <returns>Objeto de tipo Detalle de Usuario que resulte de la búsqueda.</returns>
        DetalleUsuario Read(int idUsuario, int idRol);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Usuario dentro de la base de datos
        /// hasta encontrar los que coincidan con el parámetro de búsqueda.
        /// </summary>
        /// <param name="idUsuario">Identificador único del usuario asociado al registro.</param>
        /// <returns>Colección de objetos de tipo Detalle de Usuario que resulten de la búsqueda.</returns>
        IEnumerable<DetalleUsuario> GetByIdUsuario(int idUsuario);

        /// <summary>
        /// Realiza la búsqueda de registros de tipo Detalle de Usuario dentro de la base de datos
        /// hasta encontrar los que coincidan con el parámetro de búsqueda.
        /// </summary>
        /// <param name="idRol">Identificador único del rol asociado al registro.</param>
        /// <returns>Colección de objetos de tipo Detalle de Usuario que resulten de la búsqueda.</returns>
        IEnumerable<DetalleUsuario> GetByIdRol(int idRol);
    }
}
