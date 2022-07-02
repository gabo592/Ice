using System.Collections.Generic;
using Conexion.Base;
using Modelos.Seguridad;

namespace Conexion.Interfaces.Seguridad
{
    /// <summary>
    /// Acceso a base de datos con el objeto Rol.
    /// </summary>
    public interface IRolDao : IDao<Rol>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Rol dentro de la base de datos hasta encontrar
        /// uno que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del rol.</param>
        /// <returns>Objeto de tipo Rol que resulte de la búsqueda.</returns>
        Rol GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Rol dentro de la base de datos hasta encontrar
        /// los que coincidan con el valor a filtrar. Puede ser por: nombre o descripción.
        /// </summary>
        /// <param name="value">Valor a filtrar.</param>
        /// <returns>Colección de objetos de tipo Rol que resulte de la búsqueda.</returns>
        IEnumerable<Rol> Read(string value);
    }
}
