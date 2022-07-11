using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ice.Servicios.Seguridad;

namespace Ice.Presentacion.Principal
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Proveedor de servicios para usuarios.
        /// </summary>
        private readonly UsuarioService usuarioService;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string clave = TxtClave.Text;

            try
            {
                usuarioService.Login(nombre, clave);

                if (usuarioService.HasError())
                {
                    MessageBox.Show(this, usuarioService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
