using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFG_Clock
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        //Ticki Event (Reloj / Timer)
        private void clock_Tick(object sender, EventArgs e)
        {
            hoursText.Text = DateTime.Now.ToString("hh");
            minutesText.Text = DateTime.Now.ToString("mm");
            secondsText.Text = DateTime.Now.ToString("ss");
            AMPM.Text = DateTime.Now.ToString("tt");
        }

        private void detailTick_Tick(object sender, EventArgs e)
        {
            string variante = hoursText.Text;
            //que parpadeen los separadores
            if(detail1.Visible)
            {
                detail1.Visible = false;
            }
            else
            {
                detail1.Visible = true;
            }

            //que parpadeen los separadores
            if (detail2.Visible)
            {
                detail2.Visible = false;
            }
            else
            {
                detail2.Visible = true;
            }
        }

        //Al iniciar
        private void Index_Load(object sender, EventArgs e)
        {
            //Obteniendo los componentes y seteando todo
            GetComponent();
        }

        public void GetComponent()
        {
            //Getting Component and Setting All
            VoidUpdate.Enabled = true;
            VoidUpdate.Interval = 1000;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Está saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //boton de minimizar
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
