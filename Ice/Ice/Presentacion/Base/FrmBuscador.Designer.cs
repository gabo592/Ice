namespace Ice.Presentacion.Base
{
    partial class FrmBuscador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscador));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlwPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAgregar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnModificar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TbPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.DgvCatalogo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.FlwPanelBotones.SuspendLayout();
            this.TbPanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(858, 38);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlwPanelBotones
            // 
            this.FlwPanelBotones.Controls.Add(this.BtnAgregar);
            this.FlwPanelBotones.Controls.Add(this.BtnModificar);
            this.FlwPanelBotones.Controls.Add(this.BtnEliminar);
            this.FlwPanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlwPanelBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPanelBotones.Location = new System.Drawing.Point(0, 420);
            this.FlwPanelBotones.Name = "FlwPanelBotones";
            this.FlwPanelBotones.Size = new System.Drawing.Size(858, 52);
            this.FlwPanelBotones.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.AllowAnimations = true;
            this.BtnAgregar.AllowMouseEffects = true;
            this.BtnAgregar.AllowToggling = false;
            this.BtnAgregar.AnimationSpeed = 200;
            this.BtnAgregar.AutoGenerateColors = false;
            this.BtnAgregar.AutoRoundBorders = false;
            this.BtnAgregar.AutoSizeLeftIcon = true;
            this.BtnAgregar.AutoSizeRightIcon = true;
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.BackgroundImage")));
            this.BtnAgregar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAgregar.ButtonText = "Agregar";
            this.BtnAgregar.ButtonTextMarginLeft = 0;
            this.BtnAgregar.ColorContrastOnClick = 45;
            this.BtnAgregar.ColorContrastOnHover = 45;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnAgregar.CustomizableEdges = borderEdges1;
            this.BtnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAgregar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnAgregar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnAgregar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnAgregar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.IconLeft = null;
            this.BtnAgregar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnAgregar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnAgregar.IconMarginLeft = 11;
            this.BtnAgregar.IconPadding = 10;
            this.BtnAgregar.IconRight = null;
            this.BtnAgregar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnAgregar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnAgregar.IconSize = 25;
            this.BtnAgregar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnAgregar.IdleBorderRadius = 0;
            this.BtnAgregar.IdleBorderThickness = 0;
            this.BtnAgregar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnAgregar.IdleIconLeftImage = null;
            this.BtnAgregar.IdleIconRightImage = null;
            this.BtnAgregar.IndicateFocus = false;
            this.BtnAgregar.Location = new System.Drawing.Point(705, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnAgregar.OnDisabledState.BorderRadius = 15;
            this.BtnAgregar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAgregar.OnDisabledState.BorderThickness = 1;
            this.BtnAgregar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnAgregar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnAgregar.OnDisabledState.IconLeftImage = null;
            this.BtnAgregar.OnDisabledState.IconRightImage = null;
            this.BtnAgregar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnAgregar.onHoverState.BorderRadius = 15;
            this.BtnAgregar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAgregar.onHoverState.BorderThickness = 1;
            this.BtnAgregar.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnAgregar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregar.onHoverState.IconLeftImage = null;
            this.BtnAgregar.onHoverState.IconRightImage = null;
            this.BtnAgregar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnAgregar.OnIdleState.BorderRadius = 15;
            this.BtnAgregar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAgregar.OnIdleState.BorderThickness = 1;
            this.BtnAgregar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnAgregar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.OnIdleState.IconLeftImage = null;
            this.BtnAgregar.OnIdleState.IconRightImage = null;
            this.BtnAgregar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnAgregar.OnPressedState.BorderRadius = 15;
            this.BtnAgregar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnAgregar.OnPressedState.BorderThickness = 1;
            this.BtnAgregar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnAgregar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.OnPressedState.IconLeftImage = null;
            this.BtnAgregar.OnPressedState.IconRightImage = null;
            this.BtnAgregar.Size = new System.Drawing.Size(150, 39);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAgregar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAgregar.TextMarginLeft = 0;
            this.BtnAgregar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnAgregar.UseDefaultRadiusAndThickness = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.AllowAnimations = true;
            this.BtnModificar.AllowMouseEffects = true;
            this.BtnModificar.AllowToggling = false;
            this.BtnModificar.AnimationSpeed = 200;
            this.BtnModificar.AutoGenerateColors = false;
            this.BtnModificar.AutoRoundBorders = false;
            this.BtnModificar.AutoSizeLeftIcon = true;
            this.BtnModificar.AutoSizeRightIcon = true;
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificar.BackgroundImage")));
            this.BtnModificar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnModificar.ButtonText = "Modificar";
            this.BtnModificar.ButtonTextMarginLeft = 0;
            this.BtnModificar.ColorContrastOnClick = 45;
            this.BtnModificar.ColorContrastOnHover = 45;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnModificar.CustomizableEdges = borderEdges2;
            this.BtnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnModificar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnModificar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnModificar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnModificar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.IconLeft = null;
            this.BtnModificar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnModificar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnModificar.IconMarginLeft = 11;
            this.BtnModificar.IconPadding = 10;
            this.BtnModificar.IconRight = null;
            this.BtnModificar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnModificar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnModificar.IconSize = 25;
            this.BtnModificar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnModificar.IdleBorderRadius = 0;
            this.BtnModificar.IdleBorderThickness = 0;
            this.BtnModificar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnModificar.IdleIconLeftImage = null;
            this.BtnModificar.IdleIconRightImage = null;
            this.BtnModificar.IndicateFocus = false;
            this.BtnModificar.Location = new System.Drawing.Point(549, 3);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnModificar.OnDisabledState.BorderRadius = 15;
            this.BtnModificar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnModificar.OnDisabledState.BorderThickness = 1;
            this.BtnModificar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnModificar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnModificar.OnDisabledState.IconLeftImage = null;
            this.BtnModificar.OnDisabledState.IconRightImage = null;
            this.BtnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnModificar.onHoverState.BorderRadius = 15;
            this.BtnModificar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnModificar.onHoverState.BorderThickness = 1;
            this.BtnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnModificar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.onHoverState.IconLeftImage = null;
            this.BtnModificar.onHoverState.IconRightImage = null;
            this.BtnModificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnModificar.OnIdleState.BorderRadius = 15;
            this.BtnModificar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnModificar.OnIdleState.BorderThickness = 1;
            this.BtnModificar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnModificar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.OnIdleState.IconLeftImage = null;
            this.BtnModificar.OnIdleState.IconRightImage = null;
            this.BtnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnModificar.OnPressedState.BorderRadius = 15;
            this.BtnModificar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnModificar.OnPressedState.BorderThickness = 1;
            this.BtnModificar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnModificar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.OnPressedState.IconLeftImage = null;
            this.BtnModificar.OnPressedState.IconRightImage = null;
            this.BtnModificar.Size = new System.Drawing.Size(150, 39);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnModificar.TextMarginLeft = 0;
            this.BtnModificar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnModificar.UseDefaultRadiusAndThickness = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AllowAnimations = true;
            this.BtnEliminar.AllowMouseEffects = true;
            this.BtnEliminar.AllowToggling = false;
            this.BtnEliminar.AnimationSpeed = 200;
            this.BtnEliminar.AutoGenerateColors = false;
            this.BtnEliminar.AutoRoundBorders = false;
            this.BtnEliminar.AutoSizeLeftIcon = true;
            this.BtnEliminar.AutoSizeRightIcon = true;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnEliminar.ButtonText = "Eliminar";
            this.BtnEliminar.ButtonTextMarginLeft = 0;
            this.BtnEliminar.ColorContrastOnClick = 45;
            this.BtnEliminar.ColorContrastOnHover = 45;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnEliminar.CustomizableEdges = borderEdges3;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEliminar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnEliminar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.IconLeft = null;
            this.BtnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnEliminar.IconMarginLeft = 11;
            this.BtnEliminar.IconPadding = 10;
            this.BtnEliminar.IconRight = null;
            this.BtnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnEliminar.IconSize = 25;
            this.BtnEliminar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnEliminar.IdleBorderRadius = 0;
            this.BtnEliminar.IdleBorderThickness = 0;
            this.BtnEliminar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnEliminar.IdleIconLeftImage = null;
            this.BtnEliminar.IdleIconRightImage = null;
            this.BtnEliminar.IndicateFocus = false;
            this.BtnEliminar.Location = new System.Drawing.Point(393, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEliminar.OnDisabledState.BorderRadius = 15;
            this.BtnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnEliminar.OnDisabledState.BorderThickness = 1;
            this.BtnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnEliminar.OnDisabledState.IconLeftImage = null;
            this.BtnEliminar.OnDisabledState.IconRightImage = null;
            this.BtnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnEliminar.onHoverState.BorderRadius = 15;
            this.BtnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnEliminar.onHoverState.BorderThickness = 1;
            this.BtnEliminar.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnEliminar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.onHoverState.IconLeftImage = null;
            this.BtnEliminar.onHoverState.IconRightImage = null;
            this.BtnEliminar.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.BtnEliminar.OnIdleState.BorderRadius = 15;
            this.BtnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnEliminar.OnIdleState.BorderThickness = 1;
            this.BtnEliminar.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnEliminar.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnIdleState.IconLeftImage = null;
            this.BtnEliminar.OnIdleState.IconRightImage = null;
            this.BtnEliminar.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.BtnEliminar.OnPressedState.BorderRadius = 15;
            this.BtnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnEliminar.OnPressedState.BorderThickness = 1;
            this.BtnEliminar.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnEliminar.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnPressedState.IconLeftImage = null;
            this.BtnEliminar.OnPressedState.IconRightImage = null;
            this.BtnEliminar.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEliminar.TextMarginLeft = 0;
            this.BtnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnEliminar.UseDefaultRadiusAndThickness = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TbPanelPrincipal
            // 
            this.TbPanelPrincipal.ColumnCount = 3;
            this.TbPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.TbPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.TbPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.TbPanelPrincipal.Controls.Add(this.TxtBuscar, 1, 0);
            this.TbPanelPrincipal.Controls.Add(this.DgvCatalogo, 1, 1);
            this.TbPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPanelPrincipal.Location = new System.Drawing.Point(0, 38);
            this.TbPanelPrincipal.Name = "TbPanelPrincipal";
            this.TbPanelPrincipal.RowCount = 2;
            this.TbPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TbPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TbPanelPrincipal.Size = new System.Drawing.Size(858, 382);
            this.TbPanelPrincipal.TabIndex = 2;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.AcceptsReturn = false;
            this.TxtBuscar.AcceptsTab = false;
            this.TxtBuscar.AnimationSpeed = 200;
            this.TxtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtBuscar.AutoSizeHeight = true;
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtBuscar.BackgroundImage")));
            this.TxtBuscar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtBuscar.BorderRadius = 15;
            this.TxtBuscar.BorderThickness = 1;
            this.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.DefaultText = "";
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.FillColor = System.Drawing.Color.White;
            this.TxtBuscar.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.HideSelection = true;
            this.TxtBuscar.IconLeft = global::Ice.Properties.Resources.search;
            this.TxtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.IconPadding = 10;
            this.TxtBuscar.IconRight = null;
            this.TxtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscar.Lines = new string[0];
            this.TxtBuscar.Location = new System.Drawing.Point(20, 3);
            this.TxtBuscar.MaxLength = 32767;
            this.TxtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtBuscar.Modified = false;
            this.TxtBuscar.Multiline = false;
            this.TxtBuscar.Name = "TxtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.OnIdleState = stateProperties4;
            this.TxtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.TxtBuscar.PasswordChar = '\0';
            this.TxtBuscar.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.PlaceholderText = "Buscar";
            this.TxtBuscar.ReadOnly = false;
            this.TxtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBuscar.SelectedText = "";
            this.TxtBuscar.SelectionLength = 0;
            this.TxtBuscar.SelectionStart = 0;
            this.TxtBuscar.ShortcutsEnabled = true;
            this.TxtBuscar.Size = new System.Drawing.Size(817, 32);
            this.TxtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtBuscar.TextMarginBottom = 0;
            this.TxtBuscar.TextMarginLeft = 8;
            this.TxtBuscar.TextMarginTop = 1;
            this.TxtBuscar.TextPlaceholder = "Buscar";
            this.TxtBuscar.UseSystemPasswordChar = false;
            this.TxtBuscar.WordWrap = true;
            this.TxtBuscar.TextChange += new System.EventHandler(this.TxtBuscar_TextChange);
            // 
            // DgvCatalogo
            // 
            this.DgvCatalogo.AllowCustomTheming = false;
            this.DgvCatalogo.AllowUserToAddRows = false;
            this.DgvCatalogo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvCatalogo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.DgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCatalogo.ColumnHeadersHeight = 40;
            this.DgvCatalogo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DgvCatalogo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DgvCatalogo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCatalogo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DgvCatalogo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCatalogo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DgvCatalogo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DgvCatalogo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DgvCatalogo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DgvCatalogo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCatalogo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DgvCatalogo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCatalogo.CurrentTheme.Name = null;
            this.DgvCatalogo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCatalogo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DgvCatalogo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvCatalogo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DgvCatalogo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCatalogo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCatalogo.EnableHeadersVisualStyles = false;
            this.DgvCatalogo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DgvCatalogo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DgvCatalogo.HeaderBgColor = System.Drawing.Color.Empty;
            this.DgvCatalogo.HeaderForeColor = System.Drawing.Color.White;
            this.DgvCatalogo.Location = new System.Drawing.Point(20, 41);
            this.DgvCatalogo.Name = "DgvCatalogo";
            this.DgvCatalogo.ReadOnly = true;
            this.DgvCatalogo.RowHeadersVisible = false;
            this.DgvCatalogo.RowTemplate.Height = 40;
            this.DgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCatalogo.Size = new System.Drawing.Size(817, 338);
            this.DgvCatalogo.TabIndex = 1;
            this.DgvCatalogo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // FrmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 472);
            this.Controls.Add(this.TbPanelPrincipal);
            this.Controls.Add(this.FlwPanelBotones);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscador";
            this.Text = "Buscador";
            this.FlwPanelBotones.ResumeLayout(false);
            this.TbPanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.FlowLayoutPanel FlwPanelBotones;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnAgregar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnModificar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnEliminar;
        private System.Windows.Forms.TableLayoutPanel TbPanelPrincipal;
        private Bunifu.UI.WinForms.BunifuTextBox TxtBuscar;
        private Bunifu.UI.WinForms.BunifuDataGridView DgvCatalogo;
    }
}