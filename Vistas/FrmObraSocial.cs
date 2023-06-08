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
    }
}
