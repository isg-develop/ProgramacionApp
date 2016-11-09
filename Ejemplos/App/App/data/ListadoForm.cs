
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace App.data
{
	/// <summary>
	/// Description of ListadoForm.
	/// </summary>
	public partial class ListadoForm : Form
	{
		public ListadoForm()
		{
			
			InitializeComponent();
			
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			// DataSet datos =   App.data.TestConnection_MySQL.GetListado();
			// dataGridView1.DataSource = datos.Tables[0];
			ListadoControlador control = new ListadoControladorMySQL();
			dataGridView1.DataSource = control.GetTodos();
			
		}
	}
}
