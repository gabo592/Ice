using System;
using System.Collections.Generic;
using System.Linq;
using Modelos.Inventario;
using Ice.ViewModels.Inventario;
using Conexion.Interfaces.Inventario;
using Ice.Servicios.Base;

namespace Ice.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de proveer los servicios para las Materias Primas.
    /// </summary>
    internal class MateriasPrimasService : ServicioBase
    {
        /// <summary>
        /// DAO para las Materias Primas.
        /// </summary>
        private readonly IMateriaPrimaDao materiaPrimaDao;

        public MateriasPrimasService()
        {
            materiaPrimaDao = DaoFactory.Get<IMateriaPrimaDao>(Handler);
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Materia Prima en la base de datos dada una colección de propiedades
        /// del mismo objeto.
        /// </summary>
        /// <param name="properties">Colección de propiedades de la materia prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no es proporcionada.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no puede ser nula.");

            MateriaPrima materiaPrima = materiaPrimaDao.Create(new MateriaPrima
            {
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToSingle(properties["Precio"]),
                Cantidad = Convert.ToSingle(properties["Cantidad"])
            });

            if (materiaPrima is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IMateriaPrimaDao.GetById(int)"/>
        public MateriaPrima GetById(int id) => materiaPrimaDao.GetById(id);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo Materia Prima
        /// que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción de la Materia Prima.</param>
        /// <returns>Colección de objetos de tipo Materia Prima desde una vista personalizada, que resulten de la búsqueda.</returns>
        public IEnumerable<MateriaPrimaView> GetMateriasPrimas(string descripcion)
        {
            IEnumerable<MateriaPrima> materiasPrimas = materiaPrimaDao.Read(descripcion);

            return materiasPrimas.Select(materiaPrima =>
            {
                return new MateriaPrimaView
                {
                    Id = materiaPrima.Id,
                    Descripcion = materiaPrima.Descripcion,
                    Precio = materiaPrima.Precio,
                    Cantidad = materiaPrima.Cantidad
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Materia Prima en la base de datos dada una colección de propiedades
        /// del mismo objeto.
        /// </summary>
        /// <param name="properties">Colección de propiedades de la materia prima.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no es proporcionada.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no puede ser nula.");

            MateriaPrima materiaPrima = materiaPrimaDao.Update(new MateriaPrima
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToSingle(properties["Precio"]),
                Cantidad = Convert.ToSingle(properties["Cantidad"]),
                Estado = (bool)properties["Estado"]
            });

            if (materiaPrima is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina un registro de tipo Materia Prima de la base de datos dado el ID del mismo.
        /// </summary>
        /// <param name="id">Identificador único de la materia prima.</param>
        public void Delete(int id)
        {
            MateriaPrima materiaPrima = materiaPrimaDao.Delete(GetById(id));

            if (materiaPrima is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
