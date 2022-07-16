using System;
using System.Windows.Forms;
using Ice.Presentacion.Base;
using Ice.Servicios.Inventario;
using Ice.Servicios.Interfaces;
using Ice.ViewModels.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class BuscadorProductos : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductosService Service;

        public BuscadorProductos() : base("Productos")
        {
            InitializeComponent();
            Service = new ProductosService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(Service.GetProductos(string.Empty));
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs eventArgs)
        {
            EditorProductos editorProductos = new EditorProductos(null);
            editorProductos.AgregarObervador(this);
            editorProductos.ShowDialog();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs eventArgs)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView is null)
            {
                MessageBox.Show(this, "Para eliminar un Producto, primero debe seleccionarlo.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var producto = Service.GetById(productoView.Id);
            
            if (producto is null)
            {
                MessageBox.Show(this, $"No fue posible encontrar el producto con ID: {producto.Id}.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar el producto con ID: {producto.Id}?", "Pregunta.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(producto.Id);

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs eventArgs)
        {
            ProductoView productoView = GetSelected<ProductoView>();

            if (productoView is null)
            {
                MessageBox.Show(this, "Para modificar un Producto, primero debe seleccionarlo.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var producto = Service.GetById(productoView.Id);

            if (producto is null)
            {
                MessageBox.Show(this, $"No fue posible encontrar el producto con ID: {producto.Id}.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorProductos editorProductos = new EditorProductos(producto);
            editorProductos.AgregarObervador(this);
            editorProductos.ShowDialog();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(Service.GetProductos(descripcion: text));
        }
    }
}
