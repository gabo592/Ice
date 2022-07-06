using System;
using System.Collections.Generic;
using System.Reflection;
using Comun.Utilidades;
using Conexion.Compras;
using Conexion.Interfaces.Compras;
using Conexion.Interfaces.Inventario;
using Conexion.Interfaces.RecursosHumanos;
using Conexion.Interfaces.Seguridad;
using Conexion.Interfaces.Ubicacion;
using Conexion.Interfaces.Ventas;
using Conexion.Inventario;
using Conexion.RecursosHumanos;
using Conexion.Seguridad;
using Conexion.Ubicacion;
using Conexion.Ventas;

namespace Conexion
{
    /// <summary>
    /// Clase encargada de fabricar los DAO reconocidos y administrados por el sistema.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Mapping de los DAO reconocidos y administrados por el sistema.
        /// </summary>
        private static readonly IDictionary<Type, Type> Dao = new Dictionary<Type, Type> 
        {
            //Compras
            {typeof(ICompraDao), typeof(CompraDao) },
            {typeof(IDetalleCompraDao), typeof(DetalleCompraDao) },
            {typeof(IProveedorDao), typeof(ProveedorDao) },

            //Inventario
            {typeof(ICategoriaProductoDao), typeof(CategoriaProductoDao) },
            {typeof(IDetalleProductoDao), typeof(DetalleProductoDao) },
            {typeof(IMateriaPrimaDao), typeof(MateriaPrimaDao) },
            {typeof(IProductoDao), typeof(ProductoDao) },

            //RecursosHumanos
            {typeof(IEmpleadoDao), typeof(EmpleadoDao) },

            //Seguridad
            {typeof(IDetalleUsuarioDao), typeof(DetalleUsuarioDao) },
            {typeof(IRolDao), typeof(RolDao) },
            {typeof(IUsuarioDao), typeof(UsuarioDao) },

            //Ubicacion
            {typeof(IDepartamentoDao), typeof(DepartamentoDao) },
            {typeof(IMunicipioDao), typeof(MunicipioDao) },

            //Ventas
            {typeof(IClienteDao), typeof(ClienteDao) },
            {typeof(IDetalleVentaDao), typeof(DetalleVentaDao) },
            {typeof(IVentaDao), typeof(VentaDao) }
        };

        /// <summary>
        /// Realiza la invocación de un DAO en base al mapping ya configurado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <returns>El tipo de DAO a invocar.</returns>
        /// <exception cref="ArgumentException">Se dispara cuando el DAO no se encuentra mapeado.</exception>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se logra obtener un constructor que cumpla con los requisitos del DAO.</exception>
        public static TDao Invoke<TDao>(string connectionString, ErrorHandler handler)
        {
            if (!Dao.TryGetValue(typeof(TDao), out Type type)) throw new ArgumentException("El DAO a invocar no se encuentra mapeado.");

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string), typeof(ErrorHandler) });

            if (constructor is null) throw new ArgumentNullException("El DAO a invocar no tiene configurado un constructor que admita la cadena de conexión y una instancia del administrador de errores.");

            return (TDao)constructor.Invoke(new object[] { connectionString, handler });
        }
    }
}
