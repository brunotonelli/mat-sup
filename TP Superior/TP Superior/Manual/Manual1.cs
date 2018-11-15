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
    public partial class Manual1 : Form
    {
        public Manual1() {
            InitializeComponent();
        }

        private void botonSiguiente_Click(object sender, EventArgs e) {
            Manuales.Instancia.MostrarManual(2);
        }

        private void Manual1_FormClosing(object sender, FormClosingEventArgs e) {
            Manuales.Instancia.Volver();
        }
    }
}
