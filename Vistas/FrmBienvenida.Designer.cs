namespace Vistas
{
    partial class FrmBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTituloBienvenida = new System.Windows.Forms.Panel();
            this.lblNombreOptica = new System.Windows.Forms.Label();
            this.pctLogoBienvenida = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cpbBienvenida = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlTituloBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloBienvenida
            // 
            this.pnlTituloBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.pnlTituloBienvenida.Controls.Add(this.lblNombreOptica);
            this.pnlTituloBienvenida.Controls.Add(this.pctLogoBienvenida);
            this.pnlTituloBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloBienvenida.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTituloBienvenida.Name = "pnlTituloBienvenida";
            this.pnlTituloBienvenida.Size = new System.Drawing.Size(750, 81);
            this.pnlTituloBienvenida.TabIndex = 0;
            // 
            // lblNombreOptica
            // 
            this.lblNombreOptica.AutoSize = true;
            this.lblNombreOptica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOptica.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNombreOptica.Location = new System.Drawing.Point(80, 28);
            this.lblNombreOptica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreOptica.Name = "lblNombreOptica";
            this.lblNombreOptica.Size = new System.Drawing.Size(147, 29);
            this.lblNombreOptica.TabIndex = 2;
            this.lblNombreOptica.Text = "Optica A.G.L";
            // 
            // pctLogoBienvenida
            // 
            this.pctLogoBienvenida.Image = global::Vistas.Properties.Resources.examen_de_la_vista;
            this.pctLogoBienvenida.Location = new System.Drawing.Point(0, 10);
            this.pctLogoBienvenida.Margin = new System.Windows.Forms.Padding(2);
            this.pctLogoBienvenida.Name = "pctLogoBienvenida";
            this.pctLogoBienvenida.Size = new System.Drawing.Size(75, 62);
            this.pctLogoBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoBienvenida.TabIndex = 0;
            this.pctLogoBienvenida.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.lblBienvenido.Location = new System.Drawing.Point(259, 98);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(296, 63);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUsuario.Location = new System.Drawing.Point(348, 168);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(96, 29);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // cpbBienvenida
            // 
            this.cpbBienvenida.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbBienvenida.AnimationSpeed = 500;
            this.cpbBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.cpbBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.cpbBienvenida.ForeColor = System.Drawing.Color.Silver;
            this.cpbBienvenida.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.cpbBienvenida.InnerMargin = 2;
            this.cpbBienvenida.InnerWidth = -1;
            this.cpbBienvenida.Location = new System.Drawing.Point(335, 250);
            this.cpbBienvenida.Margin = new System.Windows.Forms.Padding(2);
            this.cpbBienvenida.MarqueeAnimationSpeed = 2000;
            this.cpbBienvenida.Name = "cpbBienvenida";
            this.cpbBienvenida.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.cpbBienvenida.OuterMargin = -25;
            this.cpbBienvenida.OuterWidth = 26;
            this.cpbBienvenida.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.cpbBienvenida.ProgressWidth = 25;
            this.cpbBienvenida.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cpbBienvenida.Size = new System.Drawing.Size(112, 122);
            this.cpbBienvenida.StartAngle = 270;
            this.cpbBienvenida.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbBienvenida.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBienvenida.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbBienvenida.SubscriptText = "";
            this.cpbBienvenida.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBienvenida.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbBienvenida.SuperscriptText = "%";
            this.cpbBienvenida.TabIndex = 7;
            this.cpbBienvenida.Text = "0";
            this.cpbBienvenida.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbBienvenida.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(750, 406);
            this.Controls.Add(this.cpbBienvenida);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pnlTituloBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenida";
            this.Load += new System.EventHandler(this.FrmBienvenida_Load);
            this.pnlTituloBienvenida.ResumeLayout(false);
            this.pnlTituloBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoBienvenida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloBienvenida;
        private System.Windows.Forms.Label lblNombreOptica;
        private System.Windows.Forms.PictureBox pctLogoBienvenida;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUsuario;
        private CircularProgressBar.CircularProgressBar cpbBienvenida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}