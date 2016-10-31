/*
 * Creado por SharpDevelop.
 * Usuario: wired
 * Fecha: 30/10/2016
 * Hora: 05:42 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace App.WinFormEvent
{
	partial class NubesForm
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
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnDibujar = new System.Windows.Forms.Button();
			this.btnActivarTimer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// btnDibujar
			// 
			this.btnDibujar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDibujar.Location = new System.Drawing.Point(13, 13);
			this.btnDibujar.Name = "btnDibujar";
			this.btnDibujar.Size = new System.Drawing.Size(235, 75);
			this.btnDibujar.TabIndex = 0;
			this.btnDibujar.TabStop = false;
			this.btnDibujar.Text = "Dibujar Clic";
			this.btnDibujar.UseVisualStyleBackColor = true;
			this.btnDibujar.Click += new System.EventHandler(this.BtnDibujarClick);
			// 
			// btnActivarTimer
			// 
			this.btnActivarTimer.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActivarTimer.Location = new System.Drawing.Point(267, 13);
			this.btnActivarTimer.Name = "btnActivarTimer";
			this.btnActivarTimer.Size = new System.Drawing.Size(235, 75);
			this.btnActivarTimer.TabIndex = 1;
			this.btnActivarTimer.TabStop = false;
			this.btnActivarTimer.Text = "Activar/Detener Timer";
			this.btnActivarTimer.UseVisualStyleBackColor = true;
			this.btnActivarTimer.Click += new System.EventHandler(this.BtnActivarTimerClick);
			// 
			// NubesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 486);
			this.Controls.Add(this.btnActivarTimer);
			this.Controls.Add(this.btnDibujar);
			this.Name = "NubesForm";
			this.Text = "NubesForm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NubesFormKeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NubesFormKeyPress);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnActivarTimer;
		private System.Windows.Forms.Button btnDibujar;
		private System.Windows.Forms.Timer timer1;
	}
}
