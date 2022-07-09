using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice.Servicios.Base;
using Modelos.Seguridad;
using Conexion.Interfaces.Seguridad;

namespace Ice.Servicios.Seguridad
{
    internal class UsuarioService : ServicioBase
    {
        /// <summary>
        /// DAO para los usuarios.
        /// </summary>
        private readonly IUsuarioDao usuarioDao;

        public UsuarioService()
        {
            usuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
        }

        public void Login(string nombre, string clave)
        {
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 4 || nombre.Length > 50)
            {
                Handler.Add("NOMBRE_USUARIO_DEFAULT");
                return;
            }

            if (string.IsNullOrEmpty(clave))
            {
                Handler.Add("CLAVE_USUARIO_DEFAULT");
                return;
            }

            Usuario usuario = usuarioDao.Login(nombre, clave);

            if (usuario is null)
            {
                Handler.Add("MODELO_NULO");
                return;
            }

            Session.SetSession(usuario);
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
