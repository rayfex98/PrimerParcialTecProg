using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Vehiculo objvehiculo = new Vehiculo();
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
            objmejora = objConcesionaria.ObtenerMejoras(objmejora); //sacar objmejora
            

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
