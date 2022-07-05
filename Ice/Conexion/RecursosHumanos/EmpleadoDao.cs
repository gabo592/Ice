using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.RecursosHumanos;
using Comun.Utilidades;
using Modelos.RecursosHumanos;

namespace Conexion.RecursosHumanos
{
    /// <summary>
    /// Acceso a datos con el objeto Empleado.
    /// </summary>
    internal class EmpleadoDao : BaseDao<Empleado>, IEmpleadoDao
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
        public EmpleadoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Empleado Create(Empleado model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.EmpleadoCreate, new Dictionary<string, object>
            {
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula},
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Empleado Delete(Empleado model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.EmpleadoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IEmpleadoDao.GetById(int)"/>
        public Empleado GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IEmpleadoDao.GetByIdMunicipio(int)"/>
        public IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio)
        {
            if (idMunicipio.Equals(default) || idMunicipio <= 0)
            {
                Handler.Add("ID_MUNICIPIO_DEFAULT");
                return Enumerable.Empty<Empleado>();
            }

            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"IdMunicipio", idMunicipio },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Empleado> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IEmpleadoDao.Read(string)"/>
        public IEnumerable<Empleado> Read(string value)
        {
            return Read(StoredProcedures.EmpleadoRead, new Dictionary<string, object>
            {
                {"PrimerNombre", value },
                {"SegundoNombre", value },
                {"PrimerApellido", value },
                {"SegundoApellido", value },
                {"Direccion", value },
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Empleado Update(Empleado model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.EmpleadoCreate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"PrimerNombre", model.PrimerNombre },
                {"SegundoNombre", model.SegundoNombre },
                {"PrimerApellido", model.PrimerApellido },
                {"SegundoApellido", model.SegundoApellido },
                {"Cedula", model.Cedula},
                {"Telefono", model.Telefono },
                {"Direccion", model.Direccion },
                {"IdMunicipio", model.IdMunicipio }
            }).FirstOrDefault() ?? null;
        }
    }
}
