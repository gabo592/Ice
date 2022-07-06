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
    /// Acceso a datos con el objeto Departamento.
    /// </summary>
    internal class DepartamentoDao : BaseDao<Departamento>, IDepartamentoDao
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
        public DepartamentoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override Departamento Create(Departamento model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override Departamento Delete(Departamento model)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc cref="IDepartamentoDao.GetById(int)"/>
        public Departamento GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<Departamento> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IDepartamentoDao.Read(string)"/>
        public IEnumerable<Departamento> Read(string nombre)
        {
            return Read(StoredProcedures.DepartamentoRead, new Dictionary<string, object>
            {
                {"Nombre", nombre }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override Departamento Update(Departamento model)
        {
            throw new NotImplementedException();
        }
    }
}
