using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ice.Presentacion.Base
{
    public abstract partial class FrmBuscador : Form
    {
        /// <summary>
        /// Constructor del buscador. Toma en cuenta el título que mostrará en el mismo, por lo general hace
        /// referencia al catálogo que éste mostrará y administrará.
        /// </summary>
        /// <param name="titulo">Título del buscador o nombre del catálogo.</param>
        public FrmBuscador(string titulo)
        {
            InitializeComponent();
            LblTitulo.Text = titulo;
        }

        /// <summary>
        /// Evento que contiene todas las intrucciones cuando la propiedad Text del TxtBuscar cambie.
        /// </summary>
        /// <param name="text">Texto que contiene el control para filtrar una búsqueda dentro del DataGridView.</param>
        protected abstract void OnTxtBuscar_TextChanged(string text);

        /// <summary>
        /// Evento que contiene todas las intrucciones cuando se dispare el evento Click sobre el botón Agregar.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al objeto.</param>
        /// <param name="eventArgs">Argumentos del evento.</param>
        protected abstract void OnBtnAgregar_Click(object sender, EventArgs eventArgs);

        /// <summary>
        /// Evento que contiene todas las intrucciones cuando se dispare el evento Click sobre el botón Modificar.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al objeto.</param>
        /// <param name="eventArgs">Argumentos del evento.</param>
        protected abstract void OnBtnModificar_Click(object sender, EventArgs eventArgs);

        /// <summary>
        /// Evento que contiene todas las intrucciones cuando se dispare el evento Click sobre el botón Eliminar.
        /// </summary>
        /// <param name="sender">Objeto que manda a llamar al objeto.</param>
        /// <param name="eventArgs">Argumentos del evento.</param>
        protected abstract void OnBtnEliminar_Click(object sender, EventArgs eventArgs);

        /// <summary>
        /// Método encargado de cargar la información en el DataGridView de una colección de modelos de tipo
        /// especificado.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo a cargar.</typeparam>
        /// <param name="models">Colección de modelos a cargar.</param>
        protected void LoadDataGrid<TModel>(IEnumerable<TModel> models) where TModel : new ()
        {
            if (models is null) return;            

            DgvCatalogo.DataSource = models.ToArray();
        }

        /// <summary>
        /// Método encargado de obtener el primer modelo seleccionado del DataGridView.
        /// </summary>
        /// <typeparam name="TModel">Tipo de modelo cargado en el DataGridView.</typeparam>
        /// <returns>Primer modelo de tipo especificado seleccionado del DataGridView.</returns>
        protected TModel GetSelected<TModel>() where TModel : new ()
        {
            if (DgvCatalogo.SelectedRows.Count == 0) return default;

            TModel[] models = (TModel[])DgvCatalogo.DataSource;

            return models[DgvCatalogo.SelectedRows[0].Index];
        }

        private void TxtBuscar_TextChange(object sender, EventArgs e)
        {
            OnTxtBuscar_TextChanged(TxtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            OnBtnAgregar_Click(sender, e);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            OnBtnModificar_Click(sender, e);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            OnBtnEliminar_Click(sender, e);
        }
    }
}
