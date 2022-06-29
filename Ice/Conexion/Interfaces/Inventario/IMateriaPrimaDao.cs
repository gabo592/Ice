using System.Collections.Generic;
using Conexion.Base;
using Modelos.Inventario;

namespace Conexion.Interfaces.Inventario
{
    /// <summary>
    /// Acceso a base de datos con el objeto Materia Prima.
    /// </summary>
    public interface IMateriaPrimaDao : IDao<MateriaPrima>
    {
        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar un registro de tipo Materia Prima
        /// que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Materia Prima.</param>
        /// <returns>Objeto de tipo Materia Prima que resulte de la búsqueda.</returns>
        MateriaPrima GetById(int id);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo Materia Prima
        /// que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción de la Materia Prima.</param>
        /// <returns>Colección de objetos de tipo Materia Prima que resulten de la búsqueda.</returns>
        IEnumerable<MateriaPrima> Read(string descripcion);
    }
}
