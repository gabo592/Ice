using System;
using System.Windows.Forms;
using Ice.Presentacion.Base;
using Ice.Servicios.Compras;
using Ice.Servicios.Interfaces;
using Ice.ViewModels.Compras;

namespace Ice.Presentacion.Compras
{
    public partial class BuscadorProveedores : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los objetos de tipo Proveedor.
        /// </summary>
        private readonly ProveedorService Service;

        public BuscadorProveedores() : base("Proveedores")
        {
            InitializeComponent();
            Service = new ProveedorService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(Service.GetProveedores(string.Empty));
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs eventArgs)
        {
            EditorProveedores editorProveedores = new EditorProveedores(null);
            editorProveedores.AgregarObervador(this);
            editorProveedores.Show();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs eventArgs)
        {
            ProveedorView proveedorView = GetSelected<ProveedorView>();

            if (proveedorView is null)
            {
                MessageBox.Show(this, "Para eliminar a un Proveedor, primero debe seleccionarlo.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var proveedor = Service.GetById(proveedorView.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, $"No se logró encontrar al Proveedor con ID: {proveedor.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar al Proveedor con ID: {proveedor.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(proveedor.Id);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs eventArgs)
        {
            ProveedorView proveedorView = GetSelected<ProveedorView>();

            if (proveedorView is null)
            {
                MessageBox.Show(this, "Para modificar a un Proveedor, primero debe seleccionarlo.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var proveedor = Service.GetById(proveedorView.Id);

            if (proveedor is null)
            {
                MessageBox.Show(this, $"No se logró encontrar al Proveedor con ID: {proveedor.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorProveedores editorProveedores = new EditorProveedores(proveedor);
            editorProveedores.AgregarObervador(this);
            editorProveedores.Show();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(Service.GetProveedores(text));
        }
    }
}
