using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class EditorCategoriasProductos : Form
    {
        /// <summary>
        /// Objeto simple de tipo Categoría de Producto.
        /// </summary>
        private CategoriaProducto CategoriaProducto;

        public EditorCategoriasProductos(CategoriaProducto categoriaProducto)
        {
            InitializeComponent();
            CategoriaProducto = categoriaProducto;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia la información contenida en los controles.
        /// </summary>
        private void Limpiar()
        {
            TxtNombre.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
        }
    }
}
