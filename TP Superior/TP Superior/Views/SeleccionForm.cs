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

        public SeleccionForm(Matrix a, Matrix b) {
            InitializeComponent();
            A = a;
            B = b;
        }

        private void botonJacobi_Click(object sender, EventArgs e) {
            MetodoForm f = new MetodoForm(new Jacobi(A, B), MetodoForm.TipoMetodo.Jacobi);
            f.Show();
        }

        private void botonGauss_Click(object sender, EventArgs e) {
            MetodoForm f = new MetodoForm(new GaussSeidel(A, B), MetodoForm.TipoMetodo.GaussSeidel);
            f.Show();
        }
    }
}
