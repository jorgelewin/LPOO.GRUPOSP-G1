using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using ClasesBase;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            // base.OnPaint(e);
            // ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Capturar posicion y tamaño antes de maximizar el formulario
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlFormularios.Controls.Add(formulario);
                pnlFormularios.Tag = formulario;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsuario>();
            btnUsuarios.BackColor = Color.FromArgb(12, 61, 92);
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCliente>();
            btnClientes.BackColor = Color.FromArgb(12, 61, 92);
        }


        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVenta>();
            btnVentas.BackColor = Color.FromArgb(12, 61, 92);

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmProducto>();
            btnProductos.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmObraSocial>();
            btnObrasSociales.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void closeForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmUsuario"] == null)
            {
                btnUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["FrmCliente"] == null)
            {
                btnClientes.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["FrmVenta"] == null)
            {
                btnVentas.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["FrmProducto"] == null)
            {
                btnProductos.BackColor = Color.FromArgb(4, 41, 68);
            }
            if (Application.OpenForms["FrmObraSocial"] == null)
            {
                btnObrasSociales.BackColor = Color.FromArgb(4, 41, 68);
            }
       
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            load_DatosUsuario();

            if (TrabajarUsuario.sesionUser.Rol_Codigo == 1)
            {
                btnClientes.Enabled = false;

                btnVentas.Enabled = false;

                btnObrasSociales.Enabled = false;
                
            }
            if (TrabajarUsuario.sesionUser.Rol_Codigo == 2)
            {
                btnUsuarios.Enabled = false;

                btnProductos.Enabled = false;

                btnObrasSociales.Enabled = false;
                
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(12, 61, 92);
            DialogResult resultado = MessageBox.Show("Estas seguro que desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                btnLogout.BackColor = Color.FromArgb(4, 41, 68);
            }
        }

        private void load_DatosUsuario()
        {
            var cargo = "";

            lblUsuario.Text = "Usuario: " + TrabajarUsuario.sesionUser.Usu_UserName;

            if (TrabajarUsuario.sesionUser.Rol_Codigo == 1)
            {
                cargo = "Administrador";
            }
            else if (TrabajarUsuario.sesionUser.Rol_Codigo == 2)
            {
                cargo = "Operador";
            }
            else
            {
                cargo = "Auditor";
            }

            lblCargo.Text = "Cargo: " + cargo;
 
        
        }


    
    }
}
