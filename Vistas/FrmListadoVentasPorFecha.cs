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
    public partial class FrmListadoVentasPorFecha : Form
    {
        public FrmListadoVentasPorFecha()
        {
            InitializeComponent();
        }

        private void dtpFechaDesde_CloseUp(object sender, EventArgs e)
        {
            dtpFechaHasta.MinDate = dtpFechaDesde.Value;
            dtpFechaHasta.Value = dtpFechaDesde.Value.AddDays(1);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgwVentasPorFecha.DataSource = TrabajarVenta.list_VentasPorRangoDeFechas(dtpFechaDesde.Value, dtpFechaHasta.Value);
        }
    }
}
