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
    public partial class FrmClientesAfiliadosPorObraSocial : Form
    {
        public FrmClientesAfiliadosPorObraSocial()
        {
            InitializeComponent();
        }

        private void FrmClientesAfiliadosPorObraSocial_Load(object sender, EventArgs e)
        {
            combo_ObrasSociales();
        }


        private void combo_ObrasSociales()
        {
            cboObraSocial.DisplayMember = "os_razonsocial";
            cboObraSocial.ValueMember = "os_cuit";
            cboObraSocial.DataSource = TrabajarObraSocial.list_ObraSocial();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgwClientesAfiliadosAObraSocial.DataSource = TrabajarCliente.list_ClientesAfiliadosAObraSocial((string)cboObraSocial.SelectedValue);
            dgwClientesAfiliadosAObraSocial.Columns[2].Visible = false;
            txtTotalClientesAfiliadosPorObraSocial.Text = Convert.ToString(TrabajarCliente.get_TotalClientesAfiliadosAObraSocial((string)cboObraSocial.SelectedValue));
        }
    }
}
