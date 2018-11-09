using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public class MetodoIterativo
    {
        public Matrix A; //matriz de coeficientes
        public Matrix B; //matriz de terminos independientes

        public Matrix T;
        public Matrix C;

        public Matrix D;
        public Matrix L;
        public Matrix U;

        public Matrix XInicial;
        public Matrix XAnterior;
        public Matrix X;

        public int N;
        public int Decimales;
        public double CotaError;
        public int Iteraciones = 0;
        public string FormatoDecimal;
        public double CriterioParo;

        public List<ResultadoFila> Resultados = new List<ResultadoFila>();

        public MetodoIterativo(Matrix a, Matrix b) {
            A = a;
            N = a.ColumnCount;
            B = b;
            XAnterior = Vacia();
            GenerarDLU();
        }

        public void CargarDatos(Matrix vectorInicial, int decimales, double cotaError) {
            XInicial = vectorInicial;
            X = vectorInicial;
            Decimales = decimales;
            CotaError = cotaError;
            FormatoDecimal = "N" + Decimales;
        }
    
        private Matrix Vacia() {
            int n = A.ColumnCount;
            double[] vector = new double[n];
            return new Matrix(vector);
        }

        private void GenerarDLU() {
            D = A.Diagonal();
            L = A.TrianguloInferior().Negativa();
            U = A.TrianguloSuperior().Negativa();
        }

        public virtual void GenerarTC() { }
        
        public void Resolver() {
            Resultados = new List<ResultadoFila>();
            while (!Parar())
                Iterar();
        }

        private bool Parar() {
            Matrix aux = X.Clone() - XAnterior.Clone();
            double norma = aux.PNorm(CriterioParo);
            return norma < CotaError && norma != 0;
        }

        public void Iterar() {
            XAnterior = X;
            X = T * XAnterior + C;
            Iteraciones++;
            Matrix diferencia = X.Clone() - XAnterior.Clone();
            Resultados.Add(new ResultadoFila(X, diferencia, CriterioParo));
        }

    }
}
