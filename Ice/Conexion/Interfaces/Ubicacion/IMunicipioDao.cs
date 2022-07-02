using System.Collections.Generic;
using Conexion.Base;
using Modelos.Ubicacion;

namespace Conexion.Interfaces.Ubicacion
{
    /// <summary>
    /// Acceso a base de datos con el objeto Municipio.
    /// </summary>
    public interface IMunicipioDao : IDao<Municipio>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Municipio dentro de la base de datos
        /// hasta encontrar el que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Municipio.</param>
        /// <returns>Objeto de tipo Municipio que resulte de la búsqueda.</returns>
        Municipio GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Municipio dentro de la base de datos
        /// hasta encontrar los que coincidan con el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda.</returns>
        IEnumerable<Municipio> Read(string nombre);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Municipio dentro de la base de datos
        /// hasta encontrar los que coincidan con el ID del Departamento a filtrar.
        /// </summary>
        /// <param name="idDepartamento">Identificador único del Departamento asociado al Municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda.</returns>
        IEnumerable<Municipio> Read(int idDepartamento);
    }
}
