using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionesContabilidad.View
{
    public partial class TablaIvaInventario : Form
    {
        public TablaIvaInventario()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(2109, "IVA DEBITO FISCAL", 0, 0);
            this.dataGridView1.Rows.Add(1112, "IVA CREDITO FISCAL", 0, 0);
            this.dataGridView1.Rows.Add(211103, "IVA A PAGAR", 0, 0);
            this.dataGridView1.Rows.Add(0, "AJUSTE DE IVA", 0, 0);
            this.dataGridView1.Rows.Add(4101, "COMPRAS", 0, 0);
            this.dataGridView1.Rows.Add(1109, "INVENTARIO", 0, 0);
            this.dataGridView1.Rows.Add(0, "MERCANCIA DISPONIBLE", 0, 0);
            this.dataGridView1.Rows.Add(1109, "INVENTARIO", 0, 0);
            this.dataGridView1.Rows.Add(4101, "COMPRAS", 0, 0);
            this.dataGridView1.Rows.Add(0, "DETERMINAR COSTO DE VENTA", 0, 0);


            this.dataGridView1.Refresh();
        }
    }
}
