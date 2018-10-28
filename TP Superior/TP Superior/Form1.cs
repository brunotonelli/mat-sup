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
            dataGridView1.Rows.Add(new DataGridViewRow { Height = 30 });
            dataGridView2.Rows.Add(new DataGridViewRow { Height = 30 });
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[0].Width = 30;
            dataGridView2.Columns[0].Width = 30;
            dataGridView1.Rows[0].Height = 30;
            dataGridView2.Rows[0].Height = 30;
        }

        private void button1_Click(object sender, EventArgs e) {

            if (dataGridView1.ColumnCount <= 10)
            {
                var i = dataGridView1.ColumnCount++;
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Rows.Add(new DataGridViewRow { Height = 30 });
                dataGridView2.Rows.Add(new DataGridViewRow { Height = 30 });
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
            Matrix a = new Matrix(generarMatrizCoeficientes());
            Matrix b = new Matrix(generarMatrizTerminosIndependientes());
            double[] iniciales = new double[2] { 1,4 };
            Matrix i = new Matrix(iniciales);
            Jacobi j = new Jacobi(a, b, i, 4, 0.001);
            j.Resolver();
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

        private void button5_Click(object sender, EventArgs e) {
            int i = dataGridView1.ColumnCount-- - 1;
            dataGridView1.Rows.RemoveAt(i);
            dataGridView2.Rows.RemoveAt(i);
        }
    }
}
