using System.Collections.Generic;
using Conexion.Base;
using Modelos.Ubicacion;

namespace Conexion.Interfaces.Ubicacion
{
    /// <summary>
    /// Acceso a base de datos con el objeto Departamento
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Departamento dentro de la base de datos
        /// hasta encontrar el que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Departamento.</param>
        /// <returns>Objeto de tipo Departamento que resulte de la búsqueda.</returns>
        Departamento GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Departamento dentro de la base de datos
        /// hasta encontrar los que coincidan con el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Departamento.</param>
        /// <returns>Colección de objetos de tipo Departamento que resulten de la búsqueda.</returns>
        IEnumerable<Departamento> Read(string nombre);
    }
}
