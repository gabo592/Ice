using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelos.Inventario;
using Ice.Servicios.Interfaces;
using Ice.Servicios.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class EditorMateriasPrimas : Form, ISujeto
    {
        /// <summary>
        /// Objeto simple de tipo Materia Prima.
        /// </summary>
        private readonly MateriaPrima MateriaPrima;

        /// <summary>
        /// Lista de observadores pendientes a los cambios que notifique esta clase.
        /// </summary>
        private readonly List<IObservador> Observadores;

        /// <summary>
        /// Proveedor de servicios para Materias Primas.
        /// </summary>
        private readonly MateriasPrimasService Service;

        public EditorMateriasPrimas(MateriaPrima materiaPrima)
        {
            InitializeComponent();
            MateriaPrima = materiaPrima;
            Observadores = new List<IObservador>();
            Service = new MateriasPrimasService();
        }

        public void AgregarObervador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void Notificar()
        {
            Observadores.ForEach(observador => observador.Actualizar());
        }

        private void EditorMateriasPrimas_Load(object sender, EventArgs e)
        {
            if (MateriaPrima is null) return;

            TxtDescripcion.Text = MateriaPrima.Descripcion;
            NumPrecio.Value = Convert.ToDecimal(MateriaPrima.Precio);
            NumCantidad.Value = Convert.ToDecimal(MateriaPrima.Cantidad);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>
            {
                {"Descripcion", TxtDescripcion.Text },
                {"Precio", NumPrecio.Value },
                {"Cantidad", NumCantidad.Value }
            };

            try
            {
                if (MateriaPrima is null)
                {
                    Service.Create(properties);
                }
                else
                {
                    properties.Add("Id", MateriaPrima.Id);
                    properties.Add("Estado", MateriaPrima.Estado);

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
            TxtDescripcion.Text = string.Empty;
            NumPrecio.Value = NumPrecio.Minimum;
            NumCantidad.Value = NumCantidad.Minimum;
        }
    }
}
