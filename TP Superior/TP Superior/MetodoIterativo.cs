using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public abstract class MetodoIterativo
    {
        private Matrix A; //matriz de coeficientes
        protected Matrix B; //matriz de terminos independientes

        protected Matrix D;
        protected Matrix L;
        protected Matrix U;

        protected Matrix T;
        protected Matrix C;

        public Matrix XAnterior;
        public Matrix X;        

        public int Decimales;
        public double CotaError;
        public int Iteraciones = 0;

        public MetodoIterativo(Matrix a, Matrix b, Matrix vectorInicial, int decimales, double cotaError) {
            A = a;
            B = b;
            X = vectorInicial;
            XAnterior = Vacia();
            Decimales = decimales;
            CotaError = cotaError;
            GenerarDLU();
            GenerarTC();
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

        public abstract void GenerarTC();
        
        public void Resolver() {
            while (!Parar())
                Iterar();
        }

        private bool Parar() {
            Matrix aux = X.Clone() - XAnterior.Clone();
            double norma = aux.MaxNorm(); //norma inf
            return norma < CotaError && norma != 0;
        }

        public void Iterar() {
            XAnterior = X;
            X = T * XAnterior + C;
            Iteraciones++;
        }

    }
}
