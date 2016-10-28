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
	partial class NormalForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnValidar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ckActive;
		
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
			this.btnValidar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ckActive = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnValidar
			// 
			this.btnValidar.Location = new System.Drawing.Point(65, 115);
			this.btnValidar.Name = "btnValidar";
			this.btnValidar.Size = new System.Drawing.Size(75, 23);
			this.btnValidar.TabIndex = 5;
			this.btnValidar.Text = "Validar";
			this.btnValidar.UseVisualStyleBackColor = true;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(40, 78);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nombre";
			// 
			// ckActive
			// 
			this.ckActive.Location = new System.Drawing.Point(233, 76);
			this.ckActive.Name = "ckActive";
			this.ckActive.Size = new System.Drawing.Size(104, 24);
			this.ckActive.TabIndex = 6;
			this.ckActive.Text = "Registrado";
			this.ckActive.UseVisualStyleBackColor = true;
			// 
			// NormalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 205);
			this.Controls.Add(this.ckActive);
			this.Controls.Add(this.btnValidar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Name = "NormalForm";
			this.Text = "NormalForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
