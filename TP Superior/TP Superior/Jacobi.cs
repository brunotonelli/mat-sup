using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public class Jacobi : MetodoIterativo {

        public Jacobi(Matrix a, Matrix b) 
            : base(a, b) {
            GenerarTC();
        }
        
        public override void GenerarTC() {
            T = D.Inverse() * (L.Clone() + U.Clone());
            C = D.Inverse() * B.Clone();
        }
    }
}
