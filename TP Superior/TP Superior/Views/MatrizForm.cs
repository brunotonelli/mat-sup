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
    public partial class MatrizForm : Form
    {
        public MatrizForm() {
            InitializeComponent();
            matrizA.Inicializar();
            matrizB.Inicializar();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (matrizA.ColumnCount <= 10)
            {
                matrizA.AgregarCeldas(ExtensionForm.TipoMatriz.Cuadrada);
                matrizB.AgregarCeldas(ExtensionForm.TipoMatriz.Columna);
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
            if (matrizA.ColumnCount > 1)
            {
                int i = matrizA.ColumnCount-- - 1;
                matrizA.Rows.RemoveAt(i);
                matrizB.Rows.RemoveAt(i);
            }
            else
            {
                string message = "La matriz debe tener al menos una celda";
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
            string message = "";
            if (a.DiagonalmenteDominante())
                message = "La matriz A es diagonalmente dominante para cualquier vector incial, " +
                            "por lo tanto ambos métodos convergen a la solución única A X = B";
            else
                message = "La matriz A no es diagonalmente dominante, pero es posible que converja " +
                    "el sistema de todas formas (Seleccionar un método para verificar)";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, "Convergencia del sistema", buttons);
        }

        private void botonResolver_Click(object sender, EventArgs e) {
            Matrix a = matrizA.Transformar(ExtensionForm.TipoMatriz.Cuadrada);
            Matrix b = matrizB.Transformar(ExtensionForm.TipoMatriz.Columna);
            SeleccionForm f = new SeleccionForm(a, b);
            f.Show();
        }
    }
}
