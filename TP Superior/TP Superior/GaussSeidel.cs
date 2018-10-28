using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public class GaussSeidel : MetodoIterativo
    {
        public GaussSeidel(Matrix a, Matrix b, Matrix vectorInicial, int decimales, double cotaError) 
            : base(a, b, vectorInicial, decimales, cotaError) { }
        
        public override void GenerarTC() {
            T = (D - L).Inverse() * U;
            C = (D - L).Inverse() * B;
        }
    }
}
