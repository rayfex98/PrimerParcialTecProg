
namespace Form_Automoviles
{
    partial class GrillaVehiculo
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
            this.dgvPrecio = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoftUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alarma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vidrios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balizas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuzNeon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMejoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanciaRecorrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanqueLitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.AccessibleName = "dgvPrecio";
            this.dgvPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.PrecioVeh,
            this.SoftUp,
            this.Alarma,
            this.Vidrios,
            this.Balizas,
            this.LuzNeon,
            this.PrecioMejoras,
            this.PrecioTotal});
            this.dgvPrecio.Location = new System.Drawing.Point(0, 0);
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.RowTemplate.Height = 25;
            this.dgvPrecio.Size = new System.Drawing.Size(943, 132);
            this.dgvPrecio.TabIndex = 0;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // PrecioVeh
            // 
            this.PrecioVeh.HeaderText = "Precio Vehiculo";
            this.PrecioVeh.Name = "PrecioVeh";
            // 
            // SoftUp
            // 
            this.SoftUp.HeaderText = "Software Update";
            this.SoftUp.Name = "SoftUp";
            // 
            // Alarma
            // 
            this.Alarma.HeaderText = "Alarma";
            this.Alarma.Name = "Alarma";
            // 
            // Vidrios
            // 
            this.Vidrios.HeaderText = "Vidrios";
            this.Vidrios.Name = "Vidrios";
            // 
            // Balizas
            // 
            this.Balizas.HeaderText = "Balizas";
            this.Balizas.Name = "Balizas";
            // 
            // LuzNeon
            // 
            this.LuzNeon.HeaderText = "Luces de neón";
            this.LuzNeon.Name = "LuzNeon";
            // 
            // PrecioMejoras
            // 
            this.PrecioMejoras.HeaderText = "Total Mejoras";
            this.PrecioMejoras.Name = "PrecioMejoras";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.VelMax,
            this.DistanciaRecorrida,
            this.TanqueLitro});
            this.dgvCaracteristicas.Location = new System.Drawing.Point(0, 131);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.RowTemplate.Height = 25;
            this.dgvCaracteristicas.Size = new System.Drawing.Size(443, 106);
            this.dgvCaracteristicas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // VelMax
            // 
            this.VelMax.HeaderText = "Velocidad máxima en km/h";
            this.VelMax.Name = "VelMax";
            this.VelMax.ReadOnly = true;
            // 
            // DistanciaRecorrida
            // 
            this.DistanciaRecorrida.HeaderText = "Distancia Recorrida en km";
            this.DistanciaRecorrida.Name = "DistanciaRecorrida";
            this.DistanciaRecorrida.ReadOnly = true;
            // 
            // TanqueLitro
            // 
            this.TanqueLitro.HeaderText = "Capacidad de tanque en Litros";
            this.TanqueLitro.Name = "TanqueLitro";
            this.TanqueLitro.ReadOnly = true;
            // 
            // GrillaVehiculo
            // 
            this.AccessibleName = "dtgPrecio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 231);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.dgvPrecio);
            this.Name = "GrillaVehiculo";
            this.Text = "Grilla datos del vehículo en pesos";
            this.Load += new System.EventHandler(this.GrillaPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vidrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuzNeon;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMejoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanciaRecorrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanqueLitro;
    }
}