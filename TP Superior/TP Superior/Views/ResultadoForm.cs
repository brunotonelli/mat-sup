using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Superior.Views;

namespace TP_Superior
{
    public partial class ResultadoForm : Form
    {

        MetodoIterativo Sistema;

        MetodoForm MetodoForm;

        public ResultadoForm(MetodoIterativo sistema, MetodoForm metodoForm) {
            Sistema = sistema;
            MetodoForm = metodoForm;
            InitializeComponent();
            InicializarGrid();
            CargarGrid();
            this.MaximizeBox = false;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width);

            this.Width = grid.Width + 36;

        }

        private void InicializarGrid() {
            grid.ColumnCount = Sistema.N + 3;
            grid.Rows.Add(Sistema.Iteraciones + 1);

            var columnaIteracion = grid.Columns[0];
            columnaIteracion.HeaderText = "i";
            columnaIteracion.Width = 30;
            columnaIteracion.DividerWidth = 5;

            int i;
            for (i = 1; i <= Sistema.N; i++)
            {
                var columnaVariable = grid.Columns[i];
                columnaVariable.HeaderText = "X" + i;
                columnaVariable.DefaultCellStyle.Format = Sistema.FormatoDecimal;
                columnaVariable.DefaultCellStyle.NullValue = "0";
            }

            grid.Columns[i-1].DividerWidth = 5;
            string norma = Sistema.CriterioParo == Double.PositiveInfinity ?
                "Norma \u221E" : "Norma " + Sistema.CriterioParo.ToString();
            var columnaNorma = grid.Columns[i++];
            columnaNorma.HeaderText = norma;
            columnaNorma.Resizable = DataGridViewTriState.True;
             
            grid.Columns[i].HeaderText = "\u03B5"; //columna epsilon
            
        }

        private void CargarGrid() {

            var row = grid.Rows[0];
            row.Cells[0].Value = 0;
            for (int i = 1; i <= Sistema.N; i++)
                row.Cells[i].Value = Sistema.XInicial[i, 1];

            int it = 1;
            foreach (ResultadoFila f in Sistema.Resultados)
            {
                int i = 0;
                row = grid.Rows[it]; 
                row.Cells[0].Value = it.ToString();
                for (i = 1; i <= Sistema.N; i++)
                    row.Cells[i].Value = f.Variables[i - 1];
                row.Cells[i++].Value = f.Norma;
                row.Cells[i].Value = "> " + Sistema.CotaError;
                it++;
            }

            int c = row.Cells.Count - 1;
            int j;
            for (j = 1; j <= Sistema.N; j++)
                row.Cells[j].Style.BackColor = Color.LightGreen;
            
            row.Cells[j++].Style.BackColor = Color.LightPink;
            row.Cells[j].Value = "< " + Sistema.CotaError;
            row.Cells[j].Style.BackColor = Color.LightPink;
            
        }

        private void botonVolver_Click(object sender, EventArgs e) {
            this.Close();
            MetodoForm.Show();
        }

        private void botonCambiar_Click(object sender, EventArgs e) {
            this.Hide();
            new SeleccionForm(Sistema, this).Show();
        }

        private void botonFinalizar_Click(object sender, EventArgs e) {
            this.Close();
            new Intro().Show();
        }

        private void ResultadoForm_FormClosed(object sender, FormClosedEventArgs e) {
            MetodoForm.Show();
        }
        
    }
}
