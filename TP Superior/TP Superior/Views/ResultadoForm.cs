using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior
{
    public partial class ResultadoForm : Form
    {

        MetodoIterativo Sistema;

        public ResultadoForm(MetodoIterativo sistema) {
            Sistema = sistema;
            InitializeComponent();
            InicializarGrid();
            CargarGrid();
        }

        private void InicializarGrid() {
            dataGridView1.ColumnCount = Sistema.N + 3;
            dataGridView1.Rows.Add(Sistema.Iteraciones + 1);
            dataGridView1.Columns[0].HeaderText = "i";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].DividerWidth = 5;
            int i;
            for (i = 1; i <= Sistema.N; i++)
            {
                dataGridView1.Columns[i].HeaderText = "X" + i;
                dataGridView1.Columns[i].DefaultCellStyle.Format = Sistema.FormatoDecimal;
                dataGridView1.Columns[i].DefaultCellStyle.NullValue = "0";
            }

            dataGridView1.Columns[i-1].DividerWidth = 5;
            string norma = Sistema.CriterioParo == Double.PositiveInfinity ?
                "Norma \u221E" : "Norma " + Sistema.CriterioParo.ToString();
            dataGridView1.Columns[i++].HeaderText = norma;
            dataGridView1.Columns[i].HeaderText = "\u03B5";
        }

        private void CargarGrid() {

            var row = dataGridView1.Rows[0];
            row.Cells[0].Value = 0;
            for (int i = 1; i <= Sistema.N; i++)
                row.Cells[i].Value = Sistema.XInicial[i, 1];

            int it = 1;
            foreach (ResultadoFila f in Sistema.Resultados)
            {
                int i = 0;
                row = dataGridView1.Rows[it]; 
                row.Cells[0].Value = it.ToString();
                for (i = 1; i <= Sistema.N; i++)
                    row.Cells[i].Value = f.Variables[i - 1];
                row.Cells[i++].Value = f.Norma;
                row.Cells[i].Value = "> " + Sistema.CotaError;
                it++;
            }

            int c = row.Cells.Count - 1;
            row.Cells[c].Value = "< " + Sistema.CotaError;
            row.Cells[c].Style.BackColor = Color.LightGreen;

        }
    }
}
