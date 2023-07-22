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
        private string dniClient = null;
        private bool edit = false;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                
            try
            {

                DialogResult resultado = MessageBox.Show("Estas seguro que deseas guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (resultado == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_DNI = txtDNI.Text;                   
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Os_CUIT = (string)cboObraSocial.SelectedValue;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    TrabajarCliente.insert_Cliente(oCliente);

                    MessageBox.Show("Datos Guardados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reset();

                    load_Clientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos por: " + ex);
            }

            }

            if (edit)
            {
                try
                {
                    DialogResult resultadoModificar = MessageBox.Show("Estas seguro que deseas modificar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultadoModificar == DialogResult.Yes)
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.Cli_DNI = txtDNI.Text;                        
                        oCliente.Cli_Apellido = txtApellido.Text;
                        oCliente.Cli_Nombre = txtNombre.Text;
                        oCliente.Cli_Direccion = txtDireccion.Text;
                        oCliente.Os_CUIT = (string)cboObraSocial.SelectedValue;
                        oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                        TrabajarCliente.update_Cliente(oCliente);

                        MessageBox.Show("Datos modificados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        edit = false;

                        reset();

                        load_Clientes();
  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron modificar los datos por: " + ex);
                }
                
            }

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            combo_ObrasSociales();
            load_Clientes();

        }

        private void combo_ObrasSociales()
        {
            cboObraSocial.DisplayMember = "os_razonsocial";
            cboObraSocial.ValueMember = "os_cuit";
            cboObraSocial.DataSource = TrabajarObraSocial.list_ObraSocial();
 
        }

        private void load_Clientes()
        {
            dgwClientes.DataSource = TrabajarCliente.list_Clientes();
           // this.dgwClientes.Columns["Priority"].SortMode = DataGridViewColumnSortMode.Automatic;
        
        }

        private void reset()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNroCarnet.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPattern.Text != "")
                {
                    dgwClientes.DataSource = TrabajarCliente.search_Clientes(txtPattern.Text);

                }
                else
                {
                    load_Clientes();
                }

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show("No se pudieron buscar los datos por: " + ex);
            }
         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgwClientes.SelectedRows.Count > 0)
            {
                txtDNI.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                cboObraSocial.Text = dgwClientes.CurrentRow.Cells["Obra Social"].Value.ToString();
                txtNroCarnet.Text = dgwClientes.CurrentRow.Cells["Numero de Carnet"].Value.ToString();

                edit = true;
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwClientes.SelectedRows.Count > 0)
                {
                    DialogResult resultadoEliminar = MessageBox.Show("Estas seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultadoEliminar == DialogResult.Yes)
                    {
                        dniClient = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                        TrabajarCliente.delete_Cliente(dniClient);
                        MessageBox.Show("Registro eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Clientes();

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione la fila a eliminar");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo eliminar el registro por: " + ex);
            }
        }

        private void btnBuscarOrdenados_Click(object sender, EventArgs e)
        {
            try
            {
                dgwClientes.DataSource = TrabajarCliente.search_ClientesOrderByApellido_SP(txtPattern.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron ordenar los datos por: " + ex);;
            }
        }







     

      
    }
}
