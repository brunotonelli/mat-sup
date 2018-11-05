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
using TP_Superior.Views;

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
            CargarMatrices();
            CargarComboBox();
            labelMetodo.Text = tipo == TipoMetodo.Jacobi ? "Jacobi" : "Gauss-Seidel";
        }

        private void botonResolver_Click(object sender, EventArgs e) {
            Matrix x = matrizX.Transformar(ExtensionForm.TipoMatriz.Vector);
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            
            Sistema.CargarDatos(x, decimales, cotaError);
            CargarCriterio();
            Sistema.Resolver();
            ResultadoForm f = new ResultadoForm(Sistema);
            f.Show();
        }

        private void InicializarVector() {
            matrizX.ColumnCount = Sistema.N;
            for (int i = 0; i < Sistema.N; i++)
                matrizX.Columns[i].Width = 30;
        }

        private void CargarMatrices() {
            matrizT.CargarGrid(Sistema.T, 30);
            matrizC.CargarGrid(Sistema.C, 30);
        }

        private void CargarComboBox() {
            comboBoxCriterio.Items.Add(new ComboBoxItem("Norma 1", 1));
            comboBoxCriterio.Items.Add(new ComboBoxItem("Norma 2", 2));
            comboBoxCriterio.Items.Add(new ComboBoxItem("Norma Infinito", Double.PositiveInfinity));
            comboBoxCriterio.Items.Add(new ComboBoxItem("Otra", 0));
            comboBoxCriterio.SelectedItem = comboBoxCriterio.Items[0];
        }

        private void CargarCriterio() {
            double criterio = (comboBoxCriterio.SelectedItem as ComboBoxItem).Value;
            Sistema.CriterioParo = criterio;
        }

        public void SeleccionarNormaP(double p) {
            var n = new ComboBoxItem("Norma " + p.ToString(), p);
            comboBoxCriterio.Items.Add(n);
            comboBoxCriterio.SelectedItem = n;
        }

        private void comboBoxCriterio_SelectionChangeCommitted(object sender, EventArgs e) {
            double norma = (comboBoxCriterio.SelectedItem as ComboBoxItem).Value;
            if (norma == 0)
                new NormaDialog(this).ShowDialog() ;
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public double Value { get; set; }

        public ComboBoxItem(string text, double norma) {
            Text = text;
            Value = norma;
        }

        public override string ToString() {
            return Text;
        }
    }
}
