using System;
using System.Collections.Generic;
using System.Linq;
using Ice.Servicios.Base;
using Conexion.Interfaces.Inventario;
using Ice.ViewModels.Inventario;
using Modelos.Inventario;

namespace Ice.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de proveer los servicios a las Categorías de Productos.
    /// </summary>
    internal class CategoriasProductosService : ServicioBase
    {
        /// <summary>
        /// DAO para las Categorías de Productos 
        /// </summary>
        private readonly ICategoriaProductoDao categoriaProductoDao;

        public CategoriasProductosService()
        {
            categoriaProductoDao = DaoFactory.Get<ICategoriaProductoDao>(Handler);
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Categoría de Producto en base a la colección de parámetros proporcionados.
        /// </summary>
        /// <param name="properties">Colección de propiedades de la categoría.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no es proporcionada.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas");

            CategoriaProducto categoriaProducto = categoriaProductoDao.Create(new CategoriaProducto
            {
                Nombre = properties["Nombre"].ToString(),
                Descripcion = properties["Descripcion"].ToString()
            });

            if (categoriaProducto is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="ICategoriaProductoDao.GetById(int)"/>
        public CategoriaProducto GetById(int id) => categoriaProductoDao.GetById(id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que
        /// contengan el valor especificado, puede ser por nombre o descripción.
        /// </summary>
        /// <param name="value">Filtro de búsqueda.</param>
        /// <returns>Colección genérica de objetos de tipo Categoría de Productos desde una vista personalizada.</returns>
        public IEnumerable<CategoriaProductoView> GetCategoriaProductos(string value)
        {
            if (string.IsNullOrEmpty(value)) value = null;

            IEnumerable<CategoriaProducto> categoriaProductos = categoriaProductoDao.Read(value);

            return categoriaProductos.Select(categoria =>
            {
                return new CategoriaProductoView
                {
                    Id = categoria.Id,
                    Nombre = categoria.Nombre,
                    Descripcion = categoria.Descripcion
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Categoría de Producto en base a la colección de parámetros proporcionados.
        /// </summary>
        /// <param name="properties">Colección de propiedades de la categoría.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades no es proporcionada.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "Las propiedades del objeto no pueden ser nulas");

            CategoriaProducto categoriaProducto = categoriaProductoDao.Update(new CategoriaProducto
            {
                Id = (int)properties["Id"],
                Nombre = properties["Nombre"].ToString(),
                Descripcion = properties["Descripcion"].ToString(),
                Estado = (bool)properties["Estado"]
            });

            if (categoriaProducto is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina un registro de tipo Categoría de Producto en base al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del registro a eliminar.</param>
        public void Delete(int id)
        {
            CategoriaProducto categoriaProducto = categoriaProductoDao.Delete(GetById(id));

            if (categoriaProducto is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
