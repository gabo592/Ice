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
    /// Acceso a datos con el objeto Detalle de Producto
    /// </summary>
    internal class DetalleProductoDao : BaseDao<DetalleProducto>, IDetalleProductoDao
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
        public DetalleProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleProducto Create(DetalleProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleProductoCreate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleProducto Delete(DetalleProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.DetalleProductoDelete, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleProductoDao.GetByIdMateriaPrima(int)"/>
        public IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleProductoDao.GetByIdProducto(int)"/>
        public IEnumerable<DetalleProducto> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleProducto>();
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleProductoDao.GetDetalleProducto(int, int)"/>
        public DetalleProducto GetDetalleProducto(int idProducto, int idMateriaPrima)
        {
            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleProducto> Read()
        {
            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleProducto Update(DetalleProducto model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleProductoUpdate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }
    }
}
