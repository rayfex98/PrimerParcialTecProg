using System;
using System.Windows.Forms;
using BLL_Automoviles;

namespace Form_Automoviles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Concesionaria objConcesionaria = new Concesionaria();
        protected Vehiculo objvehiculo = new Vehiculo();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboxAutomoviles.Enabled = false;
            cmboxAutomoviles.DataSource = objConcesionaria.AutomovilesDisponibles();
            cmboxAutomoviles.DisplayMember = "Modelo";
            cmboxCamionetas.Enabled = false;
            cmboxCamionetas.DataSource = objConcesionaria.CamionetasDisponibles();
            cmboxCamionetas.DisplayMember = "Modelo";
        }
        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            if (rbtnAutomovil.Checked) 
            {
                objvehiculo = (Vehiculo)(cmboxAutomoviles.SelectedItem);
            }
            if (rbtnCamioneta.Checked)
            {
                objvehiculo = (Vehiculo)(cmboxCamionetas.SelectedItem);
            }
            int n = dgvVeh.Rows.Add();
            dgvVeh.Rows[n].Cells[0].Value = objvehiculo.Modelo;
            dgvVeh.Rows[n].Cells[1].Value = objvehiculo.ARGVelMax();
            dgvVeh.Rows[n].Cells[2].Value = objvehiculo.ARGDistancia();
            dgvVeh.Rows[n].Cells[3].Value = objvehiculo.ARGTanque();
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        { 
            Mejoras objmejora = new Mejoras();
            float cotizador = 163.35f;
            // cotizador = (float.Parse(tboxCotizador.Text));
            objConcesionaria.ObtenerMejoras(objmejora);
            if (rbtnAutomovil.Checked)
            {
                objvehiculo = (Vehiculo)(cmboxAutomoviles.SelectedItem);
                Automovil catAuto = new Automovil();
                objvehiculo.Categoria = catAuto;
            }
            if (rbtnCamioneta.Checked)
            {
                objvehiculo = (Vehiculo)(cmboxCamionetas.SelectedItem);
                Camioneta catCamioneta = new Camioneta();
                objvehiculo.Categoria = catCamioneta;
            }
            if (cboxSoft.Checked)
            {
                objvehiculo.Mejora.SoftUpdate = objmejora.ARGSoft(cotizador);
            }
            if (cboxAlarma.Checked)
            {
                objvehiculo.Mejora.Alarma = objmejora.Alarma;
            }
            if (cboxVidrio.Checked)
            {
                objvehiculo.Mejora.Vidrio = objmejora.Vidrio;
            }
            if (cboxBaliza.Checked)
            {
                objvehiculo.Mejora.Baliza = objmejora.Baliza;
            }
            if (cboxNeon.Checked)
            {
                objvehiculo.Mejora.LuzNeon= objmejora.LuzNeon;
            }
            MessageBox.Show(objConcesionaria.CalcularPrecio(objvehiculo, objmejora, cotizador));
        }
        private void rbtnAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if (!cmboxAutomoviles.Enabled)
            {
                cmboxAutomoviles.Enabled = true;
                cmboxCamionetas.Enabled = false;
            }
        }
        private void rbtnCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            if (!cmboxCamionetas.Enabled)
            {
                cmboxCamionetas.Enabled = true;
                cmboxAutomoviles.Enabled = false;
            }
        }
    }  
}
