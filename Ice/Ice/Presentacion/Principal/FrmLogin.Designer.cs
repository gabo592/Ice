namespace Ice.Presentacion.Principal
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblSubTitulo = new System.Windows.Forms.Label();
            this.BorderRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TxtClave = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnSalir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnIngresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.TbPnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = global::Ice.Properties.Resources.ice_cream;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(343, 96);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 96);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(343, 36);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "¡Bienvenido!";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTitulo
            // 
            this.LblSubTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitulo.Location = new System.Drawing.Point(0, 132);
            this.LblSubTitulo.Name = "LblSubTitulo";
            this.LblSubTitulo.Size = new System.Drawing.Size(343, 38);
            this.LblSubTitulo.TabIndex = 2;
            this.LblSubTitulo.Text = "Ingresa con tu cuenta exitente.";
            this.LblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorderRadius
            // 
            this.BorderRadius.ElipseRadius = 15;
            this.BorderRadius.TargetControl = this;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 4;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TbPnlDatos.Controls.Add(this.TxtNombre, 1, 0);
            this.TbPnlDatos.Controls.Add(this.TxtClave, 1, 1);
            this.TbPnlDatos.Controls.Add(this.BtnSalir, 1, 2);
            this.TbPnlDatos.Controls.Add(this.BtnIngresar, 2, 2);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 170);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 3;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TbPnlDatos.Size = new System.Drawing.Size(343, 142);
            this.TbPnlDatos.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AcceptsReturn = false;
            this.TxtNombre.AcceptsTab = false;
            this.TxtNombre.AnimationSpeed = 200;
            this.TxtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtNombre.AutoSizeHeight = true;
            this.TxtNombre.BackColor = System.Drawing.Color.Transparent;
            this.TxtNombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtNombre.BackgroundImage")));
            this.TxtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtNombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtNombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtNombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtNombre.BorderRadius = 15;
            this.TxtNombre.BorderThickness = 1;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbPnlDatos.SetColumnSpan(this.TxtNombre, 2);
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.FillColor = System.Drawing.Color.White;
            this.TxtNombre.ForeColor = System.Drawing.Color.Black;
            this.TxtNombre.HideSelection = true;
            this.TxtNombre.IconLeft = null;
            this.TxtNombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.IconPadding = 10;
            this.TxtNombre.IconRight = global::Ice.Properties.Resources.user;
            this.TxtNombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.Lines = new string[0];
            this.TxtNombre.Location = new System.Drawing.Point(20, 3);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtNombre.Modified = false;
            this.TxtNombre.Multiline = false;
            this.TxtNombre.Name = "TxtNombre";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties1.FillColor = System.Drawing.Color.White;
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtNombre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtNombre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.OnIdleState = stateProperties4;
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(3);
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtNombre.PlaceholderText = "Nombre de usuario";
            this.TxtNombre.ReadOnly = false;
            this.TxtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(302, 42);
            this.TxtNombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombre.TextMarginBottom = 0;
            this.TxtNombre.TextMarginLeft = 3;
            this.TxtNombre.TextMarginTop = 1;
            this.TxtNombre.TextPlaceholder = "Nombre de usuario";
            this.TxtNombre.UseSystemPasswordChar = false;
            this.TxtNombre.WordWrap = true;
            // 
            // TxtClave
            // 
            this.TxtClave.AcceptsReturn = false;
            this.TxtClave.AcceptsTab = false;
            this.TxtClave.AnimationSpeed = 200;
            this.TxtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtClave.AutoSizeHeight = true;
            this.TxtClave.BackColor = System.Drawing.Color.White;
            this.TxtClave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtClave.BackgroundImage")));
            this.TxtClave.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtClave.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TxtClave.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            this.TxtClave.BorderColorIdle = System.Drawing.Color.Silver;
            this.TxtClave.BorderRadius = 15;
            this.TxtClave.BorderThickness = 1;
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbPnlDatos.SetColumnSpan(this.TxtClave, 2);
            this.TxtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.DefaultText = "";
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.FillColor = System.Drawing.Color.White;
            this.TxtClave.ForeColor = System.Drawing.Color.Black;
            this.TxtClave.HideSelection = true;
            this.TxtClave.IconLeft = null;
            this.TxtClave.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.IconPadding = 10;
            this.TxtClave.IconRight = global::Ice.Properties.Resources._lock;
            this.TxtClave.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.Lines = new string[0];
            this.TxtClave.Location = new System.Drawing.Point(20, 51);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtClave.Modified = false;
            this.TxtClave.Multiline = false;
            this.TxtClave.Name = "TxtClave";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties5.FillColor = System.Drawing.Color.White;
            stateProperties5.ForeColor = System.Drawing.Color.Black;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtClave.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(189)))), ((int)(((byte)(242)))));
            stateProperties7.ForeColor = System.Drawing.Color.White;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.White;
            this.TxtClave.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.OnIdleState = stateProperties8;
            this.TxtClave.Padding = new System.Windows.Forms.Padding(3);
            this.TxtClave.PasswordChar = '●';
            this.TxtClave.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtClave.PlaceholderText = "Contraseña";
            this.TxtClave.ReadOnly = false;
            this.TxtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.ShortcutsEnabled = true;
            this.TxtClave.Size = new System.Drawing.Size(302, 42);
            this.TxtClave.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtClave.TabIndex = 1;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtClave.TextMarginBottom = 0;
            this.TxtClave.TextMarginLeft = 3;
            this.TxtClave.TextMarginTop = 1;
            this.TxtClave.TextPlaceholder = "Contraseña";
            this.TxtClave.UseSystemPasswordChar = true;
            this.TxtClave.WordWrap = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.AllowAnimations = true;
            this.BtnSalir.AllowMouseEffects = true;
            this.BtnSalir.AllowToggling = false;
            this.BtnSalir.AnimationSpeed = 200;
            this.BtnSalir.AutoGenerateColors = false;
            this.BtnSalir.AutoRoundBorders = false;
            this.BtnSalir.AutoSizeLeftIcon = true;
            this.BtnSalir.AutoSizeRightIcon = true;
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.ButtonText = "Salir";
            this.BtnSalir.ButtonTextMarginLeft = 0;
            this.BtnSalir.ColorContrastOnClick = 45;
            this.BtnSalir.ColorContrastOnHover = 45;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnSalir.CustomizableEdges = borderEdges1;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSalir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSalir.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnSalir.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSalir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.IconLeft = null;
            this.BtnSalir.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnSalir.IconMarginLeft = 11;
            this.BtnSalir.IconPadding = 10;
            this.BtnSalir.IconRight = null;
            this.BtnSalir.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSalir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnSalir.IconSize = 25;
            this.BtnSalir.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnSalir.IdleBorderRadius = 0;
            this.BtnSalir.IdleBorderThickness = 0;
            this.BtnSalir.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnSalir.IdleIconLeftImage = null;
            this.BtnSalir.IdleIconRightImage = null;
            this.BtnSalir.IndicateFocus = false;
            this.BtnSalir.Location = new System.Drawing.Point(20, 99);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSalir.OnDisabledState.BorderRadius = 15;
            this.BtnSalir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnDisabledState.BorderThickness = 1;
            this.BtnSalir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSalir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSalir.OnDisabledState.IconLeftImage = null;
            this.BtnSalir.OnDisabledState.IconRightImage = null;
            this.BtnSalir.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnSalir.onHoverState.BorderRadius = 15;
            this.BtnSalir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.onHoverState.BorderThickness = 1;
            this.BtnSalir.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnSalir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.onHoverState.IconLeftImage = null;
            this.BtnSalir.onHoverState.IconRightImage = null;
            this.BtnSalir.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnSalir.OnIdleState.BorderRadius = 15;
            this.BtnSalir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnIdleState.BorderThickness = 1;
            this.BtnSalir.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BtnSalir.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.OnIdleState.IconLeftImage = null;
            this.BtnSalir.OnIdleState.IconRightImage = null;
            this.BtnSalir.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnSalir.OnPressedState.BorderRadius = 15;
            this.BtnSalir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSalir.OnPressedState.BorderThickness = 1;
            this.BtnSalir.OnPressedState.FillColor = System.Drawing.Color.White;
            this.BtnSalir.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.OnPressedState.IconLeftImage = null;
            this.BtnSalir.OnPressedState.IconRightImage = null;
            this.BtnSalir.Size = new System.Drawing.Size(148, 40);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSalir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSalir.TextMarginLeft = 0;
            this.BtnSalir.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnSalir.UseDefaultRadiusAndThickness = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.AllowAnimations = true;
            this.BtnIngresar.AllowMouseEffects = true;
            this.BtnIngresar.AllowToggling = false;
            this.BtnIngresar.AnimationSpeed = 200;
            this.BtnIngresar.AutoGenerateColors = false;
            this.BtnIngresar.AutoRoundBorders = false;
            this.BtnIngresar.AutoSizeLeftIcon = true;
            this.BtnIngresar.AutoSizeRightIcon = true;
            this.BtnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIngresar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIngresar.BackgroundImage")));
            this.BtnIngresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIngresar.ButtonText = "Iniciar Sesión";
            this.BtnIngresar.ButtonTextMarginLeft = 0;
            this.BtnIngresar.ColorContrastOnClick = 45;
            this.BtnIngresar.ColorContrastOnHover = 45;
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnIngresar.CustomizableEdges = borderEdges2;
            this.BtnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnIngresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIngresar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnIngresar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnIngresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIngresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.IconLeft = null;
            this.BtnIngresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIngresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnIngresar.IconMarginLeft = 11;
            this.BtnIngresar.IconPadding = 10;
            this.BtnIngresar.IconRight = null;
            this.BtnIngresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIngresar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnIngresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnIngresar.IconSize = 25;
            this.BtnIngresar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnIngresar.IdleBorderRadius = 0;
            this.BtnIngresar.IdleBorderThickness = 0;
            this.BtnIngresar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnIngresar.IdleIconLeftImage = null;
            this.BtnIngresar.IdleIconRightImage = null;
            this.BtnIngresar.IndicateFocus = false;
            this.BtnIngresar.Location = new System.Drawing.Point(174, 99);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnIngresar.OnDisabledState.BorderRadius = 15;
            this.BtnIngresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIngresar.OnDisabledState.BorderThickness = 1;
            this.BtnIngresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnIngresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnIngresar.OnDisabledState.IconLeftImage = null;
            this.BtnIngresar.OnDisabledState.IconRightImage = null;
            this.BtnIngresar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIngresar.onHoverState.BorderRadius = 15;
            this.BtnIngresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIngresar.onHoverState.BorderThickness = 1;
            this.BtnIngresar.onHoverState.FillColor = System.Drawing.Color.White;
            this.BtnIngresar.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.onHoverState.IconLeftImage = null;
            this.BtnIngresar.onHoverState.IconRightImage = null;
            this.BtnIngresar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIngresar.OnIdleState.BorderRadius = 15;
            this.BtnIngresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIngresar.OnIdleState.BorderThickness = 1;
            this.BtnIngresar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIngresar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.OnIdleState.IconLeftImage = null;
            this.BtnIngresar.OnIdleState.IconRightImage = null;
            this.BtnIngresar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIngresar.OnPressedState.BorderRadius = 15;
            this.BtnIngresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnIngresar.OnPressedState.BorderThickness = 1;
            this.BtnIngresar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(217)))));
            this.BtnIngresar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.OnPressedState.IconLeftImage = null;
            this.BtnIngresar.OnPressedState.IconRightImage = null;
            this.BtnIngresar.Size = new System.Drawing.Size(148, 40);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIngresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnIngresar.TextMarginLeft = 0;
            this.BtnIngresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnIngresar.UseDefaultRadiusAndThickness = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 332);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.LblSubTitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.TbPnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblSubTitulo;
        private Bunifu.Framework.UI.BunifuElipse BorderRadius;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private Bunifu.UI.WinForms.BunifuTextBox TxtNombre;
        private Bunifu.UI.WinForms.BunifuTextBox TxtClave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSalir;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnIngresar;
    }
}