using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior.Views
{
    public partial class NormaDialog : Form
    {
        MetodoForm Form;

        public NormaDialog(MetodoForm form) {
            InitializeComponent();
            Form = form;
        }

        private void botonSeleccionar_Click(object sender, EventArgs e) {
            double p = Double.Parse(textBoxNorma.Text);
            Form.SeleccionarNormaP(p);
            this.Hide();
        }
    }
}
