using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
