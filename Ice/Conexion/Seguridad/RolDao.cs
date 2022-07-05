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
    /// Acceso a datos con objeto Rol.
    /// </summary>
    internal class RolDao : BaseDao<Rol>, IRolDao
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
        public RolDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Rol Create(Rol model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.RolCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Rol Delete(Rol model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.RolDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IRolDao.GetById(int)"/>
        public Rol GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.RolRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Rol> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IRolDao.Read(string)"/>
        public IEnumerable<Rol> Read(string value)
        {
            return Read(StoredProcedures.RolRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Descripcion", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Rol Update(Rol model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.RolUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }
    }
}
