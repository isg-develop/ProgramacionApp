/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 31/10/2016
 * Hora: 08:19 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace App.AbstractFactory
{
	partial class FactoryIngredientesForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblValue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::App.Properties.Resource.newYork;
			this.pictureBox1.Location = new System.Drawing.Point(42, 100);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 195);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblValue
			// 
			this.lblValue.Location = new System.Drawing.Point(42, 49);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(302, 23);
			this.lblValue.TabIndex = 1;
			this.lblValue.Text = "label1";
			// 
			// FactoryIngredientesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(390, 326);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FactoryIngredientesForm";
			this.Text = "FactoryIngredientesForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
