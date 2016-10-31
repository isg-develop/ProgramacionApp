/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 29/10/2016
 * Hora: 07:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace App.WinFormEvent
{
	partial class DrawingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cboFigura = new System.Windows.Forms.ComboBox();
			this.cboColor = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDibujar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(35, 109);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(641, 406);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Figura";
			// 
			// cboFigura
			// 
			this.cboFigura.FormattingEnabled = true;
			this.cboFigura.Items.AddRange(new object[] {
									"Punto",
									"Línea",
									"Cuadro",
									"Rectangulo",
									"Elipse",
									"Circunferencia",
									"Triangulo"});
			this.cboFigura.Location = new System.Drawing.Point(99, 48);
			this.cboFigura.Name = "cboFigura";
			this.cboFigura.Size = new System.Drawing.Size(121, 21);
			this.cboFigura.TabIndex = 8;
			// 
			// cboColor
			// 
			this.cboColor.FormattingEnabled = true;
			this.cboColor.Items.AddRange(new object[] {
									"Rojo",
									"Negro",
									"Blanco",
									"Azul",
									"Naranja"});
			this.cboColor.Location = new System.Drawing.Point(300, 51);
			this.cboColor.Name = "cboColor";
			this.cboColor.Size = new System.Drawing.Size(121, 21);
			this.cboColor.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(263, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Color";
			// 
			// btnDibujar
			// 
			this.btnDibujar.Location = new System.Drawing.Point(480, 48);
			this.btnDibujar.Name = "btnDibujar";
			this.btnDibujar.Size = new System.Drawing.Size(75, 23);
			this.btnDibujar.TabIndex = 11;
			this.btnDibujar.Text = "Dibujar";
			this.btnDibujar.UseVisualStyleBackColor = true;
			this.btnDibujar.Click += new System.EventHandler(this.BtnDibujarClick);
			// 
			// DrawingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 525);
			this.Controls.Add(this.btnDibujar);
			this.Controls.Add(this.cboColor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboFigura);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "DrawingForm";
			this.Text = "DrawingForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnDibujar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboColor;
		private System.Windows.Forms.ComboBox cboFigura;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
