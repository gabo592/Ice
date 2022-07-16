using System;
using System.Windows.Forms;
using Ice.Servicios.Seguridad;

namespace Ice.Presentacion.Principal
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Proveedor de servicios para los usuarios.
        /// </summary>
        private readonly UsuarioService Service;

        public FrmLogin()
        {
            InitializeComponent();
            Service = new UsuarioService();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Service.Login(nombre: TxtNombre.Text, clave: TxtClave.Text);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
