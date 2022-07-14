using System;
using System.Collections.Generic;
using System.Linq;
using Ice.Servicios.Base;
using Conexion.Interfaces.Compras;
using Modelos.Compras;
using Ice.ViewModels.Compras;

namespace Ice.Servicios.Compras
{
    internal class ProveedorService : ServicioBase
    {
        /// <summary>
        /// DAO para los Proveedores.
        /// </summary>
        private readonly IProveedorDao proveedorDao;

        public ProveedorService()
        {
            proveedorDao = DaoFactory.Get<IProveedorDao>(Handler);
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Proveedor en la base de datos dada una colección de propiedades
        /// del mismo.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no se proporciona.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no puede ser nula.");

            Proveedor proveedor = proveedorDao.Create(new Proveedor
            {
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString()
            });

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IProveedorDao.GetById(int)"/>
        public Proveedor GetById(int id) => proveedorDao.GetById(id);

        /// <summary>
        /// Realiza la búsqueda de proveedores dentro de la base de datos que coincidan
        /// con el valor a buscar. Puede ser por: nombre, dirección, etc.
        /// </summary>
        /// <param name="value">Valor a buscar dentro de la base de datos.</param>
        /// <returns>Colección genérica de objetos de tipo Proveedor desde una vista personalizada, que resulten de la búsqueda.</returns>
        public IEnumerable<ProveedorView> GetProveedores(string value)
        {
            if (string.IsNullOrEmpty(value)) value = null;

            IEnumerable<Proveedor> proveedores = proveedorDao.Read(value);

            return proveedores.Select(proveedor =>
            {
                return new ProveedorView
                {
                    Id = proveedor.Id,
                    Nombre = proveedor.Nombre,
                    Telefono = proveedor.Telefono,
                    Direccion = proveedor.Direccion
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Proveedor en la base de datos dada una colección de propiedades
        /// del mismo.
        /// </summary>
        /// <param name="properties">Propiedades del Proveedor.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no se proporciona.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no puede ser nula.");

            Proveedor proveedor = proveedorDao.Update(new Proveedor
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Telefono = properties["Telefono"].ToString(),
                Direccion = properties["Direccion"].ToString(),
                Estado = (bool)properties["Estado"]
            });

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina un registro de tipo Proveedor de la base de datos dado el ID del mismo.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor a eliminar.</param>
        public void Delete(int id)
        {
            Proveedor proveedor = proveedorDao.Delete(GetById(id));

            if (proveedor is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
