﻿using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public class GaussSeidel : MetodoIterativo
    {
        public GaussSeidel(Matrix a, Matrix b) 
            : base(a, b) {
            GenerarTC();
        }
        
        public override void GenerarTC() {
            T = (D.Clone() - L.Clone()).Inverse() * U;
            C = (D.Clone() - L.Clone()).Inverse() * B;
        }
    }
}
