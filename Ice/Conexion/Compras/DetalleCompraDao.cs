using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Compras;
using Comun.Utilidades;
using Modelos.Compras;

namespace Conexion.Compras
{
    /// <summary>
    /// Acceso a datos con el objeto Detalle de Compra.
    /// </summary>
    internal class DetalleCompraDao : BaseDao<DetalleCompa>, IDetalleCompraDao
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
        /// <param name="handler">Administrador de errores.</param>
        public DetalleCompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleCompa Create(DetalleCompa model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleCompa Delete(DetalleCompa model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            if (model.IdCompra.Equals(default) || model.IdCompra <= 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (model.IdMateriaPrima.Equals(default) || model.IdMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraDelete, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleCompraDao.GetByIdCompra(int)"/>
        public IEnumerable<DetalleCompa> GetByIdCompra(int idCompra)
        {
            if (idCompra.Equals(default) || idCompra <= 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return Enumerable.Empty<DetalleCompa>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleCompraDao.GetByIdMateriaPrima(int)"/>
        public IEnumerable<DetalleCompa> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return Enumerable.Empty<DetalleCompa>();
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleCompa> Read()
        {
            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleCompraDao.Read(int, int)"/>
        public DetalleCompa Read(int idCompra, int idMateriaPrima)
        {
            if (idCompra.Equals(default) || idCompra <= 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleCompa Update(DetalleCompa model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleCompraUpdate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }
    }
}
