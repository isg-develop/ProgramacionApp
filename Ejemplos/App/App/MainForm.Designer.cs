/*
 * Created by SharpDevelop.
 * User: elite
 * Date: 28/10/2016
 * Time: 10:24 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace App
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSingleton;
		private System.Windows.Forms.Button btnFactoryMethod;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSingleton = new System.Windows.Forms.Button();
			this.btnFactoryMethod = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnFactoryMethod);
			this.groupBox1.Controls.Add(this.btnSingleton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(35, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 259);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Patrón de diseño";
			// 
			// btnSingleton
			// 
			this.btnSingleton.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnSingleton.Location = new System.Drawing.Point(30, 45);
			this.btnSingleton.Name = "btnSingleton";
			this.btnSingleton.Size = new System.Drawing.Size(139, 36);
			this.btnSingleton.TabIndex = 0;
			this.btnSingleton.Text = "Singleton";
			this.btnSingleton.UseVisualStyleBackColor = true;
			this.btnSingleton.Click += new System.EventHandler(this.BtnSingletonClick);
			// 
			// btnFactoryMethod
			// 
			this.btnFactoryMethod.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnFactoryMethod.Location = new System.Drawing.Point(30, 112);
			this.btnFactoryMethod.Name = "btnFactoryMethod";
			this.btnFactoryMethod.Size = new System.Drawing.Size(139, 36);
			this.btnFactoryMethod.TabIndex = 1;
			this.btnFactoryMethod.Text = "Factory";
			this.btnFactoryMethod.UseVisualStyleBackColor = true;
			this.btnFactoryMethod.Click += new System.EventHandler(this.BtnFactoryMethodClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(275, 652);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.Maroon;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "App";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
