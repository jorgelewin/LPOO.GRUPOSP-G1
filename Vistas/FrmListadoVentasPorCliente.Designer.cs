namespace Vistas
{
    partial class FrmListadoVentasPorCliente
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
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.lblTotalVentasPorCliente = new System.Windows.Forms.Label();
            this.txtTotalVentasPorCliente = new System.Windows.Forms.TextBox();
            this.gboxFiltroCliente = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgwVentasPorCliente = new System.Windows.Forms.DataGridView();
            this.pnlGrilla.SuspendLayout();
            this.gboxFiltroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentasPorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.lblTotalVentasPorCliente);
            this.pnlGrilla.Controls.Add(this.txtTotalVentasPorCliente);
            this.pnlGrilla.Controls.Add(this.gboxFiltroCliente);
            this.pnlGrilla.Controls.Add(this.btnCerrar);
            this.pnlGrilla.Controls.Add(this.dgwVentasPorCliente);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(990, 550);
            this.pnlGrilla.TabIndex = 0;
            // 
            // lblTotalVentasPorCliente
            // 
            this.lblTotalVentasPorCliente.AutoSize = true;
            this.lblTotalVentasPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentasPorCliente.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentasPorCliente.Location = new System.Drawing.Point(416, 497);
            this.lblTotalVentasPorCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalVentasPorCliente.Name = "lblTotalVentasPorCliente";
            this.lblTotalVentasPorCliente.Size = new System.Drawing.Size(37, 15);
            this.lblTotalVentasPorCliente.TabIndex = 52;
            this.lblTotalVentasPorCliente.Text = "Total:";
            // 
            // txtTotalVentasPorCliente
            // 
            this.txtTotalVentasPorCliente.Enabled = false;
            this.txtTotalVentasPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalVentasPorCliente.Location = new System.Drawing.Point(460, 494);
            this.txtTotalVentasPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalVentasPorCliente.Name = "txtTotalVentasPorCliente";
            this.txtTotalVentasPorCliente.ReadOnly = true;
            this.txtTotalVentasPorCliente.Size = new System.Drawing.Size(23, 23);
            this.txtTotalVentasPorCliente.TabIndex = 51;
            this.txtTotalVentasPorCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboxFiltroCliente
            // 
            this.gboxFiltroCliente.Controls.Add(this.lblCliente);
            this.gboxFiltroCliente.Controls.Add(this.btnFiltro);
            this.gboxFiltroCliente.Controls.Add(this.cboCliente);
            this.gboxFiltroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFiltroCliente.ForeColor = System.Drawing.Color.White;
            this.gboxFiltroCliente.Location = new System.Drawing.Point(52, 53);
            this.gboxFiltroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFiltroCliente.Name = "gboxFiltroCliente";
            this.gboxFiltroCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFiltroCliente.Size = new System.Drawing.Size(830, 59);
            this.gboxFiltroCliente.TabIndex = 50;
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
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.ForeColor = System.Drawing.Color.White;
            this.btnFiltro.Location = new System.Drawing.Point(747, 19);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(63, 27);
            this.btnFiltro.TabIndex = 42;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
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
            this.btnCerrar.TabIndex = 49;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgwVentasPorCliente
            // 
            this.dgwVentasPorCliente.AllowUserToAddRows = false;
            this.dgwVentasPorCliente.AllowUserToDeleteRows = false;
            this.dgwVentasPorCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwVentasPorCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwVentasPorCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgwVentasPorCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwVentasPorCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVentasPorCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwVentasPorCliente.ColumnHeadersHeight = 40;
            this.dgwVentasPorCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwVentasPorCliente.EnableHeadersVisualStyles = false;
            this.dgwVentasPorCliente.GridColor = System.Drawing.Color.SteelBlue;
            this.dgwVentasPorCliente.Location = new System.Drawing.Point(52, 133);
            this.dgwVentasPorCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgwVentasPorCliente.Name = "dgwVentasPorCliente";
            this.dgwVentasPorCliente.ReadOnly = true;
            this.dgwVentasPorCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVentasPorCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwVentasPorCliente.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgwVentasPorCliente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwVentasPorCliente.RowTemplate.Height = 24;
            this.dgwVentasPorCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVentasPorCliente.Size = new System.Drawing.Size(830, 346);
            this.dgwVentasPorCliente.TabIndex = 48;
            // 
            // FrmListadoVentasPorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.pnlGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVentasPorCliente";
            this.Text = "Listado de Ventas por Cliente";
            this.Load += new System.EventHandler(this.FrmListadoVentasPorCliente_Load);
            this.pnlGrilla.ResumeLayout(false);
            this.pnlGrilla.PerformLayout();
            this.gboxFiltroCliente.ResumeLayout(false);
            this.gboxFiltroCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVentasPorCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.GroupBox gboxFiltroCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgwVentasPorCliente;
        private System.Windows.Forms.Label lblTotalVentasPorCliente;
        private System.Windows.Forms.TextBox txtTotalVentasPorCliente;
    }
}