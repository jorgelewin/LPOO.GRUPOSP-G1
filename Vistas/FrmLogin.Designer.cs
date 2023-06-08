namespace Vistas
{
    partial class Login
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
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.linkContraseña = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.lblErrorMensaje2 = new System.Windows.Forms.Label();
            this.lblErrorMensaje1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lnlContraseña = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnlUsuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLogo.Controls.Add(this.pctBoxLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(188, 268);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Image = global::Vistas.Properties.Resources.examen_de_la_vista;
            this.pctBoxLogo.Location = new System.Drawing.Point(39, 77);
            this.pctBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(98, 76);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 0;
            this.pctBoxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(338, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 31);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(232, 61);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(306, 19);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(232, 132);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(306, 19);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Location = new System.Drawing.Point(232, 198);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(307, 32);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // linkContraseña
            // 
            this.linkContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkContraseña.AutoSize = true;
            this.linkContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.linkContraseña.LinkArea = new System.Windows.Forms.LinkArea(0, 27);
            this.linkContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.linkContraseña.Location = new System.Drawing.Point(298, 235);
            this.linkContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(180, 16);
            this.linkContraseña.TabIndex = 0;
            this.linkContraseña.TabStop = true;
            this.linkContraseña.Text = "¿Ha olvidado la contraseña?";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Vistas.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(572, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(11, 12);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::Vistas.Properties.Resources.Minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(558, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(11, 12);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblErrorMensaje2
            // 
            this.lblErrorMensaje2.AutoSize = true;
            this.lblErrorMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblErrorMensaje2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMensaje2.Image = global::Vistas.Properties.Resources.signo_de_exclamacion__2_;
            this.lblErrorMensaje2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMensaje2.Location = new System.Drawing.Point(230, 160);
            this.lblErrorMensaje2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMensaje2.Name = "lblErrorMensaje2";
            this.lblErrorMensaje2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrorMensaje2.Size = new System.Drawing.Size(88, 15);
            this.lblErrorMensaje2.TabIndex = 6;
            this.lblErrorMensaje2.Text = "Error Message";
            this.lblErrorMensaje2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorMensaje2.Visible = false;
            // 
            // lblErrorMensaje1
            // 
            this.lblErrorMensaje1.AutoSize = true;
            this.lblErrorMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblErrorMensaje1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMensaje1.Image = global::Vistas.Properties.Resources.signo_de_exclamacion__2_;
            this.lblErrorMensaje1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMensaje1.Location = new System.Drawing.Point(230, 88);
            this.lblErrorMensaje1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMensaje1.Name = "lblErrorMensaje1";
            this.lblErrorMensaje1.Size = new System.Drawing.Size(88, 15);
            this.lblErrorMensaje1.TabIndex = 7;
            this.lblErrorMensaje1.Text = "Error Message";
            this.lblErrorMensaje1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblErrorMensaje1.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnlContraseña,
            this.lnlUsuario});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 268);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lnlContraseña
            // 
            this.lnlContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlContraseña.BorderColor = System.Drawing.Color.DimGray;
            this.lnlContraseña.Enabled = false;
            this.lnlContraseña.Name = "lnlContraseña";
            this.lnlContraseña.X1 = 232;
            this.lnlContraseña.X2 = 539;
            this.lnlContraseña.Y1 = 155;
            this.lnlContraseña.Y2 = 155;
            // 
            // lnlUsuario
            // 
            this.lnlUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnlUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.lnlUsuario.Enabled = false;
            this.lnlUsuario.Name = "lnlUsuario";
            this.lnlUsuario.X1 = 232;
            this.lnlUsuario.X2 = 539;
            this.lnlUsuario.Y1 = 85;
            this.lnlUsuario.Y2 = 85;
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(585, 268);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.lblErrorMensaje2);
            this.Controls.Add(this.lblErrorMensaje1);
            this.Controls.Add(this.linkContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.logout);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel linkContraseña;
        private System.Windows.Forms.Label lblErrorMensaje1;
        private System.Windows.Forms.Label lblErrorMensaje2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnlContraseña;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnlUsuario;
    }
}