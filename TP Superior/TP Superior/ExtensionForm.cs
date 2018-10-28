using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior
{
    public static class ExtensionForm
    {
        public enum TipoMatriz
        {
            Cuadrada,
            Columna,
            Vector
        }

        public static void AgregarCeldas(this DataGridView d, TipoMatriz t) {
            if (t != TipoMatriz.Vector)
                d.Rows.Add(new DataGridViewRow { Height = 30 });
            if (t != TipoMatriz.Columna) {
                var i = d.ColumnCount++;
                d.Columns[i].Width = 30;
            }
        }

        public static void Inicializar(this DataGridView d) {
            d.ColumnCount = 1;
            d.Rows.Add(new DataGridViewRow { Height = 30 });
            d.Columns[0].Width = 30;
        }

        public static Matrix Transformar(this DataGridView d, TipoMatriz t) {
            switch (t)
            {
                case TipoMatriz.Cuadrada:
                    return new Matrix(Matriz(d));
                case TipoMatriz.Columna:
                    return new Matrix(Columna(d));
                case TipoMatriz.Vector:
                    return new Matrix(Vector(d));
                default: return null;
            }
        }

        private static double[,] Matriz(DataGridView d) {
            int n = d.ColumnCount;
            double[,] matriz = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                var fila = d.Rows[i];
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

        private static double[] Vector(DataGridView d) {
            int n = d.ColumnCount;
            double[] vector = new double[n];
            var fila = d.Rows[0];
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

        private static double[] Columna(DataGridView d) {
            int n = d.RowCount;
            double[] columna = new double[n];
            for (int i = 0; i < n; i++)
            {
                var fila = d.Rows[i];
                var celda = fila.Cells[0].Value;
                double valor = 0;
                if (celda != null)
                    Double.TryParse(celda.ToString(), out valor);
                columna[i] = valor;
            }
            return columna;
        }
    }
}
