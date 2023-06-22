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
    public partial class FrmUsuario : Form
    {
        private string idUser = null;
        private bool edit = false;
        public FrmUsuario()
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
                        Usuario oUsuario = new Usuario();
                        oUsuario.Usu_UserName = txtUsuario.Text;
                        oUsuario.Usu_Password = txtContraseña.Text;
                        oUsuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
                        oUsuario.Rol_Codigo = (int)cboRol.SelectedValue;

                        TrabajarUsuario.insert_Usuario(oUsuario);

                        MessageBox.Show("Datos Guardados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        reset();

                        load_Usuarios();
                        
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
                        Usuario oUsuario = new Usuario();
                        oUsuario.Usu_Id = Convert.ToInt32(idUser);
                        oUsuario.Usu_UserName = txtUsuario.Text;
                        oUsuario.Usu_Password = txtContraseña.Text;
                        oUsuario.Usu_ApellidoNombre = txtApellidoNombre.Text;
                        oUsuario.Rol_Codigo = (int)cboRol.SelectedValue;

                        TrabajarUsuario.update_Usuario(oUsuario);

                        MessageBox.Show("Datos modificados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        edit = false;

                        reset();

                        load_Usuarios();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron modificar los datos por: " + ex);
                    
                }
                
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            combo_Roles();
            load_Usuarios();
        }

        private void combo_Roles()
        {
            cboRol.DisplayMember = "rol_descripcion";
            cboRol.ValueMember = "rol_codigo";
            cboRol.DataSource = TrabajarUsuario.list_Roles();
        
        }

        private void load_Usuarios()
        {
            dgwUsuarios.DataSource = TrabajarUsuario.list_Usuarios();
           // this.dgwUsuarios.Columns["Priority"].SortMode = DataGridViewColumnSortMode.Automatic;
        
        }

        private void reset()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtApellidoNombre.Clear();
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.search_Usuarios(txtPattern.Text);
            }
            else
            {
                load_Usuarios();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgwUsuarios.SelectedRows.Count > 0)
            {
                idUser = dgwUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtApellidoNombre.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();

                string cons = dgwUsuarios.CurrentRow.Cells["Rol"].Value.ToString(); //Traigo el valor en String del Rol
                switch (cons)
                {
                      case "Administrador":
                        cboRol.SelectedValue = 1;
                        break;
                    case "Operador":
                        cboRol.SelectedValue = 2;
                        break;
                    case "Auditor":
                        cboRol.SelectedValue = 3;
                        break;
                }
                edit = true;

            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgwUsuarios.SelectedRows.Count > 0)
            {
                DialogResult resultadoEliminar = MessageBox.Show("Estas seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultadoEliminar == DialogResult.Yes)
                {
                    idUser = dgwUsuarios.CurrentRow.Cells["Id"].Value.ToString();
                    TrabajarUsuario.delete_Usuario(Convert.ToInt32(idUser));
                    MessageBox.Show("Registro eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Usuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }
        }

    }
}
