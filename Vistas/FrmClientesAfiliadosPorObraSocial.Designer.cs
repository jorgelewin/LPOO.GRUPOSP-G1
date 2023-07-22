namespace Vistas
{
    partial class FrmClientesAfiliadosPorObraSocial
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
            this.lblTotalClientesAfiliadosPorObraSocial = new System.Windows.Forms.Label();
            this.txtTotalClientesAfiliadosPorObraSocial = new System.Windows.Forms.TextBox();
            this.gboxFiltroObraSocial = new System.Windows.Forms.GroupBox();
            this.lblClienteAfiliado = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgwClientesAfiliadosAObraSocial = new System.Windows.Forms.DataGridView();
            this.pnlGrilla.SuspendLayout();
            this.gboxFiltroObraSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientesAfiliadosAObraSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.Controls.Add(this.lblTotalClientesAfiliadosPorObraSocial);
            this.pnlGrilla.Controls.Add(this.txtTotalClientesAfiliadosPorObraSocial);
            this.pnlGrilla.Controls.Add(this.gboxFiltroObraSocial);
            this.pnlGrilla.Controls.Add(this.btnCerrar);
            this.pnlGrilla.Controls.Add(this.dgwClientesAfiliadosAObraSocial);
            this.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrilla.Location = new System.Drawing.Point(0, 0);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(990, 550);
            this.pnlGrilla.TabIndex = 0;
            // 
            // lblTotalClientesAfiliadosPorObraSocial
            // 
            this.lblTotalClientesAfiliadosPorObraSocial.AutoSize = true;
            this.lblTotalClientesAfiliadosPorObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientesAfiliadosPorObraSocial.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientesAfiliadosPorObraSocial.Location = new System.Drawing.Point(416, 497);
            this.lblTotalClientesAfiliadosPorObraSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalClientesAfiliadosPorObraSocial.Name = "lblTotalClientesAfiliadosPorObraSocial";
            this.lblTotalClientesAfiliadosPorObraSocial.Size = new System.Drawing.Size(37, 15);
            this.lblTotalClientesAfiliadosPorObraSocial.TabIndex = 57;
            this.lblTotalClientesAfiliadosPorObraSocial.Text = "Total:";
            // 
            // txtTotalClientesAfiliadosPorObraSocial
            // 
            this.txtTotalClientesAfiliadosPorObraSocial.Enabled = false;
            this.txtTotalClientesAfiliadosPorObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotalClientesAfiliadosPorObraSocial.Location = new System.Drawing.Point(460, 494);
            this.txtTotalClientesAfiliadosPorObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalClientesAfiliadosPorObraSocial.Name = "txtTotalClientesAfiliadosPorObraSocial";
            this.txtTotalClientesAfiliadosPorObraSocial.ReadOnly = true;
            this.txtTotalClientesAfiliadosPorObraSocial.Size = new System.Drawing.Size(23, 23);
            this.txtTotalClientesAfiliadosPorObraSocial.TabIndex = 56;
            this.txtTotalClientesAfiliadosPorObraSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboxFiltroObraSocial
            // 
            this.gboxFiltroObraSocial.Controls.Add(this.lblClienteAfiliado);
            this.gboxFiltroObraSocial.Controls.Add(this.btnFiltro);
            this.gboxFiltroObraSocial.Controls.Add(this.cboObraSocial);
            this.gboxFiltroObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gboxFiltroObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxFiltroObraSocial.ForeColor = System.Drawing.Color.White;
            this.gboxFiltroObraSocial.Location = new System.Drawing.Point(52, 53);
            this.gboxFiltroObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.gboxFiltroObraSocial.Name = "gboxFiltroObraSocial";
            this.gboxFiltroObraSocial.Padding = new System.Windows.Forms.Padding(2);
            this.gboxFiltroObraSocial.Size = new System.Drawing.Size(830, 59);
            this.gboxFiltroObraSocial.TabIndex = 55;
            this.gboxFiltroObraSocial.TabStop = false;
            this.gboxFiltroObraSocial.Text = "Filtrar por: Obra Social";
            // 
            // lblClienteAfiliado
            // 
            this.lblClienteAfiliado.AutoSize = true;
            this.lblClienteAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteAfiliado.ForeColor = System.Drawing.Color.White;
            this.lblClienteAfiliado.Location = new System.Drawing.Point(70, 24);
            this.lblClienteAfiliado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteAfiliado.Name = "lblClienteAfiliado";
            this.lblClienteAfiliado.Size = new System.Drawing.Size(74, 15);
            this.lblClienteAfiliado.TabIndex = 16;
            this.lblClienteAfiliado.Text = "Obra Social:";
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
            // cboObraSocial
            // 
            this.cboObraSocial.BackColor = System.Drawing.Color.White;
            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Location = new System.Drawing.Point(170, 20);
            this.cboObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(561, 25);
            this.cboObraSocial.TabIndex = 40;
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
            // dgwClientesAfiliadosAObraSocial
            // 
            this.dgwClientesAfiliadosAObraSocial.AllowUserToAddRows = false;
            this.dgwClientesAfiliadosAObraSocial.AllowUserToDeleteRows = false;
            this.dgwClientesAfiliadosAObraSocial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwClientesAfiliadosAObraSocial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwClientesAfiliadosAObraSocial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgwClientesAfiliadosAObraSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwClientesAfiliadosAObraSocial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClientesAfiliadosAObraSocial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwClientesAfiliadosAObraSocial.ColumnHeadersHeight = 40;
            this.dgwClientesAfiliadosAObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwClientesAfiliadosAObraSocial.EnableHeadersVisualStyles = false;
            this.dgwClientesAfiliadosAObraSocial.GridColor = System.Drawing.Color.SteelBlue;
            this.dgwClientesAfiliadosAObraSocial.Location = new System.Drawing.Point(52, 133);
            this.dgwClientesAfiliadosAObraSocial.Margin = new System.Windows.Forms.Padding(2);
            this.dgwClientesAfiliadosAObraSocial.Name = "dgwClientesAfiliadosAObraSocial";
            this.dgwClientesAfiliadosAObraSocial.ReadOnly = true;
            this.dgwClientesAfiliadosAObraSocial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClientesAfiliadosAObraSocial.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwClientesAfiliadosAObraSocial.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgwClientesAfiliadosAObraSocial.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwClientesAfiliadosAObraSocial.RowTemplate.Height = 24;
            this.dgwClientesAfiliadosAObraSocial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClientesAfiliadosAObraSocial.Size = new System.Drawing.Size(830, 346);
            this.dgwClientesAfiliadosAObraSocial.TabIndex = 53;
            // 
            // FrmClientesAfiliadosPorObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(990, 550);
            this.Controls.Add(this.pnlGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientesAfiliadosPorObraSocial";
            this.Text = "Listado de Clientes Afiliados Por Obra Social";
            this.Load += new System.EventHandler(this.FrmClientesAfiliadosPorObraSocial_Load);
            this.pnlGrilla.ResumeLayout(false);
            this.pnlGrilla.PerformLayout();
            this.gboxFiltroObraSocial.ResumeLayout(false);
            this.gboxFiltroObraSocial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientesAfiliadosAObraSocial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.Label lblTotalClientesAfiliadosPorObraSocial;
        private System.Windows.Forms.TextBox txtTotalClientesAfiliadosPorObraSocial;
        private System.Windows.Forms.GroupBox gboxFiltroObraSocial;
        private System.Windows.Forms.Label lblClienteAfiliado;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgwClientesAfiliadosAObraSocial;
    }
}