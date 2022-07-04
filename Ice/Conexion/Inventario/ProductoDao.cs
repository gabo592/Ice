using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Inventario;
using Comun.Utilidades;
using Modelos.Inventario;

namespace Conexion.Inventario
{
    /// <summary>
    /// Acceso a datos con el objeto Producto.
    /// </summary>
    internal class ProductoDao : BaseDao<Producto>, IProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la cadena de conexión a la base de datos y una instancia
        /// del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="handler">Instancia del administrador de errores</param>
        public ProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Producto Create(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.ProductoCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Producto Delete(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.ProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IProductoDao.GetById(int)"/>
        public Producto GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IProductoDao.GetByIdCategoria(int)"/>
        public IEnumerable<Producto> GetByIdCategoria(int idCategoria)
        {
            if (idCategoria.Equals(default) || idCategoria <= 0)
            {
                Handler.Add("ID_CATEGORIA_DEFAULT");
                return Enumerable.Empty<Producto>();
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"IdCategoria", idCategoria },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Producto> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IProductoDao.Read(string)"/>
        public IEnumerable<Producto> Read(string descripcion)
        {
            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Producto Update(Producto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.ProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }
    }
}
