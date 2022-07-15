using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ice.Presentacion.Inventario;
using Ice.Presentacion.Compras;

namespace Ice.Presentacion.Principal
{
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Formulario que se mostrará en el panel principal.
        /// </summary>
        private Form Form;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Desea cerrar el programa? Es posible que información sin guardar se pierda.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            Application.Exit();
        }

        private void AddForm(Form form)
        {
            if (Form != null) Form.Close();

            Form = form;

            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;

            PnlPrincipal.Controls.Add(Form);
            PnlPrincipal.Tag = Form;

            Form.BringToFront();
            Form.Show();
        }

        private void PbMenu_Click(object sender, EventArgs e)
        {
            if (PnlSideBar.Visible)
            {
                PnlSideBar.Visible = false;
            }
            else
            {
                SideBarTransition.Show(PnlSideBar);
                PnlSideBar.Visible = true;
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {

        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AddForm(new BuscadorProveedores());
        }

        private void BtnCategoriasProductos_Click(object sender, EventArgs e)
        {
            AddForm(new BuscadorCategoriasProductos());
        }

        private void BtnMateriasPrimas_Click(object sender, EventArgs e)
        {
            AddForm(new BuscadorMateriasPrimas());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
