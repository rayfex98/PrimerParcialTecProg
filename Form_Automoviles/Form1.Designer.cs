
namespace Form_Automoviles
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
            this.cboxSoft = new System.Windows.Forms.CheckBox();
            this.cboxAlarma = new System.Windows.Forms.CheckBox();
            this.cboxVidrio = new System.Windows.Forms.CheckBox();
            this.cboxBaliza = new System.Windows.Forms.CheckBox();
            this.cboxNeon = new System.Windows.Forms.CheckBox();
            this.cmboxVehiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVeh = new System.Windows.Forms.DataGridView();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxSoft
            // 
            this.cboxSoft.AutoSize = true;
            this.cboxSoft.Location = new System.Drawing.Point(321, 93);
            this.cboxSoft.Name = "cboxSoft";
            this.cboxSoft.Size = new System.Drawing.Size(113, 19);
            this.cboxSoft.TabIndex = 0;
            this.cboxSoft.Text = "Software Update";
            this.cboxSoft.UseVisualStyleBackColor = true;
            // 
            // cboxAlarma
            // 
            this.cboxAlarma.AutoSize = true;
            this.cboxAlarma.Location = new System.Drawing.Point(321, 118);
            this.cboxAlarma.Name = "cboxAlarma";
            this.cboxAlarma.Size = new System.Drawing.Size(64, 19);
            this.cboxAlarma.TabIndex = 1;
            this.cboxAlarma.Text = "Alarma";
            this.cboxAlarma.UseVisualStyleBackColor = true;
            // 
            // cboxVidrio
            // 
            this.cboxVidrio.AutoSize = true;
            this.cboxVidrio.Location = new System.Drawing.Point(321, 143);
            this.cboxVidrio.Name = "cboxVidrio";
            this.cboxVidrio.Size = new System.Drawing.Size(115, 19);
            this.cboxVidrio.TabIndex = 2;
            this.cboxVidrio.Text = "Vidrio Polarizado";
            this.cboxVidrio.UseVisualStyleBackColor = true;
            // 
            // cboxBaliza
            // 
            this.cboxBaliza.AutoSize = true;
            this.cboxBaliza.Location = new System.Drawing.Point(321, 168);
            this.cboxBaliza.Name = "cboxBaliza";
            this.cboxBaliza.Size = new System.Drawing.Size(61, 19);
            this.cboxBaliza.TabIndex = 3;
            this.cboxBaliza.Text = "Balizas";
            this.cboxBaliza.UseVisualStyleBackColor = true;
            // 
            // cboxNeon
            // 
            this.cboxNeon.AutoSize = true;
            this.cboxNeon.Location = new System.Drawing.Point(321, 194);
            this.cboxNeon.Name = "cboxNeon";
            this.cboxNeon.Size = new System.Drawing.Size(102, 19);
            this.cboxNeon.TabIndex = 4;
            this.cboxNeon.Text = "Luces de neón";
            this.cboxNeon.UseVisualStyleBackColor = true;
            // 
            // cmboxVehiculos
            // 
            this.cmboxVehiculos.FormattingEnabled = true;
            this.cmboxVehiculos.Location = new System.Drawing.Point(39, 89);
            this.cmboxVehiculos.Name = "cmboxVehiculos";
            this.cmboxVehiculos.Size = new System.Drawing.Size(192, 23);
            this.cmboxVehiculos.TabIndex = 5;
            this.cmboxVehiculos.Text = "Vehiculo";
            this.cmboxVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mejoras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular Precio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvVeh
            // 
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehiculo,
            this.VelMax,
            this.DistanciaRecorrida,
            this.Tanque});
            this.dgvVeh.Location = new System.Drawing.Point(39, 277);
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.RowTemplate.Height = 25;
            this.dgvVeh.Size = new System.Drawing.Size(443, 65);
            this.dgvVeh.TabIndex = 8;
            this.dgvVeh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.Name = "Vehiculo";
            // 
            // VelMax
            // 
            this.VelMax.HeaderText = "Velocidad Maxima";
            this.VelMax.Name = "VelMax";
            // 
            // DistanciaRecorrida
            // 
            this.DistanciaRecorrida.HeaderText = "Distancia Recorrida";
            this.DistanciaRecorrida.Name = "DistanciaRecorrida";
            // 
            // Tanque
            // 
            this.Tanque.HeaderText = "Capacidad del tanque";
            this.Tanque.Name = "Tanque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "$1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "$7500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "$1500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "$5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "$1500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVeh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxVehiculos);
            this.Controls.Add(this.cboxNeon);
            this.Controls.Add(this.cboxBaliza);
            this.Controls.Add(this.cboxVidrio);
            this.Controls.Add(this.cboxAlarma);
            this.Controls.Add(this.cboxSoft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxSoft;
        private System.Windows.Forms.CheckBox cboxAlarma;
        private System.Windows.Forms.CheckBox cboxVidrio;
        private System.Windows.Forms.CheckBox cboxBaliza;
        private System.Windows.Forms.CheckBox cboxNeon;
        private System.Windows.Forms.ComboBox cmboxVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

