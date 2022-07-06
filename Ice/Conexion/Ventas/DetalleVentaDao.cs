using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Ventas;
using Comun.Utilidades;
using Modelos.Ventas;

namespace Conexion.Ventas
{
    /// <summary>
    /// Acceso a datos con el objeto Detalle de Venta.
    /// </summary>
    internal class DetalleVentaDao : BaseDao<DetalleVenta>, IDetalleVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la conexión de base de datos y una instancia
        /// del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión con base de datos.</param>
        /// <param name="handler">Instancia del administrador de errores.</param>
        public DetalleVentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleVenta Create(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleVentaCreate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleVenta Delete(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.DetalleVentaDelete, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleVentaDao.GetByIdProducto(int)"/>
        public IEnumerable<DetalleVenta> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.GetByIdVenta(int)"/>
        public IEnumerable<DetalleVenta> GetByIdVenta(int idVenta)
        {
            if (idVenta.Equals(default) || idVenta <= 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return Enumerable.Empty<DetalleVenta>();
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleVenta> Read()
        {
            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleVentaDao.Read(int, int)"/>
        public DetalleVenta Read(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default) || idVenta <= 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"IdProducto", idProducto },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleVenta Update(DetalleVenta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleVentaUpdate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }
    }
}
