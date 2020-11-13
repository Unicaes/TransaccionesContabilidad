using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransaccionesContabilidad.View;
using TransaccionesContabilidad.ViewModel;

namespace ProyectoContabilidad.View
{
    public partial class Balance : Form
    {
        private void Balance_Load(object sender, EventArgs e)
        {

        }

        public Balance()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(1109, "INVENTARIO",0,0,0,0);
            this.dataGridView1.Rows.Add(4101,"COMPRAS",0,0,0,0);
            this.dataGridView1.Rows.Add(5101,"VENTAS",0,0,0,0);
            this.dataGridView1.Rows.Add(1112, "IVA CREDITO FISCAL",0,0,0,0);
            this.dataGridView1.Rows.Add(2109, "IVA DEBITO FISCAL",0,0,0,0);
            this.dataGridView1.Rows.Add(11010103, "BANCO",0,0,0,0);
            this.dataGridView1.Rows.Add(11010102, "CAJA CHICA",0,0,0,0);
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double suma1, suma2, suma3, suma4;
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;
            suma4 = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                double deudor, acreedor;
                deudor = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value);
                acreedor = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value);
                suma1 += deudor;
                suma2 += acreedor;
                if (deudor>acreedor)
                {
                    this.dataGridView1.Rows[i].Cells[4].Value = deudor - acreedor;
                    suma3 += (deudor - acreedor);
                    this.dataGridView1.Rows[i].Cells[5].Value = 0;
                }
                else
                {
                    this.dataGridView1.Rows[i].Cells[5].Value = acreedor - deudor;
                    suma4 += (acreedor - deudor);
                    this.dataGridView1.Rows[i].Cells[4].Value = 0;
                }
            }
            this.lblSuma1.Text = suma1.ToString();
            this.lblSuma2.Text = suma2.ToString();
            this.lblSuma3.Text = suma3.ToString();
            this.lblSuma4.Text = suma4.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventarioFinal invFinal = new InventarioFinal();
            invFinal.CalcularInventarioFinal(this.dataGridView1);
            TablaIvaInventario frmTabla = new TablaIvaInventario(invFinal);
            frmTabla.Show();
        }
    }
}
