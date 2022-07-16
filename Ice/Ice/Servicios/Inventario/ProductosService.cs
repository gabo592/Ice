using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ice.ViewModels.Inventario;
using Ice.Servicios.Base;
using Conexion.Interfaces.Inventario;
using Modelos.Inventario;

namespace Ice.Servicios.Inventario
{
    /// <summary>
    /// Clase encargada de proveer los servicios para los Productos.
    /// </summary>
    internal class ProductosService : ServicioBase
    {
        /// <summary>
        /// DAO para los productos.
        /// </summary>
        private readonly IProductoDao productoDao;

        /// <summary>
        /// Proveedor de servicios para las Categorías de Productos.
        /// </summary>
        private readonly CategoriasProductosService categoriasProductosService;

        public ProductosService()
        {
            productoDao = DaoFactory.Get<IProductoDao>(Handler);
            categoriasProductosService = new CategoriasProductosService();
        }

        /// <summary>
        /// Crea un nuevo registro de tipo Producto dentro de la base de datos dada una colección de propiedades
        /// del mismo.
        /// </summary>
        /// <param name="properties">Colección de propiedades del producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades del objeto no es proporcionada.</exception>
        public void Create(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no pueden ser nulas.");

            Producto producto = productoDao.Create(new Producto
            {
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToSingle(properties["Precio"]),
                Cantidad = Convert.ToSingle(properties["Cantidad"]),
                IdCategoria = (int)properties["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id) => productoDao.GetById(id);

        /// <summary>
        /// Realiza la búsqueda en la base de datos hasta encontrar una serie de registros de tipo
        /// Producto que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto.</param>
        /// <returns>Colección de objetos de tipo Producto desde una vista personalizada, que resulten de la búsqueda.</returns>
        public IEnumerable<ProductoView> GetProductos(string descripcion)
        {
            IEnumerable<Producto> productos = productoDao.Read(descripcion);

            return productos.Select(producto =>
            {
                var categoriaProducto = categoriasProductosService.GetById(producto.IdCategoria);

                return new ProductoView
                {
                    Id = producto.Id,
                    Descripcion = producto.Descripcion,
                    Precio = producto.Precio,
                    Cantidad = producto.Cantidad,
                    Categoria = categoriaProducto.Nombre
                };
            });
        }

        /// <summary>
        /// Actualiza un registro de tipo Producto dentro de la base de datos dada una colección de propiedades
        /// del mismo.
        /// </summary>
        /// <param name="properties">Colección de propiedades del producto.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando la colección de propiedades del objeto no es proporcionada.</exception>
        public void Update(IDictionary<string, object> properties)
        {
            if (properties is null) throw new ArgumentNullException(nameof(properties), "La colección de propiedades del objeto no pueden ser nulas.");

            Producto producto = productoDao.Update(new Producto
            {
                Id = (int)properties["Id"],
                Descripcion = properties["Descripcion"].ToString(),
                Precio = Convert.ToSingle(properties["Precio"]),
                Cantidad = Convert.ToSingle(properties["Cantidad"]),
                Estado = (bool)properties["Estado"],
                IdCategoria = (int)properties["IdCategoria"]
            });

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        /// <summary>
        /// Elimina un registro de tipo Producto de la base de datos de acuerdo al ID proporcionado.
        /// </summary>
        /// <param name="id">Identificador único del Producto.</param>
        public void Delete(int id)
        {
            Producto producto = productoDao.Delete(GetById(id));

            if (producto is null) Handler.Add("MODELO_NULO");
        }

        public override void Dispose()
        {
            Handler.Clear();
            categoriasProductosService.Dispose();
        }

        public override string GetErrorMessage()
        {
            StringBuilder builder = new StringBuilder();

            if (Handler != null && Handler.HasError())
            {
                builder.AppendLine(Handler.GetErrorMessage());
            }

            if (categoriasProductosService != null && categoriasProductosService.HasError())
            {
                builder.AppendLine(categoriasProductosService.GetErrorMessage());
            }

            return builder.ToString();
        }

        public override bool HasError() => Handler.HasError() || categoriasProductosService.HasError();
    }
}
