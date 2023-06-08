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
            Usuario[] aUsuario = instanciarUsuarios();
          
            bool bFindUser = false;

            for (int i = 0; i < aUsuario.Length; i++)
			{
			    if (aUsuario[i].Usu_UserName == txtUsuario.Text && aUsuario[i].Usu_Password == txtContraseña.Text)
                 {
                     bFindUser = true;
                 }
			}

            if (txtUsuario.Text != "USUARIO")
            {
                lblErrorMensaje1.Visible = false;

                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    lblErrorMensaje2.Visible = false;
               
                      if (bFindUser)
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

        private Usuario[] instanciarUsuarios() 
        {
            Usuario[] aUsuario = new Usuario[3];
            Roles oRol1 = new Roles(1,"Administrador");
            Roles oRol2 = new Roles(2, "Operador");
            Roles oRol3 = new Roles(3, "Auditor");
            Usuario oUsu1 = new Usuario("jcarlos","2",2);
            Usuario oUsu2 = new Usuario("sondex", "1", 1);
            Usuario oUsu3 = new Usuario("jtv", "3", 3);
            aUsuario[0] = oUsu1;
            aUsuario[1] = oUsu2;
            aUsuario[2] = oUsu2;

            return aUsuario;
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
