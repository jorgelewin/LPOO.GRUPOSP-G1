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
    public partial class FrmObraSocial : Form
    {
        public FrmObraSocial()
        {
            InitializeComponent();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult resultado = MessageBox.Show("Estas seguro que deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (resultado == DialogResult.Yes)
                {
                    ObraSocial oObraSocial = new ObraSocial();
                    oObraSocial.Os_CUIT = txtCUIT.Text;
                    oObraSocial.Os_RazonSocial = txtRazonSocial.Text;
                    oObraSocial.Os_Direccion = txtDireccion.Text;
                    oObraSocial.Os_Telefono = txtTelefono.Text;
          

                    MessageBox.Show("Datos Guardados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos por: " + ex);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void reset()
        {
            txtCUIT.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }


        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmClientesAfiliadosPorObraSocial>();
        }

    }
}
