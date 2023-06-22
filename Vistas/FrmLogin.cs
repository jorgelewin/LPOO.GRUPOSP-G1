using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Runtime.InteropServices;

namespace Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //Funcion para poder mover el form de login en la pantalla.
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            { 
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;

            }
        }



        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
            if (txtUsuario.Text != "USUARIO")
            {
                lblErrorMensaje1.Visible = false;

                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    lblErrorMensaje2.Visible = false;
                    var validar = TrabajarUsuario.validate_Usuario(txtUsuario.Text, txtContraseña.Text);
                      if (validar)
                    {
                        
                        this.Hide();
                        FrmBienvenida oFrmBienvenida = new FrmBienvenida();
                        oFrmBienvenida.ShowDialog();
                        FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                        oFrmPrincipal.Show();
                        oFrmPrincipal.FormClosed += logout;
                    }
                    else
                    {
                        msgError(2, "Usuario y/o Contraseña incorrectos.\n Vuelva a intentarlo.");

                        txtContraseña.Text = "CONTRASEÑA";
                        txtContraseña.ForeColor = Color.DimGray;
                        txtContraseña.UseSystemPasswordChar = false;
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    msgError(2, "Por favor, ingrese su contraseña");
                }
            }
            else
            {
                msgError(1, "Por favor, ingrese su nombre de usuario");
            }
         
        }


        private void msgError(int lbl, string msg)
        {
            if (lbl == 1)
            {
                lblErrorMensaje1.Text = "       " + msg;
                lblErrorMensaje1.Visible = true;
            }
            else
            {
                lblErrorMensaje2.Text = "       " + msg;
                lblErrorMensaje2.Visible = true;
            }
        
        }


        private void logout(object sender, FormClosedEventArgs e)
        {

            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblErrorMensaje1.Visible = false;
            lblErrorMensaje2.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }


 

    



    }
}
