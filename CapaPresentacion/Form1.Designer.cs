
namespace CapaPresentacion
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
            this.cmboxAutomoviles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.dgvVeh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnAutomovil = new System.Windows.Forms.RadioButton();
            this.rbtnCamioneta = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxCotizador = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboxCamionetas = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxSoft
            // 
            this.cboxSoft.AutoSize = true;
            this.cboxSoft.Location = new System.Drawing.Point(548, 230);
            this.cboxSoft.Name = "cboxSoft";
            this.cboxSoft.Size = new System.Drawing.Size(113, 19);
            this.cboxSoft.TabIndex = 0;
            this.cboxSoft.Text = "Software Update";
            this.cboxSoft.UseVisualStyleBackColor = true;
            // 
            // cboxAlarma
            // 
            this.cboxAlarma.AutoSize = true;
            this.cboxAlarma.Location = new System.Drawing.Point(548, 255);
            this.cboxAlarma.Name = "cboxAlarma";
            this.cboxAlarma.Size = new System.Drawing.Size(64, 19);
            this.cboxAlarma.TabIndex = 1;
            this.cboxAlarma.Text = "Alarma";
            this.cboxAlarma.UseVisualStyleBackColor = true;
            // 
            // cboxVidrio
            // 
            this.cboxVidrio.AutoSize = true;
            this.cboxVidrio.Location = new System.Drawing.Point(548, 280);
            this.cboxVidrio.Name = "cboxVidrio";
            this.cboxVidrio.Size = new System.Drawing.Size(115, 19);
            this.cboxVidrio.TabIndex = 2;
            this.cboxVidrio.Text = "Vidrio Polarizado";
            this.cboxVidrio.UseVisualStyleBackColor = true;
            // 
            // cboxBaliza
            // 
            this.cboxBaliza.AutoSize = true;
            this.cboxBaliza.Location = new System.Drawing.Point(548, 305);
            this.cboxBaliza.Name = "cboxBaliza";
            this.cboxBaliza.Size = new System.Drawing.Size(61, 19);
            this.cboxBaliza.TabIndex = 3;
            this.cboxBaliza.Text = "Balizas";
            this.cboxBaliza.UseVisualStyleBackColor = true;
            // 
            // cboxNeon
            // 
            this.cboxNeon.AutoSize = true;
            this.cboxNeon.Location = new System.Drawing.Point(548, 331);
            this.cboxNeon.Name = "cboxNeon";
            this.cboxNeon.Size = new System.Drawing.Size(102, 19);
            this.cboxNeon.TabIndex = 4;
            this.cboxNeon.Text = "Luces de neón";
            this.cboxNeon.UseVisualStyleBackColor = true;
            // 
            // cmboxAutomoviles
            // 
            this.cmboxAutomoviles.Enabled = false;
            this.cmboxAutomoviles.FormattingEnabled = true;
            this.cmboxAutomoviles.Location = new System.Drawing.Point(38, 100);
            this.cmboxAutomoviles.Name = "cmboxAutomoviles";
            this.cmboxAutomoviles.Size = new System.Drawing.Size(208, 23);
            this.cmboxAutomoviles.TabIndex = 5;
            this.cmboxAutomoviles.Text = "Modelos de automóviles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione las mejoras";
            // 
            // btnPrecio
            // 
            this.btnPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrecio.Location = new System.Drawing.Point(548, 381);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(178, 38);
            this.btnPrecio.TabIndex = 7;
            this.btnPrecio.Text = "Calcular precio final";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // dgvVeh
            // 
            this.dgvVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.VelMax,
            this.DistanciaRecorrida,
            this.Tanque});
            this.dgvVeh.Location = new System.Drawing.Point(39, 259);
            this.dgvVeh.Name = "dgvVeh";
            this.dgvVeh.RowTemplate.Height = 25;
            this.dgvVeh.Size = new System.Drawing.Size(443, 227);
            this.dgvVeh.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "  $    1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "  $    7500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "  $    1500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "  $    5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "U$D 1500";
            // 
            // rbtnAutomovil
            // 
            this.rbtnAutomovil.AutoSize = true;
            this.rbtnAutomovil.Location = new System.Drawing.Point(38, 75);
            this.rbtnAutomovil.Name = "rbtnAutomovil";
            this.rbtnAutomovil.Size = new System.Drawing.Size(56, 19);
            this.rbtnAutomovil.TabIndex = 14;
            this.rbtnAutomovil.TabStop = true;
            this.rbtnAutomovil.Text = "Autos";
            this.rbtnAutomovil.UseVisualStyleBackColor = true;
            this.rbtnAutomovil.CheckedChanged += new System.EventHandler(this.rbtnAutomovil_CheckedChanged);
            // 
            // rbtnCamioneta
            // 
            this.rbtnCamioneta.AutoSize = true;
            this.rbtnCamioneta.Location = new System.Drawing.Point(286, 75);
            this.rbtnCamioneta.Name = "rbtnCamioneta";
            this.rbtnCamioneta.Size = new System.Drawing.Size(88, 19);
            this.rbtnCamioneta.TabIndex = 15;
            this.rbtnCamioneta.TabStop = true;
            this.rbtnCamioneta.Text = "Camionetas";
            this.rbtnCamioneta.UseVisualStyleBackColor = true;
            this.rbtnCamioneta.CheckedChanged += new System.EventHandler(this.rbtnCamioneta_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(39, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(207, 37);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar modelo a comparador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnCaracteristicas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = " U$D 100.000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "U$D 150.000";
            // 
            // tboxCotizador
            // 
            this.tboxCotizador.Location = new System.Drawing.Point(548, 141);
            this.tboxCotizador.Name = "tboxCotizador";
            this.tboxCotizador.Size = new System.Drawing.Size(64, 23);
            this.tboxCotizador.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cotización! 1 Peso equivale a";
            // 
            // cmboxCamionetas
            // 
            this.cmboxCamionetas.FormattingEnabled = true;
            this.cmboxCamionetas.Location = new System.Drawing.Point(286, 99);
            this.cmboxCamionetas.Name = "cmboxCamionetas";
            this.cmboxCamionetas.Size = new System.Drawing.Size(196, 23);
            this.cmboxCamionetas.TabIndex = 22;
            this.cmboxCamionetas.Text = "Modelos de camionetas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(38, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(409, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "Seleccione una categoria y modelo para calcular su precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(616, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "dólares.";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // VelMax
            // 
            this.VelMax.HeaderText = "Velocidad Maxima en km/h";
            this.VelMax.Name = "VelMax";
            this.VelMax.ReadOnly = true;
            // 
            // DistanciaRecorrida
            // 
            this.DistanciaRecorrida.HeaderText = "Distancia Recorrida en km";
            this.DistanciaRecorrida.Name = "DistanciaRecorrida";
            this.DistanciaRecorrida.ReadOnly = true;
            // 
            // Tanque
            // 
            this.Tanque.HeaderText = "Capacidad del tanque en litros";
            this.Tanque.Name = "Tanque";
            this.Tanque.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 557);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmboxCamionetas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tboxCotizador);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtnCamioneta);
            this.Controls.Add(this.rbtnAutomovil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVeh);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxAutomoviles);
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
        private System.Windows.Forms.ComboBox cmboxAutomoviles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.DataGridView dgvVeh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnAutomovil;
        private System.Windows.Forms.RadioButton rbtnCamioneta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxCotizador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboxCamionetas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanque;
    }
}

