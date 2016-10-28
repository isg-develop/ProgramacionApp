namespace App.factory
{
    partial class FacturaForm
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.btnCalcular = new System.Windows.Forms.Button();
        	this.optIVA16 = new System.Windows.Forms.RadioButton();
        	this.optIVA5 = new System.Windows.Forms.RadioButton();
        	this.txtImporte = new System.Windows.Forms.TextBox();
        	this.txtResultado = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(78, 188);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(98, 24);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Importe $";
        	// 
        	// btnCalcular
        	// 
        	this.btnCalcular.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnCalcular.Location = new System.Drawing.Point(307, 185);
        	this.btnCalcular.Name = "btnCalcular";
        	this.btnCalcular.Size = new System.Drawing.Size(110, 78);
        	this.btnCalcular.TabIndex = 1;
        	this.btnCalcular.Text = "Calcular";
        	this.btnCalcular.UseVisualStyleBackColor = true;
        	this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
        	// 
        	// optIVA16
        	// 
        	this.optIVA16.AutoSize = true;
        	this.optIVA16.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.optIVA16.Location = new System.Drawing.Point(41, 19);
        	this.optIVA16.Name = "optIVA16";
        	this.optIVA16.Size = new System.Drawing.Size(102, 28);
        	this.optIVA16.TabIndex = 2;
        	this.optIVA16.Text = "IVA 16%";
        	this.optIVA16.UseVisualStyleBackColor = true;
        	// 
        	// optIVA5
        	// 
        	this.optIVA5.AutoSize = true;
        	this.optIVA5.Checked = true;
        	this.optIVA5.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.optIVA5.Location = new System.Drawing.Point(41, 53);
        	this.optIVA5.Name = "optIVA5";
        	this.optIVA5.Size = new System.Drawing.Size(103, 28);
        	this.optIVA5.TabIndex = 3;
        	this.optIVA5.TabStop = true;
        	this.optIVA5.Text = "IVA (5%)";
        	this.optIVA5.UseVisualStyleBackColor = true;
        	// 
        	// txtImporte
        	// 
        	this.txtImporte.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtImporte.Location = new System.Drawing.Point(182, 185);
        	this.txtImporte.Name = "txtImporte";
        	this.txtImporte.Size = new System.Drawing.Size(100, 31);
        	this.txtImporte.TabIndex = 4;
        	this.txtImporte.Text = "100";
        	// 
        	// txtResultado
        	// 
        	this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtResultado.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtResultado.Location = new System.Drawing.Point(183, 231);
        	this.txtResultado.Name = "txtResultado";
        	this.txtResultado.Size = new System.Drawing.Size(100, 32);
        	this.txtResultado.TabIndex = 5;
        	this.txtResultado.Text = "0.0";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Myriad Web Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(105, 231);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(71, 24);
        	this.label3.TabIndex = 6;
        	this.label3.Text = "Total $";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.optIVA16);
        	this.groupBox1.Controls.Add(this.optIVA5);
        	this.groupBox1.Location = new System.Drawing.Point(95, 43);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(200, 100);
        	this.groupBox1.TabIndex = 7;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Opciones";
        	// 
        	// FacturaForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(478, 293);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.txtResultado);
        	this.Controls.Add(this.txtImporte);
        	this.Controls.Add(this.btnCalcular);
        	this.Controls.Add(this.label1);
        	this.Name = "FacturaForm";
        	this.Text = "FacturaForm";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton optIVA16;
        private System.Windows.Forms.RadioButton optIVA5;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}