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

        public MetodoIterativo(Matrix a, Matrix b, Matrix vectorInicial, int decimales, double cotaError) {
            A = a;
            B = b;
            X = vectorInicial;
            Decimales = decimales;
            CotaError = cotaError;
            GenerarDLU();
            GenerarTC();
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
            double norma = (X - XAnterior).MaxNorm(); //norma infinito
            return norma <= CotaError;
        }

        public void Iterar() {
            XAnterior = X;
            X = T * XAnterior + C;
        }

    }
}
