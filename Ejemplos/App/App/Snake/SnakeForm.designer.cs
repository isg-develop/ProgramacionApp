namespace App.Juegos
{
    partial class SnakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.pbCanvas = new System.Windows.Forms.PictureBox();
        	this.lblPuntuacion = new System.Windows.Forms.Label();
        	this.gameTimer = new System.Windows.Forms.Timer(this.components);
        	this.lblGameOver = new System.Windows.Forms.Label();
        	this.Etiqueta1 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pbCanvas
        	// 
        	this.pbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
        	this.pbCanvas.Location = new System.Drawing.Point(12, 66);
        	this.pbCanvas.Name = "pbCanvas";
        	this.pbCanvas.Size = new System.Drawing.Size(904, 480);
        	this.pbCanvas.TabIndex = 0;
        	this.pbCanvas.TabStop = false;
        	this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
        	// 
        	// lblPuntuacion
        	// 
        	this.lblPuntuacion.AutoSize = true;
        	this.lblPuntuacion.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblPuntuacion.Location = new System.Drawing.Point(787, -4);
        	this.lblPuntuacion.Name = "lblPuntuacion";
        	this.lblPuntuacion.Size = new System.Drawing.Size(112, 50);
        	this.lblPuntuacion.TabIndex = 2;
        	this.lblPuntuacion.Text = "000";
        	// 
        	// lblGameOver
        	// 
        	this.lblGameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.lblGameOver.AutoSize = true;
        	this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblGameOver.Location = new System.Drawing.Point(422, 158);
        	this.lblGameOver.Name = "lblGameOver";
        	this.lblGameOver.Size = new System.Drawing.Size(102, 37);
        	this.lblGameOver.TabIndex = 3;
        	this.lblGameOver.Text = "label2";
        	this.lblGameOver.Visible = false;
        	// 
        	// Etiqueta1
        	// 
        	this.Etiqueta1.AutoSize = true;
        	this.Etiqueta1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Etiqueta1.Location = new System.Drawing.Point(635, 9);
        	this.Etiqueta1.Name = "Etiqueta1";
        	this.Etiqueta1.Size = new System.Drawing.Size(155, 35);
        	this.Etiqueta1.TabIndex = 4;
        	this.Etiqueta1.Text = "Puntos:";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(28, 28);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(115, 35);
        	this.label1.TabIndex = 5;
        	this.label1.Text = "Snake";
        	// 
        	// SnakeForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(928, 558);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.Etiqueta1);
        	this.Controls.Add(this.lblGameOver);
        	this.Controls.Add(this.lblPuntuacion);
        	this.Controls.Add(this.pbCanvas);
        	this.Name = "SnakeForm";
        	this.Text = "Form1";
        	this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        	this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
        	((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label Etiqueta1;
        private System.Windows.Forms.Label label1;
    }
}

