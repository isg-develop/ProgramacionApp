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
		private System.Windows.Forms.Button btnPrototype;
		private System.Windows.Forms.Button btnAbstractFactory;
		private System.Windows.Forms.Button btnMVC;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnIntercept;
		private System.Windows.Forms.Button btnKeyPress;
		private System.Windows.Forms.Button btnTimer;
		private System.Windows.Forms.Button btnLimite;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnSnake;
		private System.Windows.Forms.Button btnPong;
		private System.Windows.Forms.Button btnLineas;
		private System.Windows.Forms.Button btnPicture;
		
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
			this.btnAbstractFactory = new System.Windows.Forms.Button();
			this.btnMVC = new System.Windows.Forms.Button();
			this.btnPrototype = new System.Windows.Forms.Button();
			this.btnFactoryMethod = new System.Windows.Forms.Button();
			this.btnSingleton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnIntercept = new System.Windows.Forms.Button();
			this.btnKeyPress = new System.Windows.Forms.Button();
			this.btnTimer = new System.Windows.Forms.Button();
			this.btnLimite = new System.Windows.Forms.Button();
			this.btnDraw = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSnake = new System.Windows.Forms.Button();
			this.btnPong = new System.Windows.Forms.Button();
			this.btnLineas = new System.Windows.Forms.Button();
			this.btnPicture = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAbstractFactory);
			this.groupBox1.Controls.Add(this.btnMVC);
			this.groupBox1.Controls.Add(this.btnPrototype);
			this.groupBox1.Controls.Add(this.btnFactoryMethod);
			this.groupBox1.Controls.Add(this.btnSingleton);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(281, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 358);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Patrón de diseño";
			// 
			// btnAbstractFactory
			// 
			this.btnAbstractFactory.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnAbstractFactory.Location = new System.Drawing.Point(30, 176);
			this.btnAbstractFactory.Name = "btnAbstractFactory";
			this.btnAbstractFactory.Size = new System.Drawing.Size(139, 36);
			this.btnAbstractFactory.TabIndex = 4;
			this.btnAbstractFactory.Text = "A. Factory ";
			this.btnAbstractFactory.UseVisualStyleBackColor = true;
			this.btnAbstractFactory.Click += new System.EventHandler(this.BtnAbstractFactoryClick);
			// 
			// btnMVC
			// 
			this.btnMVC.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnMVC.Location = new System.Drawing.Point(30, 298);
			this.btnMVC.Name = "btnMVC";
			this.btnMVC.Size = new System.Drawing.Size(139, 36);
			this.btnMVC.TabIndex = 3;
			this.btnMVC.Text = "MVC";
			this.btnMVC.UseVisualStyleBackColor = true;
			this.btnMVC.Click += new System.EventHandler(this.BtnMVCClick);
			// 
			// btnPrototype
			// 
			this.btnPrototype.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnPrototype.Location = new System.Drawing.Point(30, 235);
			this.btnPrototype.Name = "btnPrototype";
			this.btnPrototype.Size = new System.Drawing.Size(139, 36);
			this.btnPrototype.TabIndex = 2;
			this.btnPrototype.Text = "Prototype";
			this.btnPrototype.UseVisualStyleBackColor = true;
			this.btnPrototype.Click += new System.EventHandler(this.BtnPrototypeClick);
			// 
			// btnFactoryMethod
			// 
			this.btnFactoryMethod.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnFactoryMethod.Location = new System.Drawing.Point(30, 112);
			this.btnFactoryMethod.Name = "btnFactoryMethod";
			this.btnFactoryMethod.Size = new System.Drawing.Size(139, 36);
			this.btnFactoryMethod.TabIndex = 1;
			this.btnFactoryMethod.Text = "Factory M.";
			this.btnFactoryMethod.UseVisualStyleBackColor = true;
			this.btnFactoryMethod.Click += new System.EventHandler(this.BtnFactoryMethodClick);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnIntercept);
			this.groupBox2.Controls.Add(this.btnKeyPress);
			this.groupBox2.Controls.Add(this.btnTimer);
			this.groupBox2.Controls.Add(this.btnLimite);
			this.groupBox2.Controls.Add(this.btnDraw);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(29, 35);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(213, 358);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Eventos Forms";
			// 
			// btnIntercept
			// 
			this.btnIntercept.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnIntercept.Location = new System.Drawing.Point(19, 298);
			this.btnIntercept.Name = "btnIntercept";
			this.btnIntercept.Size = new System.Drawing.Size(167, 36);
			this.btnIntercept.TabIndex = 4;
			this.btnIntercept.Text = "IntersectsWith";
			this.btnIntercept.UseVisualStyleBackColor = true;
			this.btnIntercept.Click += new System.EventHandler(this.BtnInterceptClick);
			// 
			// btnKeyPress
			// 
			this.btnKeyPress.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnKeyPress.Location = new System.Drawing.Point(19, 236);
			this.btnKeyPress.Name = "btnKeyPress";
			this.btnKeyPress.Size = new System.Drawing.Size(167, 35);
			this.btnKeyPress.TabIndex = 3;
			this.btnKeyPress.Text = "Teclado (Keys)";
			this.btnKeyPress.UseVisualStyleBackColor = true;
			this.btnKeyPress.Click += new System.EventHandler(this.BtnKeyPressClick);
			// 
			// btnTimer
			// 
			this.btnTimer.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnTimer.Location = new System.Drawing.Point(30, 112);
			this.btnTimer.Name = "btnTimer";
			this.btnTimer.Size = new System.Drawing.Size(139, 36);
			this.btnTimer.TabIndex = 2;
			this.btnTimer.Text = "Timer";
			this.btnTimer.UseVisualStyleBackColor = true;
			this.btnTimer.Click += new System.EventHandler(this.BtnTimerClick);
			// 
			// btnLimite
			// 
			this.btnLimite.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnLimite.Location = new System.Drawing.Point(19, 176);
			this.btnLimite.Name = "btnLimite";
			this.btnLimite.Size = new System.Drawing.Size(167, 36);
			this.btnLimite.TabIndex = 1;
			this.btnLimite.Text = "Width/Height";
			this.btnLimite.UseVisualStyleBackColor = true;
			this.btnLimite.Click += new System.EventHandler(this.BtnLimiteClick);
			// 
			// btnDraw
			// 
			this.btnDraw.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnDraw.Location = new System.Drawing.Point(30, 45);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(139, 36);
			this.btnDraw.TabIndex = 0;
			this.btnDraw.Text = "Drawing";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.BtnDrawClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnSnake);
			this.groupBox3.Controls.Add(this.btnPong);
			this.groupBox3.Controls.Add(this.btnLineas);
			this.groupBox3.Controls.Add(this.btnPicture);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(29, 423);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(454, 183);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Mini Apps";
			// 
			// btnSnake
			// 
			this.btnSnake.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnSnake.Location = new System.Drawing.Point(252, 110);
			this.btnSnake.Name = "btnSnake";
			this.btnSnake.Size = new System.Drawing.Size(139, 36);
			this.btnSnake.TabIndex = 4;
			this.btnSnake.Text = "Snake";
			this.btnSnake.UseVisualStyleBackColor = true;
			this.btnSnake.Click += new System.EventHandler(this.BtnSnakeClick);
			// 
			// btnPong
			// 
			this.btnPong.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnPong.Location = new System.Drawing.Point(30, 110);
			this.btnPong.Name = "btnPong";
			this.btnPong.Size = new System.Drawing.Size(139, 36);
			this.btnPong.TabIndex = 2;
			this.btnPong.Text = "Pong";
			this.btnPong.UseVisualStyleBackColor = true;
			this.btnPong.Click += new System.EventHandler(this.BtnPongClick);
			// 
			// btnLineas
			// 
			this.btnLineas.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnLineas.Location = new System.Drawing.Point(252, 45);
			this.btnLineas.Name = "btnLineas";
			this.btnLineas.Size = new System.Drawing.Size(139, 36);
			this.btnLineas.TabIndex = 1;
			this.btnLineas.Text = "Líneas";
			this.btnLineas.UseVisualStyleBackColor = true;
			this.btnLineas.Click += new System.EventHandler(this.BtnLineasClick);
			// 
			// btnPicture
			// 
			this.btnPicture.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnPicture.Location = new System.Drawing.Point(30, 45);
			this.btnPicture.Name = "btnPicture";
			this.btnPicture.Size = new System.Drawing.Size(139, 36);
			this.btnPicture.TabIndex = 0;
			this.btnPicture.Text = "Picture";
			this.btnPicture.UseVisualStyleBackColor = true;
			this.btnPicture.Click += new System.EventHandler(this.BtnPictureClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(554, 652);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.ForeColor = System.Drawing.Color.Maroon;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "App";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
