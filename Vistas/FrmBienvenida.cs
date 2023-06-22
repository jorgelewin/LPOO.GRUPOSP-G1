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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cpbBienvenida.Value += 1;
            cpbBienvenida.Text = cpbBienvenida.Value.ToString();
            if (cpbBienvenida.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
                
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = TrabajarUsuario.sesionUser.Usu_ApellidoNombre;
            this.Opacity = 0.0;
            cpbBienvenida.Value = 0;
            cpbBienvenida.Minimum = 0;
            cpbBienvenida.Maximum = 100;
            timer1.Start();
        }
    }
}
