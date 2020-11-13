using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransaccionesContabilidad.ViewModel;

namespace TransaccionesContabilidad.View
{
    public partial class TablaIvaInventario : Form
    {
        AjusteIva ajuste_iva;

        public TablaIvaInventario(InventarioFinal invFinal,iva Iva, costoventa costoVenta)
        {
            InitializeComponent();
            //ajuste_iva = new AjusteIva();
            //ajuste_iva.SaldoIvaDebitoFiscal = 8320;
            //ajuste_iva.SaldoIvaCreditoFiscal = 16900;
            //ajuste_iva.getIvaAPagar();

            //this.dataGridView1.Rows.Clear();
            //this.dataGridView1.Rows.Add
            //    (2109, "IVA DEBITO FISCAL", "$ " + ajuste_iva.SaldoIvaDebitoFiscal, "");
            //this.dataGridView1.Rows.Add
            //    (1112, "IVA CREDITO FISCAL", "", "$ " + ajuste_iva.SaldoIvaCreditoFiscal);
            //this.dataGridView1.Rows.Add
            //    (211103, "IVA A PAGAR", "$ " + ajuste_iva.IvaAPagarDebe, "$ " + ajuste_iva.IvaAPagarHaber);
            //this.dataGridView1.Rows.Add
            //    ("", "AJUSTE DE IVA", "$ " + ajuste_iva.ajuste, "$ " + ajuste_iva.ajuste);
            this.dataGridView1.Rows.Add(2109, "IVA DEBITO FISCAL", "$"+0, "$ " + Iva.ivaDebito);
            this.dataGridView1.Rows.Add(2109, "IVA CREDITO FISCAL", "$"+ Iva.ivaCredito,"$"+0 );
            this.dataGridView1.Rows.Add(211103, "IVA A PAGAR",0 , "$ " + Iva.ivaPagar);
            this.dataGridView1.Rows.Add("", "AJUSTE DE IVA", "$ " + Iva.ivaCredito, "$ " + (Iva.ivaDebito + Iva.ivaPagar));
            this.dataGridView1.Rows.Add(4101, "COMPRAS", 0, 0);
            this.dataGridView1.Rows.Add(1109, "INVENTARIO", 0, 0);
            this.dataGridView1.Rows.Add(0, "MERCANCIA DISPONIBLE", 0, invFinal.GetInventarioFinal());
            this.dataGridView1.Rows.Add(1109, "INVENTARIO", costoVenta.inventario, 0) ;
            this.dataGridView1.Rows.Add(4101, "COMPRAS", 0, costoVenta.compra);
            this.dataGridView1.Rows.Add(0, "DETERMINAR COSTO DE VENTA", costoVenta.CalculoComprVenta(), costoVenta.CalculoComprVenta());
            this.dataGridView1.Refresh();
        }
    }
}
