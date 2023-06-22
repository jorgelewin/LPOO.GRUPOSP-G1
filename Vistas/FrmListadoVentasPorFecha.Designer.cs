namespace Vistas
{
    partial class FrmListadoVentasPorFecha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gboxFiltroFecha = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgwVentasPorFecha = new System.Windows.Forms.DataGridView();
            this.pnlGrilla.SuspendLayout();
            this.gboxFiltroFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentasPorFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.gboxFiltroFecha);
            this.pnlGrilla.Controls.Add(this.btnCerrar);
            this.pnlGrilla.Controls.Add(this.dgwVentasPorFecha);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(990, 550);
            this.pnlGrilla.TabIndex = 0;
            // 
            // gboxFiltroFecha
            // 
            this.gboxFiltroFecha.Controls.Add(this.btnFiltro);
            this.gboxFiltroFecha.Controls.Add(this.lblFechaHasta);
            this.gboxFiltroFecha.Controls.Add(this.dtpFechaHasta);
            this.gboxFiltroFecha.Controls.Add(this.lblFechaDesde);
            this.gboxFiltroFecha.Controls.Add(this.dtpFechaDesde);
            this.gboxFiltroFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFiltroFecha.ForeColor = System.Drawing.Color.White;
            this.gboxFiltroFecha.Location = new System.Drawing.Point(52, 53);
            this.gboxFiltroFecha.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFiltroFecha.Name = "gboxFiltroFecha";
            this.gboxFiltroFecha.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFiltroFecha.Size = new System.Drawing.Size(830, 59);
            this.gboxFiltroFecha.TabIndex = 49;
            this.gboxFiltroFecha.TabStop = false;
            this.gboxFiltroFecha.Text = "Filtrar por: Fecha";
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(753, 19);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(63, 27);
            this.btnFiltro.TabIndex = 43;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
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
            this.dtpFechaDesde.CloseUp += new System.EventHandler(this.dtpFechaDesde_CloseUp);
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
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgwVentasPorFecha
            // 
            this.dgwVentasPorFecha.AllowUserToAddRows = false;
            this.dgwVentasPorFecha.AllowUserToDeleteRows = false;
            this.dgwVentasPorFecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwVentasPorFecha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwVentasPorFecha.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgwVentasPorFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVentasPorFecha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVentasPorFecha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwVentasPorFecha.ColumnHeadersHeight = 40;
            this.dgwVentasPorFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwVentasPorFecha.EnableHeadersVisualStyles = false;
            this.dgwVentasPorFecha.GridColor = System.Drawing.Color.SteelBlue;
            this.dgwVentasPorFecha.Location = new System.Drawing.Point(52, 133);
            this.dgwVentasPorFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dgwVentasPorFecha.Name = "dgwVentasPorFecha";
            this.dgwVentasPorFecha.ReadOnly = true;
            this.dgwVentasPorFecha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVentasPorFecha.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwVentasPorFecha.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgwVentasPorFecha.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwVentasPorFecha.RowTemplate.Height = 24;
            this.dgwVentasPorFecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVentasPorFecha.Size = new System.Drawing.Size(830, 340);
            this.dgwVentasPorFecha.TabIndex = 47;
            // 
            // FrmListadoVentasPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.pnlGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVentasPorFecha";
            this.Text = "Listado de Ventas por Fecha";
            this.pnlGrilla.ResumeLayout(false);
            this.gboxFiltroFecha.ResumeLayout(false);
            this.gboxFiltroFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentasPorFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.GroupBox gboxFiltroFecha;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgwVentasPorFecha;
    }
}