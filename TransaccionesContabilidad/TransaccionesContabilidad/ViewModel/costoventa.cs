using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionesContabilidad.ViewModel
{
    public class costoventa
    {
        public double compra, inventario, costoVenta, inventarioFinal, inventarioInicial, venta;
        public void BuscarCompraInventario(DataGridView tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[0].Value.Equals(1109))
                {
                    inventarioInicial = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(4101))
                {
                    compra = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(5101))
                {
                    venta = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(1109))
                {
                    inventario = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
            }
            inventarioFinal = inventarioInicial + compra - venta;
            costoVenta = inventarioInicial + compra - inventarioFinal;
            
        }

        public double CalculoComprVenta()
        {
            return costoVenta;

        }
    }
}
