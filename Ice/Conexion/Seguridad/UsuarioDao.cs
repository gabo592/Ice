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
    /// Acceso a datos con el objeto Usuario.
    /// </summary>
    internal class UsuarioDao : BaseDao<Usuario>, IUsuarioDao
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
        public UsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Usuario Create(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.UsuarioCrete, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Usuario Delete(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.UsuarioDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IUsuarioDao.GetById(int)"/>
        public Usuario GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IUsuarioDao.GetByIdEmpleado(int)"/>
        public IEnumerable<Usuario> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return Enumerable.Empty<Usuario>();
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="IUsuarioDao.Login(string, string)"/>
        public Usuario Login(string nombre, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombre) || nombre.Length < 4 || nombre.Length > 50)
            {
                Handler.Add("NOMBRE_USUARIO_DEFAULT");
                return null;
            }

            if (string.IsNullOrWhiteSpace(clave) || clave.Length < 4)
            {
                Handler.Add("CLAVE_USUARIO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioLogin, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Clave", clave }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Usuario> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IUsuarioDao.Read(string)"/>
        public IEnumerable<Usuario> Read(string nombre)
        {
            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Usuario Update(Usuario model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.UsuarioUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
