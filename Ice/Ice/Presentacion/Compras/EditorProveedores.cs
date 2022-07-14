using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelos.Compras;
using Ice.Servicios.Interfaces;
using Ice.Servicios.Compras;

namespace Ice.Presentacion.Compras
{
    public partial class EditorProveedores : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Proveedor.
        /// </summary>
        private readonly Proveedor Proveedor;

        /// <summary>
        /// Lista de observadores que están pendientes a ésta clase.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Proveedor de servicios para los objetos de tipo Proveedor.
        /// </summary>
        private readonly ProveedorService Service;

        public EditorProveedores(Proveedor proveedor)
        {
            InitializeComponent();
            Proveedor = proveedor;
            Observadores = new List<IObservador>();
            Service = new ProveedorService();
        }

        private void EditorProveedores_Load(object sender, EventArgs e)
        {
            if (Proveedor is null) return;

            TxtNombre.Text = Proveedor.Nombre;
            TxtTelefono.Text = Proveedor.Telefono;
            TxtDireccion.Text = Proveedor.Direccion;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Nombre", TxtNombre.Text },
                {"Telefono", TxtTelefono.Text },
                {"Direccion", TxtDireccion.Text }
            };

            try
            {
                if (Proveedor is null)
                {
                    Service.Create(properties);
                }
                else
                {
                    properties.Add("Id", Proveedor.Id);
                    properties.Add("Estado", Proveedor.Estado);

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
            TxtNombre.Text = string.Empty;
            TxtTelefono.Text = string.Empty;
            TxtDireccion.Text = string.Empty;
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
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
