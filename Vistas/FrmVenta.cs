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
    public partial class FrmVenta : Form
    {
        BindingList<VentaDetalle> list_Carrito = new BindingList<VentaDetalle>();
        private decimal total = 0;

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            combo_Clientes();
            combo_Productos();
            load_Carrito();
        }

        private void combo_Clientes()
        {
            cboCliente.DisplayMember = "nombreCompleto";
            cboCliente.ValueMember = "cli_dni";
            cboCliente.DataSource = TrabajarCliente.list_ComboClientes();
        }

        private void combo_Productos()
        {
            cboProducto.DisplayMember = "producto";
            cboProducto.ValueMember = "prod_codigo";
            cboProducto.DataSource = TrabajarProducto.list_ComboProductos();
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


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProductos_Click_1(object sender, EventArgs e)
        {
            try
            {

                DialogResult resultado = MessageBox.Show("Estas seguro que deseas agregar el producto al carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (resultado == DialogResult.Yes)
                {
                    VentaDetalle oVentaDetalle = new VentaDetalle();
                    oVentaDetalle.Ven_Nro = TrabajarVenta.get_CountIdVentas() + 1;
                    oVentaDetalle.Prod_Codigo = (string)cboProducto.SelectedValue;
                    oVentaDetalle.Det_Precio = TrabajarProducto.traer_Precio((string)cboProducto.SelectedValue);
                    oVentaDetalle.Det_Cantidad = Convert.ToDecimal(txtCantidad.Text);
                    oVentaDetalle.Det_Total = oVentaDetalle.Det_Precio * oVentaDetalle.Det_Cantidad;
                    total += oVentaDetalle.Det_Total;
                    list_Carrito.Add(oVentaDetalle);

                    MessageBox.Show("Producto Agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    load_Carrito();

                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el producto al carrito por: " + ex);
            }
        }

        private void btnTerminarVenta_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult resultado = MessageBox.Show("Estas seguro que deseas agregar el producto al carrito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (resultado == DialogResult.Yes)
                {
                    Venta oVenta = new Venta();
                    oVenta.Ven_Fecha = dtpFechaVenta.Value;
                    oVenta.Cli_DNI = (string)cboCliente.SelectedValue;

                    TrabajarVenta.insert_Venta(oVenta);

                    foreach (var item in list_Carrito)
                    {
                        VentaDetalle oVentaDetalle = new VentaDetalle();
                        oVentaDetalle.Ven_Nro = item.Ven_Nro;
                        oVentaDetalle.Prod_Codigo = item.Prod_Codigo;
                        oVentaDetalle.Det_Precio = item.Det_Precio;
                        oVentaDetalle.Det_Cantidad = item.Det_Cantidad;
                        oVentaDetalle.Det_Total = item.Det_Total;

                        TrabajarVentaDetalle.insert_VentaDetalle(oVentaDetalle);
                        
                    }
                    MessageBox.Show("Venta Realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reset();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la venta por: " + ex);
            }

        }

        public void load_Carrito()
        {
            dgwCarrito.DataSource = null;
            txtTotalVenta.Text = Convert.ToString(total);
            dgwCarrito.DataSource = list_Carrito;
        }

        public void reset()
        {
            list_Carrito = new BindingList<VentaDetalle>();
            total = 0;
            load_Carrito();
            txtCantidad.Clear();
            txtTotalVenta.Clear();
        }

        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmListadoVentas>();
        }


    }
}
