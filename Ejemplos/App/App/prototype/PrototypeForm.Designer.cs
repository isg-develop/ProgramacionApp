namespace App.prototype
{
    partial class PrototypeForm
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
        	this.btnValidar = new System.Windows.Forms.Button();
        	this.txtResultado = new System.Windows.Forms.RichTextBox();
        	this.btnClonar = new System.Windows.Forms.Button();
        	this.btnImprimir = new System.Windows.Forms.Button();
        	this.btnModificar = new System.Windows.Forms.Button();
        	this.btnClear = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// btnValidar
        	// 
        	this.btnValidar.Location = new System.Drawing.Point(203, 58);
        	this.btnValidar.Name = "btnValidar";
        	this.btnValidar.Size = new System.Drawing.Size(75, 23);
        	this.btnValidar.TabIndex = 0;
        	this.btnValidar.Text = "Original";
        	this.btnValidar.UseVisualStyleBackColor = true;
        	this.btnValidar.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// txtResultado
        	// 
        	this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.txtResultado.Location = new System.Drawing.Point(13, 87);
        	this.txtResultado.Name = "txtResultado";
        	this.txtResultado.ReadOnly = true;
        	this.txtResultado.Size = new System.Drawing.Size(516, 350);
        	this.txtResultado.TabIndex = 1;
        	this.txtResultado.Text = "Resultado:";
        	// 
        	// btnClonar
        	// 
        	this.btnClonar.Location = new System.Drawing.Point(284, 58);
        	this.btnClonar.Name = "btnClonar";
        	this.btnClonar.Size = new System.Drawing.Size(75, 23);
        	this.btnClonar.TabIndex = 2;
        	this.btnClonar.Text = "Clonar";
        	this.btnClonar.UseVisualStyleBackColor = true;
        	this.btnClonar.Click += new System.EventHandler(this.BtnClonarClick);
        	// 
        	// btnImprimir
        	// 
        	this.btnImprimir.Location = new System.Drawing.Point(13, 58);
        	this.btnImprimir.Name = "btnImprimir";
        	this.btnImprimir.Size = new System.Drawing.Size(75, 23);
        	this.btnImprimir.TabIndex = 3;
        	this.btnImprimir.Text = "Imprimir";
        	this.btnImprimir.UseVisualStyleBackColor = true;
        	this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
        	// 
        	// btnModificar
        	// 
        	this.btnModificar.Location = new System.Drawing.Point(365, 58);
        	this.btnModificar.Name = "btnModificar";
        	this.btnModificar.Size = new System.Drawing.Size(145, 23);
        	this.btnModificar.TabIndex = 4;
        	this.btnModificar.Text = "Modificar Clonado (todo)";
        	this.btnModificar.UseVisualStyleBackColor = true;
        	this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
        	// 
        	// btnClear
        	// 
        	this.btnClear.Location = new System.Drawing.Point(13, 29);
        	this.btnClear.Name = "btnClear";
        	this.btnClear.Size = new System.Drawing.Size(119, 23);
        	this.btnClear.TabIndex = 5;
        	this.btnClear.Text = "Limpiar pantalla";
        	this.btnClear.UseVisualStyleBackColor = true;
        	this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
        	// 
        	// PrototypeForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(551, 450);
        	this.Controls.Add(this.btnClear);
        	this.Controls.Add(this.btnModificar);
        	this.Controls.Add(this.btnImprimir);
        	this.Controls.Add(this.btnClonar);
        	this.Controls.Add(this.txtResultado);
        	this.Controls.Add(this.btnValidar);
        	this.Name = "PrototypeForm";
        	this.Text = "PrototypeForm";
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnClear;
    }
}