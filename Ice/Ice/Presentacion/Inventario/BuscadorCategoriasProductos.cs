using System;
using System.Windows.Forms;
using Ice.Presentacion.Base;
using Ice.Servicios.Interfaces;
using Ice.Servicios.Inventario;
using Ice.ViewModels.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class BuscadorCategoriasProductos : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para las Categorías de Productos.
        /// </summary>
        private readonly CategoriasProductosService categoriasProductosService;

        public BuscadorCategoriasProductos() : base("Categorías de Productos")
        {
            InitializeComponent();
            categoriasProductosService = new CategoriasProductosService();
            Actualizar();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(categoriasProductosService.GetCategoriaProductos(text));
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs eventArgs)
        {
            EditorCategoriasProductos editorCategoriasProductos = new EditorCategoriasProductos(null);
            editorCategoriasProductos.AgregarObervador(this);
            editorCategoriasProductos.Show();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs eventArgs)
        {
            CategoriaProductoView categoriaProductoView = GetSelected<CategoriaProductoView>();

            if (categoriaProductoView is null)
            {
                MessageBox.Show(this, "Para modificar una Categoría de Producto, antes debe seleccionarla.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var categoria = categoriasProductosService.GetById(categoriaProductoView.Id);

            if (categoria is null)
            {
                MessageBox.Show(this, $"No se logró encontrar la Categoría de Producto con ID: {categoria.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorCategoriasProductos editorCategoriasProductos = new EditorCategoriasProductos(categoria);
            editorCategoriasProductos.AgregarObervador(this);
            editorCategoriasProductos.Show();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs eventArgs)
        {
            CategoriaProductoView categoriaProductoView = GetSelected<CategoriaProductoView>();

            if (categoriaProductoView is null)
            {
                MessageBox.Show(this, "Para eliminar una Categoría de Producto, antes debe seleccionarla.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var categoria = categoriasProductosService.GetById(categoriaProductoView.Id);

            if (categoria is null)
            {
                MessageBox.Show(this, $"No se logró encontrar la Categoría de Producto con ID: {categoria.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la Categoría de Producto con ID: {categoria.Id}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            try
            {
                categoriasProductosService.Delete(categoria.Id);

                if (categoriasProductosService.HasError())
                {
                    MessageBox.Show(this, categoriasProductosService.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(categoriasProductosService.GetCategoriaProductos(string.Empty));
        }
    }
}
