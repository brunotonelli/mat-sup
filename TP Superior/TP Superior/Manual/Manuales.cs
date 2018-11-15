using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Superior.Manual
{
    public class Manuales
    {
        public List<Form> Forms = new List<Form>();

        public static Manuales Instancia = new Manuales();

        private Form Mostrando;
        private Form Padre;

        private Manuales() {}

        public void Cargar(Form padre) {
            Padre = padre;
            Forms.Add(new Manual1());
            Forms.Add(new Manual2());
            Forms.Add(new Manual3());
            Forms.Add(new Manual4());
            MostrarManual(1);
        }

        public void MostrarManual(int i) {
            var form = Forms[i - 1];
            form.Show();
            if (Mostrando != null)
                Mostrando.Hide();
            Mostrando = form;
        }

        public void Volver() {
            Padre.Show();
            Forms.ForEach(f => f.Hide());
            Forms.Clear();
        }
    }
}
