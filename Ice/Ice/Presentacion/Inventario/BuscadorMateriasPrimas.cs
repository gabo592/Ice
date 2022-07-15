using System;
using System.Windows.Forms;
using Ice.Presentacion.Base;
using Ice.Servicios.Inventario;
using Ice.Servicios.Interfaces;
using Ice.ViewModels.Inventario;

namespace Ice.Presentacion.Inventario
{
    public partial class BuscadorMateriasPrimas : FrmBuscador, IObservador
    {
        /// <summary>
        /// Proveedor de servicios para las Materias Primas.
        /// </summary>
        private readonly MateriasPrimasService Service;

        public BuscadorMateriasPrimas() : base("Materias Primas")
        {
            InitializeComponent();
            Service = new MateriasPrimasService();
            Actualizar();
        }

        public void Actualizar()
        {
            LoadDataGrid(Service.GetMateriasPrimas(string.Empty));
        }

        protected override void OnBtnAgregar_Click(object sender, EventArgs eventArgs)
        {
            EditorMateriasPrimas editorMateriasPrimas = new EditorMateriasPrimas(null);
            editorMateriasPrimas.AgregarObervador(this);
            editorMateriasPrimas.Show();
        }

        protected override void OnBtnEliminar_Click(object sender, EventArgs eventArgs)
        {
            MateriaPrimaView materiaPrimaView = GetSelected<MateriaPrimaView>();

            if (materiaPrimaView is null)
            {
                MessageBox.Show(this, "Para eliminar un registro de Materia Prima, antes debe seleccionar una.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var materiaPrima = Service.GetById(materiaPrimaView.Id);

            if (materiaPrima is null)
            {
                MessageBox.Show(this, $"No se encontró a la Materia Prima con ID: {materiaPrima.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(this, $"¿Desea eliminar la Materia Prima con ID: {materiaPrima.Id}?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                Service.Delete(materiaPrima.Id);

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
            MateriaPrimaView materiaPrimaView = GetSelected<MateriaPrimaView>();

            if (materiaPrimaView is null)
            {
                MessageBox.Show(this, "Para eliminar un registro de Materia Prima, antes debe seleccionar una.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var materiaPrima = Service.GetById(materiaPrimaView.Id);

            if (materiaPrima is null)
            {
                MessageBox.Show(this, $"No se encontró a la Materia Prima con ID: {materiaPrima.Id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditorMateriasPrimas editorMateriasPrimas = new EditorMateriasPrimas(materiaPrima);
            editorMateriasPrimas.AgregarObervador(this);
            editorMateriasPrimas.Show();
        }

        protected override void OnTxtBuscar_TextChanged(string text)
        {
            LoadDataGrid(Service.GetMateriasPrimas(descripcion: text));
        }
    }
}
