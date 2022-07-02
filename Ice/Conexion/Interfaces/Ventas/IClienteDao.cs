using System.Collections.Generic;
using Conexion.Base;
using Modelos.Ventas;

namespace Conexion.Interfaces.Ventas
{
    /// <summary>
    /// Acceso a base de datos con el objeto Cliente.
    /// </summary>
    public interface IClienteDao : IDao<Cliente>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Cliente dentro de la base de datos
        /// hasta encontrar el que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Cliente.</param>
        /// <returns>Objeto de tipo Cliente que resulte de la búsqueda.</returns>
        Cliente GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Cliente dentro de la base de datos
        /// hasta encontrar los que coincidan con el valor a filtrar. Puede ser por:
        /// nombres, apellidos, dirección, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda.</returns>
        IEnumerable<Cliente> Read(string value);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Cliente dentro de la base de datos
        /// hasta encontrar los que coincidan con el ID del Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio asociado al Cliente.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda.</returns>
        IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio);
    }
}
