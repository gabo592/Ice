using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ice.Presentacion.Base;
using Ice.Servicios.Interfaces;
using Ice.Servicios.Inventario;

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
            throw new NotImplementedException();
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs eventArgs)
        {
            EditorCategoriasProductos editorCategoriasProductos = new EditorCategoriasProductos(null);
            editorCategoriasProductos.Show();
        }

        protected override void OnBtnModificar_Click(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        public void Actualizar()
        {
            LoadDataGrid(categoriasProductosService.GetCategoriaProductos(string.Empty));
        }
    }
}
