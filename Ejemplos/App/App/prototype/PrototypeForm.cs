using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.prototype
{
    public partial class PrototypeForm : Form
    {
    	//Objetos globales
    	Vehiculo vehiculo1 = new Vehiculo(); 
    	Vehiculo vehiculoClonado = new Vehiculo();
    		
    		
        public PrototypeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        	//Se crea el objeto principal - con capacidad de ser CLONADO (Prototype)
            vehiculo1 = new Vehiculo()
              {
                Marca = "Peugeot",
                Modelo = "306",
                Color = "Negro"
              };
			
            //Se agrega un objeto Normal
            vehiculo1.TipoCarroceria = new Carroceria()
            {
                Material = "Acero",
                TipoCarroceria = "Sedan"
            };

             //Se agrega un objeto Normal
            vehiculo1.TipoRueda = new Rueda() { Llanta = "Aluminio", Diametro = 17 };
            
            //Imprimir
            Imprimir();

        }
        
        
		void BtnClonarClick(object sender, EventArgs e)
		{
			txtResultado.Text +=("---    Inicia el proceso de clonación    ---" + Environment.NewLine);
			
			//Ahora realizamos una clonación de un objeto y lo depositamos
			// en un segundo objeto            
            vehiculoClonado = vehiculo1.Clone() as Vehiculo;
            vehiculoClonado.isClonado = true;
            //Imprime objeto original 
            //Imprime objeto clonado
            Imprimir( );            
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			if (!vehiculoClonado.isClonado){
				return;
			}
			txtResultado.Text +=("---    Inicia Modificación del objeto clonado    ---" + Environment.NewLine);
			txtResultado.Text +=("---  Recuerda que el objeto con prototype debe ser totalmente diferente al original   ---" + Environment.NewLine);
			//Modificamos el objeto clonado 
			vehiculoClonado.Marca = "Peugeot - Edition limitada";
			vehiculoClonado.Color = "Rojo";
			vehiculoClonado.Modelo = "310-Limited";
			vehiculoClonado.TipoRueda.Diametro = 15;
			vehiculoClonado.TipoRueda.Llanta = "Aleación - GoodYears";
			vehiculoClonado.TipoCarroceria.Material = "Hey!! te modifique...";


			 //Imprime los valores modificado
			 Imprimir( );
			 // Identifica que los valores son diferentes 
			 //  - permite el cambio unicamente con patron prototype
			 //	 - las clases normales no son diferentes
		}
		
		//Imprimir
		void BtnImprimirClick(object sender, EventArgs e)
		{
			 Imprimir( );
		}
		
		private void Imprimir()
        {
        	 //Imprime objeto original
        	
        	
        	
        	txtResultado.Text +=("----------------    Contenido para:    ----------------" + Environment.NewLine); 
            txtResultado.Text +=("---Original: " + vehiculo1.VehiculoInfo() + "---");
            //Imprime objeto clonado
            txtResultado.Text +=("----------------    Contenido para:    ----------------" + Environment.NewLine); 
            txtResultado.Text +=("---Clonado: " + vehiculoClonado.VehiculoInfo() + "---");
        
            
            txtResultado.Text += ""; 
            txtResultado.Text += "Mi nombre es ";
        	txtResultado.Text += "Ismael Sánchez González ";
        	
        	
        }
		void BtnClearClick(object sender, EventArgs e)
		{
			txtResultado.Text = "";
		}
		
		
    }
}
