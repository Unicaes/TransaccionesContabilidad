using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionesContabilidad.ViewModel
{
    public class InventarioFinal
    {
        double inventarioInicial, compras, ventas, inventarioFinal;
        public void CalcularInventarioFinal(DataGridView tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[0].Value.Equals(1109))
                {
                    inventarioInicial = (double)tabla.Rows[i].Cells[4].Value + (double)tabla.Rows[i].Cells[4].Value;
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(4101))
                {
                    compras = (double)tabla.Rows[i].Cells[4].Value + (double)tabla.Rows[i].Cells[4].Value;
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(5101))
                {
                    ventas = (double)tabla.Rows[i].Cells[4].Value + (double)tabla.Rows[i].Cells[4].Value;
                }
            }
            inventarioFinal = inventarioInicial + compras - ventas;
        }
        public double GetInventarioFinal()
        {
            return inventarioFinal;
        }
    }
}
