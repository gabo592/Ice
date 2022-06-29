using System.Collections.Generic;
using Conexion.Base;
using Modelos.RecursosHumanos;

namespace Conexion.Interfaces.RecursosHumanos
{
    /// <summary>
    /// Acceso a base de datos con el objeto Empleado.
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar un registro de tipo Empleado
        /// que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Empleado.</param>
        /// <returns>Objeto de tipo Empleado que resulte de la búsqueda.</returns>
        Empleado GetById(int id);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo Empleado
        /// que coincidan con el valor a filtrar. Puede ser por: Nombres, Apellidos, Dirección, etc.
        /// </summary>
        /// <param name="value">Filtro de búsqueda.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda.</returns>
        IEnumerable<Empleado> Read(string value);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo Empleado
        /// que coincidan con el ID del Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio asociado al registro.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda.</returns>
        IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio);
    }
}
