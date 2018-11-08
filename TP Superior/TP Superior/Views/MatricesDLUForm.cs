using CSML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior.Views
{
    public partial class MatricesDLUForm : Form
    {
        public MatricesDLUForm(Matrix D, Matrix L, Matrix U) {
            InitializeComponent();
            matrizD.CargarGrid(D, 30);
            matrizL.CargarGrid(L, 30);
            matrizU.CargarGrid(U, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
