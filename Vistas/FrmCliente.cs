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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
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
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Os_CUIT = txtCUIT.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    

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
            txtDNI.Clear();
            txtCUIT.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNroCarnet.Clear();
        }
    }
}
