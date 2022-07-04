using System.Collections.Generic;
using System.Linq;
using Conexion.Base;
using Conexion.Constantes;
using Conexion.Interfaces.Inventario;
using Comun.Utilidades;
using Modelos.Inventario;

namespace Conexion.Inventario
{
    /// <summary>
    /// Acceso a datos con el objeto Materia Prima.
    /// </summary>
    internal class MateriaPrimaDao : BaseDao<MateriaPrima>, IMateriaPrimaDao
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
        /// <param name="handler">Instancia del administrador de errores</param>
        public MateriaPrimaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Create(TModel)"/>
        public override MateriaPrima Create(MateriaPrima model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.CREATE)) return null;

            return Read(StoredProcedures.MateriaPrimaCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Delete(TModel)"/>
        public override MateriaPrima Delete(MateriaPrima model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.DELETE)) return null;

            return Read(StoredProcedures.MateriaPrimaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="IMateriaPrimaDao.GetById(int)"/>
        public MateriaPrima GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        /// <inheritdoc cref="BaseDao{TModel}.Read"/>
        public override IEnumerable<MateriaPrima> Read()
        {
            return Read(string.Empty);
        }

        /// <inheritdoc cref="IMateriaPrimaDao.Read(string)"/>
        public IEnumerable<MateriaPrima> Read(string descripcion)
        {
            return Read(StoredProcedures.MateriaPrimaRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion},
                {"Estado", 1 }
            });
        }

        /// <inheritdoc cref="BaseDao{TModel}.Update(TModel)"/>
        public override MateriaPrima Update(MateriaPrima model)
        {
            if (Validaciones.Validar(model, Handler, Validaciones.Operaciones.UPDATE)) return null;

            return Read(StoredProcedures.MateriaPrimaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }
    }
}
