using CSML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior
{
    public partial class SeleccionForm : Form
    {
        private Matrix A;
        private Matrix B;

        private Form Padre;

        public SeleccionForm(Matrix a, Matrix b, Form padre) {
            InitializeComponent();
            A = a;
            B = b;
            Padre = padre;
            this.MaximizeBox = false;
        }

        public SeleccionForm(MetodoIterativo sistema, Form padre) : this(sistema.A, sistema.B, padre) {
            
        }

        private void botonJacobi_Click(object sender, EventArgs e) {
            MetodoForm f = new MetodoForm(new Jacobi(A, B), MetodoForm.TipoMetodo.Jacobi, this);
            this.Hide();
            f.Show();
        }

        private void botonGauss_Click(object sender, EventArgs e) {
            MetodoForm f = new MetodoForm(new GaussSeidel(A, B), MetodoForm.TipoMetodo.GaussSeidel, this);
            this.Hide();
            f.Show();
        }

        private void SeleccionForm_FormClosed(object sender, FormClosedEventArgs e) {
            Padre.Show();
        }
    }
}
