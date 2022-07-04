using System;
using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Interfaces.Compras;
using Conexion.Constantes;
using Comun.Utilidades;
using Modelos.Compras;

namespace Conexion.Compras
{
    /// <summary>
    /// Acceso a datos con el objeto Compra.
    /// </summary>
    internal class CompraDao : BaseDao<Compra>, ICompraDao
    {
        /// <summary>
        /// Administrador de Errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        /// <summary>
        /// Constructor de la clase. Toma en cuenta la conexión de base de datos y una instancia
        /// del administrador de errores.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión con base de datos.</param>
        /// <param name="handler">Instancia del administrador de errores.</param>
        public CompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Compra Create(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.CompraCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Compra Delete(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.CompraDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICompraDao.GetById(int)"/>
        public Compra GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="ICompraDao.GetByIdEmpleado(int)"/>
        public IEnumerable<Compra> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="ICompraDao.GetByIdProveedor(int)"/>
        public IEnumerable<Compra> GetByIdProveedor(int idProveedor)
        {
            if (idProveedor.Equals(default) || idProveedor <= 0)
            {
                Handler.Add("ID_PROVEEDOR_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idProveedor },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Compra> Read()
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="ICompraDao.Read(DateTime)"/>
        public IEnumerable<Compra> Read(DateTime fecha)
        {
            if (fecha == null)
            {
                Handler.Add("FECHA_DEFAULT");
                return Enumerable.Empty<Compra>();
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Compra Update(Compra model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.CompraUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
