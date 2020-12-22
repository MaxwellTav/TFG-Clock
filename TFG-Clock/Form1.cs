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
            clockText.Text = DateTime.Now.ToString("T");
        }

        //Al iniciar
        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Está saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
