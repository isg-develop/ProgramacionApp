/*
 * Creado por SharpDevelop.
 * Usuario: elite
 * Fecha: 28/10/2016
 * Hora: 11:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace App.Singleton
{
	partial class SingletonForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnValidar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnValidar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(118, 53);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// btnValidar
			// 
			this.btnValidar.Location = new System.Drawing.Point(282, 51);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(75, 23);
			this.btnValidar.TabIndex = 2;
			this.btnValidar.Text = "Validar";
			this.btnValidar.UseVisualStyleBackColor = true;
			this.btnValidar.Click += new System.EventHandler(this.BtnValidarClick);
			// 
			// SingletonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 124);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Name = "SingletonForm";
			this.Text = "SingletonForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
