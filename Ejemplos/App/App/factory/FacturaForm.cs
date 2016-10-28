using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.factory
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        	//Crea un Factory method dependiendo a la opción del formulario
            Factura factura= FactoriaFacturas.getFactura(ValidarOpcion());
             factura.Id = 10;
             factura.Importe = 100;
             double result = factura.getImporteIva();
             txtResultado.Text = " " + result;
        }
        
        private TipoIVA ValidarOpcion(){
        	
        	TipoIVA iva = TipoIVA.IVAActual;
        	if (optIVA16.Checked){
        	   iva = TipoIVA.IVAActual;
        	}
        	else if (optIVA5.Checked){
        	  iva = TipoIVA.IVAReducido;
        	}
        	return iva;
        }
    }
}
