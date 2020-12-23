using System;
using System.Windows.Forms;
using Bunifu;
using BunifuAnimatorNS;

namespace TFG_Clock
{
    public partial class Index : Form
    {

    
        public Index()
        {
            InitializeComponent();
        }
        
        //void Start() | Al iniciar
        private void Index_Load(object sender, EventArgs e)
        {
            //Obteniendo los componentes y seteando todo
            GetComponent();
        }
        
        //Esta funcion se llama al iniciar el programa para setear todo
        private void GetComponent()
        {
            //Getting Component and Setting All
            VoidUpdate.Enabled = true;
            VoidUpdate.Interval = 1000;
        }
        
        


        //Ticks--------------------------------------------------------

        //Ticki Event (Reloj / Timer)
        private void clock_Tick(object sender, EventArgs e)
        {
            //Reloj digital, individual y flexible
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag == "seconds")
                {
                    ctrl.Text = DateTime.Now.ToString("ss");
                }
                if (ctrl.Tag == "minutes")
                {
                    ctrl.Text = DateTime.Now.ToString("mm");
                }
                if (ctrl.Tag == "hours")
                {
                    ctrl.Text = DateTime.Now.ToString("hh");
                }
                if (ctrl.Tag == "AMPM")
                {
                    ctrl.Text = DateTime.Now.ToString("tt");
                }

                secondsGauge.Value = DateTime.Now.Second;
                minutesGauge.Value = DateTime.Now.Minute;
                hoursGauge.Value = DateTime.Now.Hour;

            }
        }
        
        //que parpadeen los separadores
        private void detailTick_Tick(object sender, EventArgs e)
        {
            foreach (Control detailsCtrl in Controls)
            {
                if (detailsCtrl.Tag == "details")
                {
                    if (detailsCtrl.Visible)
                    {
                        detailsCtrl.Visible = false;
                    }
                    else
                    {
                        detailsCtrl.Visible = true;
                    }
                }
            }
        }




        //-------------------------------------------------Codigo "Botones"

        //                  boton de minimizar
        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //                  boton Salir
        private void exitButton_Click(object sender, EventArgs e)
        {
            //preguntando si quiere salir
            DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Está saliendo de la app!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }
}
