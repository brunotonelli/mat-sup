using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Superior.Manual;

namespace TP_Superior.Views
{
    public partial class Intro : Form
    {
        public Intro() {
            InitializeComponent();
        }

        private void botonCodigo_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/brunotonelli/mat-sup/tree/master/TP%20Superior/TP%20Superior");
        }

        //PARA MOVER EL FORM
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void botonIngresar_Click(object sender, EventArgs e) {
            this.Hide();
            new MatrizForm().Show();
        }

        private void botonSalir_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void botonManual_Click(object sender, EventArgs e) {
            Manuales.Instancia.Cargar(this);
            this.Hide();
        }
    }
}
