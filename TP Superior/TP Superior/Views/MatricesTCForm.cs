﻿using CSML;
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
    public partial class MatricesTCForm : Form
    {
        public MatricesTCForm(Matrix T, Matrix C) {
            InitializeComponent();
            matrizT.CargarGrid(T, 30);
            matrizC.CargarGrid(C, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
