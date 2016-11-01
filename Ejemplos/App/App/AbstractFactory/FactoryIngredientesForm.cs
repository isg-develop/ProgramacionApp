using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.AbstractFactory
{
	/// <summary>
	/// Description of FactoryIngredientesForm.
	/// </summary>
	public partial class FactoryIngredientesForm : Form
	{
		public FactoryIngredientesForm()
		{
			//Init
			InitializeComponent();
			
			//Factory
			Pizza food = crearPizza();
			lblValue.Text = "" + food.entregar();
		}
		
		private Pizza crearPizza() {
		    FactoriaIngredientes fi = new IngredientesNewYork();
		    Pizza pizza = new Pizza(fi); // Uso de la factoría
		    pizza.cortar();
		    pizza.empaquetar();
		    return pizza;
		}

	}
}
