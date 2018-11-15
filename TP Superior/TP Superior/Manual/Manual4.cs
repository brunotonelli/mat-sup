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
    public partial class Manual4 : Form
    {
        public Manual4() {
            InitializeComponent();
        }

        private void botonAnterior_Click(object sender, EventArgs e) {
            Manuales.Instancia.MostrarManual(3);
        }

        private void Manual4_FormClosing(object sender, FormClosingEventArgs e) {
            Manuales.Instancia.Volver();
        }
    }
}
