
namespace Form_Automoviles
{
    partial class GrillaPrecio
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).BeginInit();
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
            this.dgvPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrecio.Location = new System.Drawing.Point(0, 0);
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.RowTemplate.Height = 25;
            this.dgvPrecio.Size = new System.Drawing.Size(943, 100);
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
            // GrillaPrecio
            // 
            this.AccessibleName = "dtgPrecio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 100);
            this.Controls.Add(this.dgvPrecio);
            this.Name = "GrillaPrecio";
            this.Text = "GrillaPrecio";
            this.Load += new System.EventHandler(this.GrillaPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecio)).EndInit();
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
    }
}