namespace Vistas
{
    partial class FrmListadoProductosVendidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.btnFiltroProductosVendidos = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.gboxFiltroCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnProductosVendidosPorCliente = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.gboxFiltroFecha = new System.Windows.Forms.GroupBox();
            this.btnProductosVendidosPorFecha = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgwProductosVendidos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTotalProductosVendidos = new System.Windows.Forms.Label();
            this.txtTotalProductosVendidos = new System.Windows.Forms.TextBox();
            this.pnlGrilla.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.gboxFiltroCliente.SuspendLayout();
            this.gboxFiltroFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.lblTotalProductosVendidos);
            this.pnlGrilla.Controls.Add(this.txtTotalProductosVendidos);
            this.pnlGrilla.Controls.Add(this.btnFiltroProductosVendidos);
            this.pnlGrilla.Controls.Add(this.gbFiltros);
            this.pnlGrilla.Controls.Add(this.gboxFiltroCliente);
            this.pnlGrilla.Controls.Add(this.gboxFiltroFecha);
            this.pnlGrilla.Controls.Add(this.dgwProductosVendidos);
            this.pnlGrilla.Controls.Add(this.btnCerrar);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlGrilla.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(990, 550);
            this.pnlGrilla.TabIndex = 40;
            // 
            // btnFiltroProductosVendidos
            // 
            this.btnFiltroProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnFiltroProductosVendidos.FlatAppearance.BorderSize = 0;
            this.btnFiltroProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.btnFiltroProductosVendidos.Location = new System.Drawing.Point(445, 61);
            this.btnFiltroProductosVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroProductosVendidos.Name = "btnFiltroProductosVendidos";
            this.btnFiltroProductosVendidos.Size = new System.Drawing.Size(63, 29);
            this.btnFiltroProductosVendidos.TabIndex = 53;
            this.btnFiltroProductosVendidos.Text = "Filtrar";
            this.btnFiltroProductosVendidos.UseVisualStyleBackColor = false;
            this.btnFiltroProductosVendidos.Click += new System.EventHandler(this.btnFiltroProductosVendidos_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rbFecha);
            this.gbFiltros.Controls.Add(this.rbCliente);
            this.gbFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.White;
            this.gbFiltros.Location = new System.Drawing.Point(52, 41);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.gbFiltros.Size = new System.Drawing.Size(388, 49);
            this.gbFiltros.TabIndex = 52;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar por:";
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(242, 20);
            this.rbFecha.Margin = new System.Windows.Forms.Padding(2);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(55, 17);
            this.rbFecha.TabIndex = 2;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Location = new System.Drawing.Point(91, 20);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // gboxFiltroCliente
            // 
            this.gboxFiltroCliente.Controls.Add(this.lblCliente);
            this.gboxFiltroCliente.Controls.Add(this.btnProductosVendidosPorCliente);
            this.gboxFiltroCliente.Controls.Add(this.cboCliente);
            this.gboxFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFiltroCliente.ForeColor = System.Drawing.Color.White;
            this.gboxFiltroCliente.Location = new System.Drawing.Point(52, 39);
            this.gboxFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFiltroCliente.Name = "gboxFiltroCliente";
            this.gboxFiltroCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFiltroCliente.Size = new System.Drawing.Size(830, 59);
            this.gboxFiltroCliente.TabIndex = 51;
            this.gboxFiltroCliente.TabStop = false;
            this.gboxFiltroCliente.Text = "Filtrar por: Cliente";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(57, 24);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 15);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnProductosVendidosPorCliente
            // 
            this.btnProductosVendidosPorCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnProductosVendidosPorCliente.FlatAppearance.BorderSize = 0;
            this.btnProductosVendidosPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosVendidosPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosVendidosPorCliente.ForeColor = System.Drawing.Color.White;
            this.btnProductosVendidosPorCliente.Location = new System.Drawing.Point(747, 19);
            this.btnProductosVendidosPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductosVendidosPorCliente.Name = "btnProductosVendidosPorCliente";
            this.btnProductosVendidosPorCliente.Size = new System.Drawing.Size(63, 27);
            this.btnProductosVendidosPorCliente.TabIndex = 42;
            this.btnProductosVendidosPorCliente.Text = "Filtrar";
            this.btnProductosVendidosPorCliente.UseVisualStyleBackColor = false;
            this.btnProductosVendidosPorCliente.Click += new System.EventHandler(this.btnProductosVendidosPorCliente_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.Color.White;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(118, 20);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(613, 25);
            this.cboCliente.TabIndex = 40;
            // 
            // gboxFiltroFecha
            // 
            this.gboxFiltroFecha.Controls.Add(this.btnProductosVendidosPorFecha);
            this.gboxFiltroFecha.Controls.Add(this.lblFechaHasta);
            this.gboxFiltroFecha.Controls.Add(this.dtpFechaHasta);
            this.gboxFiltroFecha.Controls.Add(this.lblFechaDesde);
            this.gboxFiltroFecha.Controls.Add(this.dtpFechaDesde);
            this.gboxFiltroFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFiltroFecha.ForeColor = System.Drawing.Color.White;
            this.gboxFiltroFecha.Location = new System.Drawing.Point(52, 39);
            this.gboxFiltroFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFiltroFecha.Name = "gboxFiltroFecha";
            this.gboxFiltroFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFiltroFecha.Size = new System.Drawing.Size(830, 59);
            this.gboxFiltroFecha.TabIndex = 50;
            this.gboxFiltroFecha.TabStop = false;
            this.gboxFiltroFecha.Text = "Filtrar por: Fecha";
            // 
            // btnProductosVendidosPorFecha
            // 
            this.btnProductosVendidosPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnProductosVendidosPorFecha.FlatAppearance.BorderSize = 0;
            this.btnProductosVendidosPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosVendidosPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosVendidosPorFecha.ForeColor = System.Drawing.Color.White;
            this.btnProductosVendidosPorFecha.Location = new System.Drawing.Point(753, 19);
            this.btnProductosVendidosPorFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductosVendidosPorFecha.Name = "btnProductosVendidosPorFecha";
            this.btnProductosVendidosPorFecha.Size = new System.Drawing.Size(63, 27);
            this.btnProductosVendidosPorFecha.TabIndex = 43;
            this.btnProductosVendidosPorFecha.Text = "Filtrar";
            this.btnProductosVendidosPorFecha.UseVisualStyleBackColor = false;
            this.btnProductosVendidosPorFecha.Click += new System.EventHandler(this.btnProductosVendidosPorFecha_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lblFechaHasta.Location = new System.Drawing.Point(406, 28);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(77, 15);
            this.lblFechaHasta.TabIndex = 18;
            this.lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Checked = false;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(493, 26);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(246, 19);
            this.dtpFechaHasta.TabIndex = 17;
            this.dtpFechaHasta.Value = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.White;
            this.lblFechaDesde.Location = new System.Drawing.Point(57, 28);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(81, 15);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(143, 28);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(246, 19);
            this.dtpFechaDesde.TabIndex = 15;
            this.dtpFechaDesde.Value = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
            // 
            // dgwProductosVendidos
            // 
            this.dgwProductosVendidos.AllowUserToAddRows = false;
            this.dgwProductosVendidos.AllowUserToDeleteRows = false;
            this.dgwProductosVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwProductosVendidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProductosVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgwProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwProductosVendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProductosVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwProductosVendidos.ColumnHeadersHeight = 40;
            this.dgwProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwProductosVendidos.EnableHeadersVisualStyles = false;
            this.dgwProductosVendidos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgwProductosVendidos.Location = new System.Drawing.Point(52, 133);
            this.dgwProductosVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgwProductosVendidos.Name = "dgwProductosVendidos";
            this.dgwProductosVendidos.ReadOnly = true;
            this.dgwProductosVendidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProductosVendidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgwProductosVendidos.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgwProductosVendidos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwProductosVendidos.RowTemplate.Height = 24;
            this.dgwProductosVendidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProductosVendidos.Size = new System.Drawing.Size(830, 346);
            this.dgwProductosVendidos.TabIndex = 48;
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
            this.btnCerrar.TabIndex = 45;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTotalProductosVendidos
            // 
            this.lblTotalProductosVendidos.AutoSize = true;
            this.lblTotalProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.lblTotalProductosVendidos.Location = new System.Drawing.Point(416, 507);
            this.lblTotalProductosVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalProductosVendidos.Name = "lblTotalProductosVendidos";
            this.lblTotalProductosVendidos.Size = new System.Drawing.Size(37, 15);
            this.lblTotalProductosVendidos.TabIndex = 55;
            this.lblTotalProductosVendidos.Text = "Total:";
            // 
            // txtTotalProductosVendidos
            // 
            this.txtTotalProductosVendidos.Enabled = false;
            this.txtTotalProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalProductosVendidos.Location = new System.Drawing.Point(460, 504);
            this.txtTotalProductosVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalProductosVendidos.Name = "txtTotalProductosVendidos";
            this.txtTotalProductosVendidos.ReadOnly = true;
            this.txtTotalProductosVendidos.Size = new System.Drawing.Size(23, 23);
            this.txtTotalProductosVendidos.TabIndex = 54;
            this.txtTotalProductosVendidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmListadoProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.pnlGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProductosVendidos";
            this.Text = "Lista de Productos Vendidos";
            this.Load += new System.EventHandler(this.FrmListadoProductosVendidos_Load);
            this.pnlGrilla.ResumeLayout(false);
            this.pnlGrilla.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gboxFiltroCliente.ResumeLayout(false);
            this.gboxFiltroCliente.PerformLayout();
            this.gboxFiltroFecha.ResumeLayout(false);
            this.gboxFiltroFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductosVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgwProductosVendidos;
        private System.Windows.Forms.GroupBox gboxFiltroFecha;
        private System.Windows.Forms.Button btnProductosVendidosPorFecha;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.GroupBox gboxFiltroCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnProductosVendidosPorCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnFiltroProductosVendidos;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Label lblTotalProductosVendidos;
        private System.Windows.Forms.TextBox txtTotalProductosVendidos;
    }
}