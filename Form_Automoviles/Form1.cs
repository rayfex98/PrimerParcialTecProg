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
            cmboxVehiculos.DataSource = objConcesionaria.VehiculosDisponibles;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //evento
            int n = dgvVeh.Rows.Add();
            dgvVeh.Rows[n].Cells[0].Value = cmboxVehiculos.SelectedItem;
        }
    }
}
