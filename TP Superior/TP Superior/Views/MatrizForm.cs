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
    public partial class MatrizForm : Form
    {
        public MatrizForm() {
            InitializeComponent();
            matrizA.Inicializar();
            matrizA.AgregarCeldas(ExtensionForm.TipoMatriz.Cuadrada);
            matrizB.Inicializar();
            matrizB.AgregarCeldas(ExtensionForm.TipoMatriz.Columna);
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e) {

            if (matrizA.ColumnCount <= 10)
            {
                matrizA.AgregarCeldas(ExtensionForm.TipoMatriz.Cuadrada);
                matrizB.AgregarCeldas(ExtensionForm.TipoMatriz.Columna);
            }
            else
            {
                string message = "No se permite N > 10";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            if (matrizA.ColumnCount > 2)
            {
                int i = matrizA.ColumnCount-- - 1;
                matrizA.Rows.RemoveAt(i);
                matrizB.Rows.RemoveAt(i);
            }
            else
            {
                string message = "La matriz debe tener N > 1";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
        }        

        private void ValidarMatriz(Matrix a) {
            if (!a.Invertible())
            {
                throw new Exception("La matriz A no es invertible");
            }
        }

        private void botonValidar_Click(object sender, EventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            Matrix b = matrizB.Transformar(ExtensionForm.TipoMatriz.Columna);
            bool continuar = false;
            string message = "";
            if (!a.DiagonalmenteDominante())
                message = "La matriz A no es diagonalmente dominante, reordene las filas para que lo sea, o ingrese una matriz distinta";
            else
            {
                message = "La matriz A es diagonalmente dominante para cualquier vector incial.";
                continuar = true;
            }
            if (b.Nula())
            {
                message += "\n\nLa matriz B no puede ser nula. Dará resultado vector nulo.";
                continuar = false;
            }

            if (continuar)
                message += "\n\nEl sistema tiene solución.";

            botonResolver.Enabled = continuar;

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, "Convergencia del sistema", buttons);
        }

        private void botonResolver_Click(object sender, EventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            Matrix b = matrizB.Transformar(ExtensionForm.TipoMatriz.Columna);
            SeleccionForm f = new SeleccionForm(a, b, this);
            this.Hide();
            f.Show();
        }

        private void botonNorma1_Click(object sender, EventArgs e) {
            MostrarNorma(1);
        }

        private void botonNorma2_Click(object sender, EventArgs e) {
            MostrarNorma(2);
        }

        private void botonNormaInf_Click(object sender, EventArgs e) {
            MostrarNorma(Double.PositiveInfinity);
        }

        private void MostrarNorma(double p) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            var norma = p == 2 ? a.Norma2() : a.PNorm(p);
            MessageBox.Show("Norma "+p+" de la matriz A: " + norma.ToString(), "Norma de A", buttons);
        }

        private void matrizA_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            botonResolver.Enabled = false;
        }

        private void MatrizForm_FormClosed(object sender, FormClosedEventArgs e) {
            new Intro().Show();
        }
    }
}
