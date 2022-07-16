using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Modelos.Inventario;
using Ice.Servicios.Inventario;
using Ice.Servicios.Interfaces;
using Ice.ViewModels.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class EditorProductos : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Producto.
        /// </summary>
        private readonly Producto Producto;

        /// <summary>
        /// Lista de observadores administrados por esta clase.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Proveedor de servicios para los productos.
        /// </summary>
        private readonly ProductosService productosService;

        /// <summary>
        /// Proveedor de servicios para las categorias de productos.
        /// </summary>
        private readonly CategoriasProductosService categoriasProductosService;

        public EditorProductos(Producto producto)
        {
            InitializeComponent();
            Producto = producto;
            Observadores = new List<IObservador>();
            productosService = new ProductosService();
            categoriasProductosService = new CategoriasProductosService();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CategoriaProductoView categoriaProductoView = GetCategoriaProductoView();

            if (categoriaProductoView is null)
            {
                MessageBox.Show(this, "Debe seleccionar una categoría de producto para poder continuar.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var categoria = categoriasProductosService.GetById(categoriaProductoView.Id);

            if (categoria is null)
            {
                MessageBox.Show(this, $"No se encontró a la categoría de producto con ID: {categoria.Id}.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Descripcion", TxtDescripcion.Text },
                {"Precio", NumPrecio.Value },
                {"Cantidad", NumCantidad.Value },
                {"IdCategoria", categoria.Id }
            };

            try
            {
                if (Producto is null)
                {
                    productosService.Create(properties);
                }
                else
                {
                    properties.Add("Id", Producto.Id);
                    properties.Add("Estado", Producto.Estado);

                    productosService.Update(properties);
                }

                if (productosService.HasError())
                {
                    MessageBox.Show(this, productosService.GetErrorMessage(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Text = string.Empty;
            NumPrecio.Value = NumPrecio.Minimum;
            NumCantidad.Value = NumCantidad.Minimum;
            TxtBuscarCategoria.Text = string.Empty;
        }

        private void TxtBuscarCategoria_TextChange(object sender, EventArgs e)
        {
            LoadDgvCategorias();
        }

        private void EditorProductos_Load(object sender, EventArgs e)
        {
            LoadDgvCategorias();

            if (Producto is null) return;

            TxtDescripcion.Text = Producto.Descripcion;
            NumPrecio.Value = Convert.ToDecimal(Producto.Precio);
            NumCantidad.Value = Convert.ToDecimal(Producto.Cantidad);

            for (int i = 0; i < DgvCategorias.RowCount; i++)
            {
                int categoriaId = (int)DgvCategorias.Rows[i].Cells["Id"].Value;

                if (categoriaId == Producto.IdCategoria)
                {
                    DgvCategorias.Rows[i].Selected = true;
                    DgvCategorias.CurrentCell = DgvCategorias.Rows[i].Cells["Id"];
                    break;
                }
            }
        }

        /// <summary>
        /// Carga la información de las categorías dentro de su respectivo DataGridView.
        /// </summary>
        private void LoadDgvCategorias()
        {
            IEnumerable<CategoriaProductoView> categorias = categoriasProductosService.GetCategoriaProductos(TxtBuscarCategoria.Text);
            DgvCategorias.DataSource = categorias.ToArray();
        }

        /// <summary>
        /// Busca dentro del DataGridView de las Categorías de Productos, el primer registro seleccionado.
        /// </summary>
        /// <returns>Primera Categoría de Producto seleccionada.</returns>
        private CategoriaProductoView GetCategoriaProductoView()
        {
            if (DgvCategorias.SelectedRows.Count == 0) return null;

            CategoriaProductoView[] categorias = (CategoriaProductoView[])DgvCategorias.DataSource;

            return categorias[DgvCategorias.SelectedRows[0].Index];
        }

        public void AgregarObervador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }
    }
}
