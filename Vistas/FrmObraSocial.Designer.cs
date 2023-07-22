namespace Vistas
{
    partial class FrmObraSocial
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
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListaVentas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbObraSocial = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pnlGrilla.SuspendLayout();
            this.gpbObraSocial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.btnCerrar);
            this.pnlGrilla.Controls.Add(this.btnListaVentas);
            this.pnlGrilla.Controls.Add(this.btnGuardar);
            this.pnlGrilla.Controls.Add(this.gpbObraSocial);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(990, 469);
            this.pnlGrilla.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(917, 10);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 23);
            this.btnCerrar.TabIndex = 54;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListaVentas
            // 
            this.btnListaVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnListaVentas.FlatAppearance.BorderSize = 0;
            this.btnListaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaVentas.ForeColor = System.Drawing.Color.White;
            this.btnListaVentas.Location = new System.Drawing.Point(158, 34);
            this.btnListaVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaVentas.Name = "btnListaVentas";
            this.btnListaVentas.Size = new System.Drawing.Size(167, 30);
            this.btnListaVentas.TabIndex = 57;
            this.btnListaVentas.Text = "Ver Clientes Afiliados";
            this.btnListaVentas.UseVisualStyleBackColor = false;
            this.btnListaVentas.Click += new System.EventHandler(this.btnListaVentas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(542, 326);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(376, 33);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // gpbObraSocial
            // 
            this.gpbObraSocial.Controls.Add(this.txtTelefono);
            this.gpbObraSocial.Controls.Add(this.txtRazonSocial);
            this.gpbObraSocial.Controls.Add(this.lblCUIT);
            this.gpbObraSocial.Controls.Add(this.lblRazonSocial);
            this.gpbObraSocial.Controls.Add(this.lblDireccion);
            this.gpbObraSocial.Controls.Add(this.lblTelefono);
            this.gpbObraSocial.Controls.Add(this.txtCUIT);
            this.gpbObraSocial.Controls.Add(this.txtDireccion);
            this.gpbObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbObraSocial.ForeColor = System.Drawing.Color.White;
            this.gpbObraSocial.Location = new System.Drawing.Point(517, 54);
            this.gpbObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.gpbObraSocial.Name = "gpbObraSocial";
            this.gpbObraSocial.Padding = new System.Windows.Forms.Padding(2);
            this.gpbObraSocial.Size = new System.Drawing.Size(429, 253);
            this.gpbObraSocial.TabIndex = 55;
            this.gpbObraSocial.TabStop = false;
            this.gpbObraSocial.Text = "Datos de Obra Social";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 197);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(275, 23);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(137, 94);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(275, 23);
            this.txtRazonSocial.TabIndex = 9;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.Color.White;
            this.lblCUIT.Location = new System.Drawing.Point(19, 43);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(34, 15);
            this.lblCUIT.TabIndex = 3;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.White;
            this.lblRazonSocial.Location = new System.Drawing.Point(19, 94);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 15);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(19, 145);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(19, 197);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(137, 43);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(275, 23);
            this.txtCUIT.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 145);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(275, 23);
            this.txtDireccion.TabIndex = 8;
            // 
            // FrmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 469);
            this.Controls.Add(this.pnlGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmObraSocial";
            this.Text = "Gestionar Obras Sociales";
            this.pnlGrilla.ResumeLayout(false);
            this.gpbObraSocial.ResumeLayout(false);
            this.gpbObraSocial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListaVentas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbObraSocial;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtDireccion;

    }
}