using System.Collections.Generic;
using Conexion.Base;
using Modelos.Seguridad;

namespace Conexion.Interfaces.Seguridad
{
    /// <summary>
    /// Acceso a base de datos con el objeto Usuario.
    /// </summary>
    public interface IUsuarioDao : IDao<Usuario>
    {
        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Usuario dentro de la base de datos hasta
        /// encontrar el que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Usuario.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda.</returns>
        Usuario GetById(int id);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Usuario dentro de la base de datos hasta
        /// encontrar los que coincidan con el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda.</returns>
        IEnumerable<Usuario> Read(string nombre);

        /// <summary>
        /// Realiza la búsqueda de objetos de tipo Usuario dentro de la base de datos hasta
        /// encontrar los que coincidan con el ID del Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado asociado al registro.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda.</returns>
        IEnumerable<Usuario> GetByIdEmpleado(int idEmpleado);

        /// <summary>
        /// Verifica la existencia de un objeto de tipo Usuario dentro de la base de datos en base al
        /// nombre de usuario y clave de acceso ingresadas.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="clave">Clave de acceso o contraseña.</param>
        /// <returns>Objeto de tipo Usuario que coincida con los parámetros para realizar el Login.</returns>
        Usuario Login(string nombre, string clave);
    }
}
