/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 31/10/2016
 * Hora: 06:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace App.TorreLineas
{
	partial class LineaTorreForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnGraficar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtNumLineas = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumLineas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vigas No.:";
			// 
			// btnGraficar
			// 
			this.btnGraficar.Location = new System.Drawing.Point(192, 31);
			this.btnGraficar.Name = "btnGraficar";
			this.btnGraficar.Size = new System.Drawing.Size(75, 23);
			this.btnGraficar.TabIndex = 2;
			this.btnGraficar.Text = "Dibujar";
			this.btnGraficar.UseVisualStyleBackColor = true;
			this.btnGraficar.Click += new System.EventHandler(this.BtnGraficarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(0, 76);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(414, 257);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// txtNumLineas
			// 
			this.txtNumLineas.Location = new System.Drawing.Point(87, 34);
			this.txtNumLineas.Name = "txtNumLineas";
			this.txtNumLineas.Size = new System.Drawing.Size(85, 20);
			this.txtNumLineas.TabIndex = 5;
			this.txtNumLineas.Value = new decimal(new int[] {
									30,
									0,
									0,
									0});
			// 
			// LineaTorreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 345);
			this.Controls.Add(this.txtNumLineas);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnGraficar);
			this.Controls.Add(this.label1);
			this.Name = "LineaTorreForm";
			this.Text = "LineaTorreForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumLineas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown txtNumLineas;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnGraficar;
		private System.Windows.Forms.Label label1;
	}
}
