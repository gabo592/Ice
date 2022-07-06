using System;
using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Ubicacion;
using Comun.Utilidades;
using Modelos.Ubicacion;

namespace Conexion.Ubicacion
{
    /// <summary>
    /// Acceso a datos con el objeto Municipio.
    /// </summary>
    internal class MunicipioDao : BaseDao<Municipio>, IMunicipioDao
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
        public MunicipioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Municipio Create(Municipio model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Municipio Delete(Municipio model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IMunicipioDao.GetById(int)"/>
        public Municipio GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Municipio> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IMunicipioDao.Read(string)"/>
        public IEnumerable<Municipio> Read(string nombre)
        {
            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        /// <inheritdoc cref="IMunicipioDao.Read(int)"/>
        public IEnumerable<Municipio> Read(int idDepartamento)
        {
            if (idDepartamento.Equals(default) || idDepartamento <= 0)
            {
                Handler.Add("ID_DEPARTAMENTO_DEFAULT");
                return Enumerable.Empty<Municipio>();
            }

            return Read(StoredProcedures.MunicipioRead, new Dictionary<string, object>
            {
                {"IdDepartamento", idDepartamento }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Municipio Update(Municipio model)
        {
            throw new NotImplementedException();
        }
    }
}
