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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblSubTitulo = new System.Windows.Forms.Label();
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.PbUsuario = new System.Windows.Forms.PictureBox();
            this.PbClave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.FlwPnlBotones.SuspendLayout();
            this.TbPnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClave)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = global::Ice.Properties.Resources.ice_cream;
            this.PbLogo.Location = new System.Drawing.Point(0, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(355, 104);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnEntrar);
            this.FlwPnlBotones.Controls.Add(this.BtnCerrar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(0, 260);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(355, 45);
            this.FlwPnlBotones.TabIndex = 1;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrar.Location = new System.Drawing.Point(241, 3);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(111, 36);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Iniciar Sesión";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(124, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(111, 36);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 104);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(355, 33);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "¡Bienvenido!";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSubTitulo
            // 
            this.LblSubTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTitulo.Location = new System.Drawing.Point(0, 137);
            this.LblSubTitulo.Name = "LblSubTitulo";
            this.LblSubTitulo.Size = new System.Drawing.Size(355, 30);
            this.LblSubTitulo.TabIndex = 3;
            this.LblSubTitulo.Text = "Ingrese con su cuenta existente.";
            this.LblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 4;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.7321F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.02387F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.TbPnlDatos.Controls.Add(this.TxtNombre, 2, 0);
            this.TbPnlDatos.Controls.Add(this.TxtClave, 2, 1);
            this.TbPnlDatos.Controls.Add(this.PbUsuario, 1, 0);
            this.TbPnlDatos.Controls.Add(this.PbClave, 1, 1);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 167);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 2;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.05263F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.94737F));
            this.TbPnlDatos.Size = new System.Drawing.Size(355, 76);
            this.TbPnlDatos.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(55, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(289, 24);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtClave
            // 
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(55, 38);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(289, 24);
            this.TxtClave.TabIndex = 1;
            this.TxtClave.UseSystemPasswordChar = true;
            // 
            // PbUsuario
            // 
            this.PbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbUsuario.Image = global::Ice.Properties.Resources.user;
            this.PbUsuario.Location = new System.Drawing.Point(10, 3);
            this.PbUsuario.Name = "PbUsuario";
            this.PbUsuario.Size = new System.Drawing.Size(39, 24);
            this.PbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUsuario.TabIndex = 2;
            this.PbUsuario.TabStop = false;
            // 
            // PbClave
            // 
            this.PbClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbClave.Image = global::Ice.Properties.Resources._lock;
            this.PbClave.Location = new System.Drawing.Point(10, 38);
            this.PbClave.Name = "PbClave";
            this.PbClave.Size = new System.Drawing.Size(39, 24);
            this.PbClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClave.TabIndex = 3;
            this.PbClave.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 305);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.LblSubTitulo);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.FlwPnlBotones);
            this.Controls.Add(this.PbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.FlwPnlBotones.ResumeLayout(false);
            this.TbPnlDatos.ResumeLayout(false);
            this.TbPnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblSubTitulo;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox PbUsuario;
        private System.Windows.Forms.PictureBox PbClave;
    }
}