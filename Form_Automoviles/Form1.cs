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
            cmboxCamionetas.Enabled = false;
            cmboxAutomoviles.DataSource = objConcesionaria.AutomovilesDisponibles();
            cmboxAutomoviles.DisplayMember = "Modelo";
            cmboxCamionetas.DataSource = objConcesionaria.CamionetasDisponibles();
            cmboxCamionetas.DisplayMember = "Modelo";
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
        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            int n = dgvVeh.Rows.Add();
            if (rbtnAutomovil.Checked)
            {
                Automovil objAuto = new Automovil();
                objAuto = (Automovil)(cmboxAutomoviles.SelectedItem);
                dgvVeh.Rows[n].Cells[0].Value = objAuto.Modelo;
                dgvVeh.Rows[n].Cells[1].Value = objAuto.ARGVelMax();
                dgvVeh.Rows[n].Cells[2].Value = objAuto.ARGDistancia();
                dgvVeh.Rows[n].Cells[3].Value = objAuto.ARGTanque();

            }
            if (rbtnCamioneta.Checked)
            {
                Camioneta objCamioneta = new Camioneta();
                objCamioneta = (Camioneta)(cmboxCamionetas.SelectedItem);
                dgvVeh.Rows[n].Cells[0].Value = objCamioneta.Modelo;
                dgvVeh.Rows[n].Cells[1].Value = objCamioneta.ARGVelMax();
                dgvVeh.Rows[n].Cells[2].Value = objCamioneta.ARGDistancia();
                dgvVeh.Rows[n].Cells[3].Value = objCamioneta.ARGTanque();

            }

        }

        private void btnPrecio_Click(object sender, EventArgs e)
        { 
            Mejoras objmejora = new Mejoras();
            float Cotizacion = float.Parse(tboxCotizador.Text); //excepcion si no ingresa valor esperado
            objmejora = objConcesionaria.ObtenerMejoras(objmejora); //sacar objmejora
            if (rbtnAutomovil.Checked)
            {
                Automovil objvehiculo = new Automovil();
                if (cboxSoft.Checked)
                {
                    objvehiculo.Mejora.SoftUpdate = objmejora.ARGSoft(Cotizacion);
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
                //objConcesionaria.CalcularPrecioAuto(objvehiculo);
            }
            else if(rbtnCamioneta.Checked)
            {
                Camioneta objvehiculo = new Camioneta();
                if (cboxSoft.Checked)
                {
                    objvehiculo.Mejora.SoftUpdate = objmejora.ARGSoft(Cotizacion);
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
            }

        }
    }
        
}
