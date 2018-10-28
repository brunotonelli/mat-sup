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
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            matrizA.Inicializar();
            matrizB.Inicializar();
            matrizX.Inicializar();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (matrizA.ColumnCount <= 10)
            {
                matrizA.AgregarCeldas(ExtensionForm.TipoMatriz.Cuadrada);
                matrizB.AgregarCeldas(ExtensionForm.TipoMatriz.Columna);
                matrizX.AgregarCeldas(ExtensionForm.TipoMatriz.Vector);
            }
            else
            {
                string message = "No se permiten más de 10";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            
        }

        private void button5_Click(object sender, EventArgs e) {
            int i = matrizA.ColumnCount-- - 1;
            matrizA.Rows.RemoveAt(i);
            matrizB.Rows.RemoveAt(i);
            matrizX.Columns.RemoveAt(i);
        }

        private void button4_Click(object sender, EventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            ValidarMatriz(a);
            Matrix b = matrizB.Transformar(ExtensionForm.TipoMatriz.Columna);
            Matrix x = matrizX.Transformar(ExtensionForm.TipoMatriz.Vector);
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            Jacobi j = new Jacobi(a, b, x, decimales, cotaError);
            j.Resolver();
            string resultado = j.X.ToString();
            label3.Text = resultado;
            label6.Text = j.Iteraciones + " iteraciones";
        }

        private void button3_Click(object sender, EventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            ValidarMatriz(a);
            Matrix b = matrizB.Transformar(ExtensionForm.TipoMatriz.Columna);
            Matrix x = matrizX.Transformar(ExtensionForm.TipoMatriz.Vector);
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            GaussSeidel g = new GaussSeidel(a, b, x, decimales, cotaError);
            g.Resolver();
            string resultado = g.X.ToString();
            label3.Text = resultado;
            label6.Text = g.Iteraciones + " iteraciones";
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            if (a.DiagonalmenteDominante())
            {                
                dominanteLabel.ForeColor = Color.ForestGreen;
                dominanteLabel.Text = "Diagonalmente dominante";
            }
            else
            {
                dominanteLabel.ForeColor = Color.Red;
                dominanteLabel.Text = "No diagonalmente dominante";
            }
        }

        private void ValidarMatriz(Matrix a) {
            if (!a.Invertible())
            {
                throw new Exception("La matriz A no es invertible");
            }
        }
    }
}
