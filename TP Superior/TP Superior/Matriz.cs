﻿using CSML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Superior
{
    public static class Matriz
    {
        public static Matrix Diagonal(this Matrix m) {
            int n = m.ColumnCount;
            Matrix aux = m.Clone();
            for (int i = 1; i <= n; i++) //indice desde 1
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i != j)
                        aux[i, j] = Complex.Zero;
                }
            }
            return aux;
        }
        
        public static bool DiagonalmenteDominante(this Matrix m) {
            int n = m.ColumnCount;
            Matrix aux = m.Clone();
            for (int i = 0; i < n; i++)
            {
                double sumaFila = 0;
                for (int j = 0; j < n; j++)
                    sumaFila += Math.Abs(aux[i, j].Re);
                sumaFila -= Math.Abs(aux[i, i].Re);
                if (Math.Abs(aux[i, i].Re) < sumaFila)
                    return false;
            }
            return true;
        }

        public static Matrix TrianguloInferior(this Matrix m) {
            Matrix aux = m.Clone();
            return aux - aux.ExtractUpperTrapeze();
        }

        public static Matrix TrianguloSuperior(this Matrix m) {
            Matrix aux = m.Clone();
            return aux - aux.ExtractLowerTrapeze();
        }

        public static Matrix Negativa(this Matrix m) {
            return m * -1;
        }
        
    }
}
