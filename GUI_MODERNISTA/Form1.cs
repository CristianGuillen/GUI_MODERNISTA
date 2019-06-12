using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GUI_MODERNISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reservOpc.Visible=false;
            habitPanel.Visible = false;
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
            reservOpc.Visible = false;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            habitPanel.Visible = false;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            habitPanel.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            habitPanel.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = true;//mostral el panel de Opciones de reservaciones
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = false;
            habitPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = false;
            habitPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            reservOpc.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reservOpc.Visible = false;
            habitPanel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reservOpc.Visible = false;
            habitPanel.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //funcion guardar datos
            string message = "Los datos Han sido Guardados!";
            MessageBox.Show(message);
            habNumTxt.Text = "";
            habTipoTxt.Text = "";
            habMxPersonUD.Value = 1;
            habPisoUD.Value = 1;
            habCamasUD.Value = 1;
            habEstadoTxt.Text = "";
            habPlanTxt.Text = "";
            habPrecioTxt.Text = "";
            habDetallesTxt.Text = "";
            
            
        }
    }
}
