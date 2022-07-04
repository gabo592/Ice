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
    /// Acceso a datos con el objeto Categoría de Producto.
    /// </summary>
    internal class CategoriaProductoDao : BaseDao<CategoriaProducto>, ICategoriaProductoDao
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
        public CategoriaProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override CategoriaProducto Create(CategoriaProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.CategoriaProductoCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override CategoriaProducto Delete(CategoriaProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.CategoriaProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICategoriaProductoDao.GetById(int)"/>
        public CategoriaProducto GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CategoriaProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<CategoriaProducto> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="ICategoriaProductoDao.Read(string)"/>
        public IEnumerable<CategoriaProducto> Read(string value)
        {
            return Read(StoredProcedures.CategoriaProductoRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Descripcion", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override CategoriaProducto Update(CategoriaProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.CategoriaProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }
    }
}
