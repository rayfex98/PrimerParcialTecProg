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
            cmboxVehiculos.Enabled = false;
        }
        private void rbtnAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if(cmboxVehiculos.Enabled == false)
            {
                cmboxVehiculos.Enabled = true;
            }
            cmboxVehiculos.Items.Clear();
            cmboxVehiculos.DataSource = objConcesionaria.AutomovilesDisponibles();
            cmboxVehiculos.DisplayMember = "Modelo";
        }
        private void rbtnCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            if (cmboxVehiculos.Enabled == false)
            {
                cmboxVehiculos.Enabled = true;
            }
            cmboxVehiculos.Items.Clear();
            cmboxVehiculos.DataSource = objConcesionaria.CamionetasDisponibles();
            cmboxVehiculos.DisplayMember = "Modelo";
        }
        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            int n = dgvVeh.Rows.Add();
            if (rbtnAutomovil.Checked == true)
            {
                Automovil objAuto = new Automovil();
                objAuto = (Automovil)(cmboxVehiculos.SelectedItem);
                dgvVeh.Rows[n].Cells[0].Value = objAuto.Modelo;
                dgvVeh.Rows[n].Cells[0].Value = objAuto.VelMax;
                dgvVeh.Rows[n].Cells[0].Value = objAuto.KmRecorridos;
                dgvVeh.Rows[n].Cells[0].Value = objAuto.Tanque;

            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
