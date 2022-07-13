using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelos.Inventario;
using Ice.Servicios.Inventario;
using Ice.Servicios.Interfaces;

namespace Ice.Presentacion.Inventario
{
    public partial class EditorCategoriasProductos : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Categoría de Producto.
        /// </summary>
        private CategoriaProducto CategoriaProducto;

        /// <summary>
        /// Proveedor de servicios para las Categorías de Productos.
        /// </summary>
        private readonly CategoriasProductosService Service;

        /// <summary>
        /// Lista de observadores que estarán pendientes a esta clase.
        /// </summary>
        private readonly List<IObservador> Observadores;

        public EditorCategoriasProductos(CategoriaProducto categoriaProducto)
        {
            InitializeComponent();
            CategoriaProducto = categoriaProducto;
            Service = new CategoriasProductosService();
            Observadores = new List<IObservador>();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Nombre", TxtNombre.Text },
                {"Descripcion", TxtDescripcion.Text }
            };

            try
            {
                if (CategoriaProducto is null)
                {
                    Service.Create(properties);
                }
                else
                {
                    properties.Add("Id", CategoriaProducto.Id);
                    properties.Add("Estado", CategoriaProducto.Estado);
                    Service.Update(properties);
                }

                if (Service.HasError())
                {
                    MessageBox.Show(this, Service.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void AgregarObervador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }

        private void EditorCategoriasProductos_Load(object sender, EventArgs e)
        {
            if (CategoriaProducto is null) return;

            TxtNombre.Text = CategoriaProducto.Nombre;
            TxtDescripcion.Text = CategoriaProducto.Descripcion;
        }
    }
}
