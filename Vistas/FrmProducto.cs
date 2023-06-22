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
    public partial class FrmProducto : Form
    {
        private string idProducto = null;
        private bool edit = false;

        public FrmProducto()
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
                        Producto oProducto = new Producto();
                        oProducto.Prod_Codigo = txtCodigo.Text;
                        oProducto.Prod_Categoria = txtCategoria.Text;
                        oProducto.Prod_Descripcion = txtDescripcion.Text;
                        oProducto.Prod_Precio = Convert.ToDecimal(txtPrecio.Text);


                        TrabajarProducto.insert_Producto(oProducto);

                        MessageBox.Show("Datos Guardados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        reset();

                        load_Productos();
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
                      
                        Producto oProducto = new Producto();
                        oProducto.Prod_Codigo = txtCodigo.Text;
                        oProducto.Prod_Categoria = txtCategoria.Text;
                        oProducto.Prod_Descripcion = txtDescripcion.Text;
                        oProducto.Prod_Precio = Convert.ToDecimal(txtPrecio.Text);

                        TrabajarProducto.update_Producto(oProducto);

                        MessageBox.Show("Datos modificados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        edit = false;

                        reset();

                        load_Productos();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron modificar los datos por: " + ex);
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgwProductos.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dgwProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                txtCategoria.Text = dgwProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = dgwProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgwProductos.CurrentRow.Cells["Precio"].Value.ToString();

                txtCodigo.ReadOnly = true;
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
                if (dgwProductos.SelectedRows.Count > 0)
                {
                    DialogResult resultadoEliminar = MessageBox.Show("Estas seguro que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultadoEliminar == DialogResult.Yes)
                    {
                        idProducto = dgwProductos.CurrentRow.Cells["Codigo"].Value.ToString();

                        TrabajarProducto.delete_Producto_SP(idProducto);

                        MessageBox.Show("Registro eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        load_Productos();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbDescripcion.Checked == true)
            {
                dgwProductos.DataSource = TrabajarProducto.search_ProductosOrdenados(txtPattern.Text, 1);
            }
            if (rbCategoria.Checked == true)
            {
                dgwProductos.DataSource = TrabajarProducto.search_ProductosOrdenados(txtPattern.Text, 2);
            }

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            load_Productos();
        }

        private void load_Productos()
        {
            dgwProductos.DataSource = TrabajarProducto.list_Productos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset()
        {
            txtCodigo.ReadOnly = false;
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        
        }


    }
}
