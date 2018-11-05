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
        public double Norma;

        private int N;

        public ResultadoFila(Matrix x, Matrix diferencia, double p) {
            N = x.RowCount;
            Variables = new double[N];
            Norma = diferencia.PNorm(p);
            CargarVariables(x);
        }

        private void CargarVariables(Matrix x) {
            for (int i = 0; i < N; i++)
                Variables[i] = x[i + 1, 1].Re;
        }
    }
}
