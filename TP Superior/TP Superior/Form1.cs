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
            dataGridView1.ColumnCount = 1;
            dataGridView2.ColumnCount = 1;
            dataGridView3.ColumnCount = 1;
            dataGridView1.Rows.Add(new DataGridViewRow { Height = 30 });
            dataGridView2.Rows.Add(new DataGridViewRow { Height = 30 });
            dataGridView3.Rows.Add(new DataGridViewRow { Height = 30 });
            dataGridView1.Columns[0].Width = 30;
            dataGridView2.Columns[0].Width = 30;
            dataGridView3.Columns[0].Width = 30;
            dataGridView1.Rows[0].Height = 30;
            dataGridView2.Rows[0].Height = 30;
            dataGridView3.Rows[0].Height = 30;

        }

        private void button1_Click(object sender, EventArgs e) {

            if (dataGridView1.ColumnCount <= 10)
            {
                var i = dataGridView1.ColumnCount++;
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Rows.Add(new DataGridViewRow { Height = 30 });
                dataGridView2.Rows.Add(new DataGridViewRow { Height = 30 });
                var k = dataGridView3.ColumnCount++;
                dataGridView3.Columns[k].Width = 30;
            }
            else
            {
                string message = "No se permiten más de 10";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private double[,] generarMatrizCoeficientes() {
            int n = dataGridView1.ColumnCount;
            double[,] matriz = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                var fila = dataGridView1.Rows[i];
                for (int j = 0; j < n; j++)
                {
                    var celda = fila.Cells[j].Value;
                    double valor = 0;
                    if (celda != null)
                        Double.TryParse(celda.ToString(), out valor);
                    matriz[i, j] = valor;
                }
            }
            return matriz;
        }
        
        private double[,] generarMatrizTerminosIndependientes() {
            int n = dataGridView1.ColumnCount;
            double[,] matriz = new double[n, 1];
            for (int i = 0; i < n; i++)
            {
                var fila = dataGridView2.Rows[i];
                var celda = fila.Cells[0].Value;
                double valor = 0;
                if (celda != null)
                    Double.TryParse(celda.ToString(), out valor);
                matriz[i, 0] = valor;
            }
            return matriz;
        }

        private double[] generarVectorInicial() {
            int n = dataGridView1.ColumnCount;
            double[] vector = new double[n];
            var fila = dataGridView3.Rows[0];
            for (int i = 0; i < n; i++)
            {
                var celda = fila.Cells[i].Value;
                double valor = 0;
                if (celda != null)
                    Double.TryParse(celda.ToString(), out valor);
                vector[i] = valor;
            }
            return vector;
        }

        private void button5_Click(object sender, EventArgs e) {
            int i = dataGridView1.ColumnCount-- - 1;
            dataGridView1.Rows.RemoveAt(i);
            dataGridView2.Rows.RemoveAt(i);
        }

        private void button4_Click(object sender, EventArgs e) {
            Matrix a = new Matrix(generarMatrizCoeficientes());
            ValidarMatriz(a);
            Matrix b = new Matrix(generarMatrizTerminosIndependientes());
            Matrix x = new Matrix(generarVectorInicial());
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            Jacobi j = new Jacobi(a, b, x, decimales, cotaError);
            j.Resolver();
            string resultado = j.X.ToString();
            label3.Text = resultado;
            label6.Text = j.Iteraciones + " iteraciones";
        }

        private void button3_Click(object sender, EventArgs e) {
            Matrix a = new Matrix(generarMatrizCoeficientes());
            ValidarMatriz(a);
            Matrix b = new Matrix(generarMatrizTerminosIndependientes());
            Matrix x = new Matrix(generarVectorInicial());
            int decimales = Int32.Parse(decimalesTextBox.Text);
            double cotaError = Double.Parse(cotaErrorTextBox.Text);
            GaussSeidel g = new GaussSeidel(a, b, x, decimales, cotaError);
            g.Resolver();
            string resultado = g.X.ToString();
            label3.Text = resultado;
            label6.Text = g.Iteraciones + " iteraciones";
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            Matrix a = new Matrix(generarMatrizCoeficientes());
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
