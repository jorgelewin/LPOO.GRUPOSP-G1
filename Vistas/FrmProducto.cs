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
        public FrmProducto()
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
                    Producto oProducto = new Producto();
                    oProducto.Prod_Categoria = txtCategoria.Text;
                    oProducto.Prod_Descripcion = txtDescripcion.Text;
                    oProducto.Prod_Precio = Convert.ToDecimal(txtPrecio.Text);

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
            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        
        }
    }
}
