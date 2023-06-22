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
    public partial class FrmListadoVentasPorCliente : Form
    {
        public FrmListadoVentasPorCliente()
        {
            InitializeComponent();
        }


        private void FrmListadoVentasPorCliente_Load(object sender, EventArgs e)
        {
            combo_Clientes();
        }
        private void combo_Clientes()
        {
            cboCliente.DisplayMember = "nombreCompleto";
            cboCliente.ValueMember = "cli_dni";
            cboCliente.DataSource = TrabajarCliente.list_ComboClientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgwVentasPorCliente.DataSource = TrabajarVenta.list_VentasPorCliente((string)cboCliente.SelectedValue);
        }

   
    }
}
