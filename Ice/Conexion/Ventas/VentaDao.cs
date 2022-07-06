using System;
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
    /// Acceso a datos con el objeto Venta.
    /// </summary>
    internal class VentaDao : BaseDao<Venta>, IVentaDao
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
        public VentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Venta Create(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Venta Delete(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IVentaDao.GetById(int)"/>
        public Venta GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IVentaDao.GetByIdCliente(int)"/>
        public IEnumerable<Venta> GetByIdCliente(int idCliente)
        {
            if (idCliente.Equals(default) || idCliente <= 0)
            {
                Handler.Add("ID_CLIENTE_DEFAULT");
                return Enumerable.Empty<Venta>();
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdCliente", idCliente },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IVentaDao.GetByIdEmpleado(int)"/>
        public IEnumerable<Venta> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Venta>();
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Venta> Read()
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IVentaDao.Read(DateTime)"/>
        public IEnumerable<Venta> Read(DateTime fecha)
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Venta Update(Venta model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
