using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public class ResultadoFila
    {
        public double[] Variables;
        public double Norma1;
        public double Norma2;
        public double NormaInfinito;

        private int N;

        public ResultadoFila(Matrix x, Matrix diferencia) {
            N = x.RowCount;
            Variables = new double[N];
            Norma1 = diferencia.PNorm(1);
            Norma2 = diferencia.Norm();
            NormaInfinito = diferencia.MaxNorm();
            CargarVariables(x);
        }

        private void CargarVariables(Matrix x) {
            for (int i = 0; i < N; i++)
                Variables[i] = x[i + 1, 1].Re;
        }
    }
}
