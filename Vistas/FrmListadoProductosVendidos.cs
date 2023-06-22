using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmListadoProductosVendidos : Form
    {
        public FrmListadoProductosVendidos()
        {
            InitializeComponent();
        }

        private void FrmListadoProductosVendidos_Load(object sender, EventArgs e)
        {
            gboxFiltroCliente.Visible = false;
            gboxFiltroFecha.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_Clientes()
        {
            cboCliente.DisplayMember = "nombreCompleto";
            cboCliente.ValueMember = "cli_dni";
            cboCliente.DataSource = TrabajarCliente.list_ComboClientes();
        }

        private void btnFiltroProductosVendidos_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked == true)
            {
                gbFiltros.Visible = false;
                btnFiltroProductosVendidos.Visible = false;
                gboxFiltroCliente.Visible = true;
                combo_Clientes();
                
            }
            if (rbFecha.Checked == true)
            {
                gbFiltros.Visible = false;
                btnFiltroProductosVendidos.Visible = false;
                gboxFiltroFecha.Visible = true;
                
            }
        }

        private void btnProductosVendidosPorCliente_Click(object sender, EventArgs e)
        {
            dgwProductosVendidos.DataSource = TrabajarProducto.list_ProductosVendidosPorCliente((string)cboCliente.SelectedValue);
            dgwProductosVendidos.Columns[4].Visible = false;
            dgwProductosVendidos.Columns[5].Visible = false;

        }

        private void btnProductosVendidosPorFecha_Click(object sender, EventArgs e)
        {
            dgwProductosVendidos.DataSource = TrabajarProducto.list_ProductosVendidosPorRangoDeFechas(dtpFechaDesde.Value, dtpFechaHasta.Value);
            dgwProductosVendidos.Columns[4].Visible = false;
            dgwProductosVendidos.Columns[5].Visible = false;
        }

    }
}
