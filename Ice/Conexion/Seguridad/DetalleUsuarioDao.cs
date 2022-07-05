using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Seguridad;
using Comun.Utilidades;
using Modelos.Seguridad;

namespace Conexion.Seguridad
{
    /// <summary>
    /// Acceso a datos con el objeto Detalle de Usuario
    /// </summary>
    internal class DetalleUsuarioDao : BaseDao<DetalleUsuario>, IDetalleUsuarioDao
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
        public DetalleUsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override DetalleUsuario Create(DetalleUsuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.DetalleUsuarioCreate, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override DetalleUsuario Delete(DetalleUsuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.DetalleUsuarioDelete, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IDetalleUsuarioDao.GetByIdRol(int)"/>
        public IEnumerable<DetalleUsuario> GetByIdRol(int idRol)
        {
            if (idRol.Equals(default) || idRol <= 0)
            {
                Handler.Add("ID_ROL_DEFAULT");
                return Enumerable.Empty<DetalleUsuario>();
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdRol", idRol },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleUsuarioDao.GetByIdUsuario(int)"/>
        public IEnumerable<DetalleUsuario> GetByIdUsuario(int idUsuario)
        {
            if (idUsuario.Equals(default) || idUsuario <= 0)
            {
                Handler.Add("ID_USUARIO_DEFAULT");
                return Enumerable.Empty<DetalleUsuario>();
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdUsuario", idUsuario },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<DetalleUsuario> Read()
        {
            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IDetalleUsuarioDao.Read(int, int)"/>
        public DetalleUsuario Read(int idUsuario, int idRol)
        {
            if (idRol.Equals(default) || idRol <= 0)
            {
                Handler.Add("ID_ROL_DEFAULT");
                return null;
            }

            if (idUsuario.Equals(default) || idUsuario <= 0)
            {
                Handler.Add("ID_USUARIO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdUsuario", idUsuario },
                {"IdRol", idRol },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override DetalleUsuario Update(DetalleUsuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.DetalleUsuarioUpdate, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }
    }
}
