using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior.Manual
{
    public partial class Manual3 : Form
    {
        public Manual3() {
            InitializeComponent();
        }

        private void botonSiguiente_Click(object sender, EventArgs e) {
            Manuales.Instancia.MostrarManual(4);
        }

        private void botonAnterior_Click(object sender, EventArgs e) {
            Manuales.Instancia.MostrarManual(2);
        }

        private void Manual3_FormClosing(object sender, FormClosingEventArgs e) {
            Manuales.Instancia.Volver();
        }
    }
}
