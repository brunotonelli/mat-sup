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
    public partial class MetodoForm : Form
    {
        public enum TipoMetodo
        {
            Jacobi,
            GaussSeidel
        }
        
        private MetodoIterativo Sistema;

        public MetodoForm(MetodoIterativo sistema, TipoMetodo tipo) {
            InitializeComponent();
            Sistema = sistema;
            matrizX.Inicializar();
            InicializarVector();
        }

        private void botonResolver_Click(object sender, EventArgs e) {
            Matrix x = matrizX.Transformar(ExtensionForm.TipoMatriz.Vector);
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            Sistema.CargarDatos(x, decimales, cotaError);
            Sistema.Resolver();
            ResultadoForm f = new ResultadoForm(Sistema);
            f.Show();
        }

        private void InicializarVector() {
            matrizX.ColumnCount = Sistema.N;
            for (int i = 0; i < Sistema.N; i++)
                matrizX.Columns[i].Width = 30;
        }
    }
}
