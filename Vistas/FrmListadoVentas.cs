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
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void load_Ventas()
        {
            dgwListaVentas.DataSource = TrabajarVenta.list_Ventas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            load_Ventas();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlGrilla.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlGrilla.Controls.Add(formulario);
                pnlGrilla.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(closeForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void closeForms(object sender, FormClosedEventArgs e)
        {
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked == true)
            {
                AbrirFormulario<FrmListadoVentasPorCliente>();
            }
            if (rbFecha.Checked == true)
            {
                AbrirFormulario<FrmListadoVentasPorFecha>();
                
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmListadoProductosVendidos>();
        }
    }
}
