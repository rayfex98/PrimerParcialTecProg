
namespace UIParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxVehiculo = new System.Windows.Forms.ComboBox();
            this.cboxSoftUp = new System.Windows.Forms.CheckBox();
            this.cboxAlarma = new System.Windows.Forms.CheckBox();
            this.cboxVidrio = new System.Windows.Forms.CheckBox();
            this.cboxBaliza = new System.Windows.Forms.CheckBox();
            this.cboxLuces = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxVehiculo
            // 
            this.cboxVehiculo.FormattingEnabled = true;
            this.cboxVehiculo.Location = new System.Drawing.Point(59, 78);
            this.cboxVehiculo.Name = "cboxVehiculo";
            this.cboxVehiculo.Size = new System.Drawing.Size(191, 23);
            this.cboxVehiculo.TabIndex = 1;
            this.cboxVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboxVehiculo_SelectedIndexChanged);
            // 
            // cboxSoftUp
            // 
            this.cboxSoftUp.AutoSize = true;
            this.cboxSoftUp.Location = new System.Drawing.Point(390, 104);
            this.cboxSoftUp.Name = "cboxSoftUp";
            this.cboxSoftUp.Size = new System.Drawing.Size(113, 19);
            this.cboxSoftUp.TabIndex = 2;
            this.cboxSoftUp.Text = "Software Update";
            this.cboxSoftUp.UseVisualStyleBackColor = true;
            this.cboxSoftUp.CheckedChanged += new System.EventHandler(this.cboxSoftUp_CheckedChanged);
            // 
            // cboxAlarma
            // 
            this.cboxAlarma.AutoSize = true;
            this.cboxAlarma.Location = new System.Drawing.Point(390, 129);
            this.cboxAlarma.Name = "cboxAlarma";
            this.cboxAlarma.Size = new System.Drawing.Size(64, 19);
            this.cboxAlarma.TabIndex = 3;
            this.cboxAlarma.Text = "Alarma";
            this.cboxAlarma.UseVisualStyleBackColor = true;
            // 
            // cboxVidrio
            // 
            this.cboxVidrio.AutoSize = true;
            this.cboxVidrio.Location = new System.Drawing.Point(390, 154);
            this.cboxVidrio.Name = "cboxVidrio";
            this.cboxVidrio.Size = new System.Drawing.Size(115, 19);
            this.cboxVidrio.TabIndex = 4;
            this.cboxVidrio.Text = "Vidrio Polarizado";
            this.cboxVidrio.UseVisualStyleBackColor = true;
            // 
            // cboxBaliza
            // 
            this.cboxBaliza.AutoSize = true;
            this.cboxBaliza.Location = new System.Drawing.Point(390, 179);
            this.cboxBaliza.Name = "cboxBaliza";
            this.cboxBaliza.Size = new System.Drawing.Size(61, 19);
            this.cboxBaliza.TabIndex = 5;
            this.cboxBaliza.Text = "Balizas";
            this.cboxBaliza.UseVisualStyleBackColor = true;
            // 
            // cboxLuces
            // 
            this.cboxLuces.AutoSize = true;
            this.cboxLuces.Location = new System.Drawing.Point(390, 205);
            this.cboxLuces.Name = "cboxLuces";
            this.cboxLuces.Size = new System.Drawing.Size(102, 19);
            this.cboxLuces.TabIndex = 6;
            this.cboxLuces.Text = "Luces de neón";
            this.cboxLuces.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mejoras";
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(430, 281);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(75, 23);
            this.btnPrecio.TabIndex = 8;
            this.btnPrecio.Text = "Ver Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "$1500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$5000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "$1500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "$1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "$7500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxLuces);
            this.Controls.Add(this.cboxBaliza);
            this.Controls.Add(this.cboxVidrio);
            this.Controls.Add(this.cboxAlarma);
            this.Controls.Add(this.cboxSoftUp);
            this.Controls.Add(this.cboxVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxVehiculo;
        private System.Windows.Forms.CheckBox cboxSoftUp;
        private System.Windows.Forms.CheckBox cboxAlarma;
        private System.Windows.Forms.CheckBox cboxVidrio;
        private System.Windows.Forms.CheckBox cboxBaliza;
        private System.Windows.Forms.CheckBox cboxLuces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

