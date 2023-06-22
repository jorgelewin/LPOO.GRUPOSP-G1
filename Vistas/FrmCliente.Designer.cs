namespace Vistas
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.txtNroCarnet = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNroCarnet = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.btnBuscarOrdenados = new System.Windows.Forms.Button();
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.pnlTitulo.SuspendLayout();
            this.gpbCliente.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(990, 32);
            this.pnlTitulo.TabIndex = 36;
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
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.lblObraSocial);
            this.gpbCliente.Controls.Add(this.cboObraSocial);
            this.gpbCliente.Controls.Add(this.txtNroCarnet);
            this.gpbCliente.Controls.Add(this.txtDireccion);
            this.gpbCliente.Controls.Add(this.txtNombre);
            this.gpbCliente.Controls.Add(this.txtApellido);
            this.gpbCliente.Controls.Add(this.txtDNI);
            this.gpbCliente.Controls.Add(this.lblNroCarnet);
            this.gpbCliente.Controls.Add(this.lblDireccion);
            this.gpbCliente.Controls.Add(this.lblNombre);
            this.gpbCliente.Controls.Add(this.lblApellido);
            this.gpbCliente.Controls.Add(this.lblDNI);
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.ForeColor = System.Drawing.Color.White;
            this.gpbCliente.Location = new System.Drawing.Point(517, 58);
            this.gpbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gpbCliente.Size = new System.Drawing.Size(429, 350);
            this.gpbCliente.TabIndex = 27;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Datos del Cliente";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraSocial.Location = new System.Drawing.Point(19, 251);
            this.lblObraSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(71, 15);
            this.lblObraSocial.TabIndex = 16;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.BackColor = System.Drawing.Color.White;
            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(137, 247);
            this.cboObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(275, 25);
            this.cboObraSocial.TabIndex = 15;
            // 
            // txtNroCarnet
            // 
            this.txtNroCarnet.Location = new System.Drawing.Point(137, 298);
            this.txtNroCarnet.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroCarnet.Name = "txtNroCarnet";
            this.txtNroCarnet.Size = new System.Drawing.Size(275, 23);
            this.txtNroCarnet.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 196);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(275, 23);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 94);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(275, 23);
            this.txtApellido.TabIndex = 11;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(137, 43);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(275, 23);
            this.txtDNI.TabIndex = 9;
            // 
            // lblNroCarnet
            // 
            this.lblNroCarnet.AutoSize = true;
            this.lblNroCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCarnet.Location = new System.Drawing.Point(19, 303);
            this.lblNroCarnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroCarnet.Name = "lblNroCarnet";
            this.lblNroCarnet.Size = new System.Drawing.Size(108, 15);
            this.lblNroCarnet.TabIndex = 8;
            this.lblNroCarnet.Text = "Numero de Carnet";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(19, 199);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(59, 15);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 147);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(19, 95);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(19, 43);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(28, 15);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(542, 431);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(376, 33);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.btnBuscarOrdenados);
            this.pnlGrilla.Controls.Add(this.dgwClientes);
            this.pnlGrilla.Controls.Add(this.btnEliminar);
            this.pnlGrilla.Controls.Add(this.btnEditar);
            this.pnlGrilla.Controls.Add(this.btnBuscar);
            this.pnlGrilla.Controls.Add(this.txtPattern);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 32);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(509, 468);
            this.pnlGrilla.TabIndex = 37;
            // 
            // btnBuscarOrdenados
            // 
            this.btnBuscarOrdenados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnBuscarOrdenados.FlatAppearance.BorderSize = 0;
            this.btnBuscarOrdenados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOrdenados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOrdenados.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOrdenados.Location = new System.Drawing.Point(364, 20);
            this.btnBuscarOrdenados.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarOrdenados.Name = "btnBuscarOrdenados";
            this.btnBuscarOrdenados.Size = new System.Drawing.Size(73, 28);
            this.btnBuscarOrdenados.TabIndex = 47;
            this.btnBuscarOrdenados.Text = "Ordenar";
            this.btnBuscarOrdenados.UseVisualStyleBackColor = false;
            this.btnBuscarOrdenados.Click += new System.EventHandler(this.btnBuscarOrdenados_Click);
            // 
            // dgwClientes
            // 
            this.dgwClientes.AllowUserToAddRows = false;
            this.dgwClientes.AllowUserToDeleteRows = false;
            this.dgwClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgwClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwClientes.ColumnHeadersHeight = 40;
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwClientes.EnableHeadersVisualStyles = false;
            this.dgwClientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgwClientes.Location = new System.Drawing.Point(22, 59);
            this.dgwClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.ReadOnly = true;
            this.dgwClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwClientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgwClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClientes.Size = new System.Drawing.Size(464, 340);
            this.dgwClientes.TabIndex = 36;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(105, 420);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 25);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(22, 420);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 25);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(283, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 28);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(22, 25);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(2);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(250, 20);
            this.txtPattern.TabIndex = 38;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 500);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "Gestionar Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
            this.pnlGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtNroCarnet;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNroCarnet;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.Button btnBuscarOrdenados;
    }
}