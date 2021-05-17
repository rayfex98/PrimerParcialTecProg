﻿using System;
using System.Globalization;
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
        private Vehiculo objvehiculo = new Vehiculo();

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrecio.Enabled = false;
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
            float cotizador = 163.35f; //unirlo directo al txtbox
            bool flag = true;
            Vehiculo mejorado = new Vehiculo();
            Compra objCompra = new Compra(); 
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
            try
            {
                cotizador = (float.Parse(tboxCotizador.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat)); 
                if (cotizador <= 0)
                {
                    MessageBox.Show("Ingrese un valor valido a la cotizacion! (numeros mayores a 0, con/sin punto decimal)");
                    flag = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Recuerde completar el cuadro de cotizacion!");
                flag = false;
            }
            
            if (flag)
            {
                objCompra.Alarmas = DevuelveAlarma();
                objCompra.Balizas = DevuelveBaliza();
                objCompra.Luces = DevuelveLuzNeon();
                objCompra.Soft = DevuelveSoft();
                objCompra.Vidrio = DevuelveVidrio();
                objCompra.vehiculos = objvehiculo;
                MessageBox.Show(objConcesionaria.CalcularPrecio(objCompra, cotizador));
            }
        }
        private Alarma DevuelveAlarma()
        {
            if (cboxAlarma.Checked)
            {
                return new Alarma();
            }
            else
            {
                return null;
            }
        }
        private SoftwareUpdate DevuelveSoft()
        {
            if (cboxSoft.Checked)
            {
                return new SoftwareUpdate();
            }
            else
            {
                return null;
            }
        }
        private Baliza DevuelveBaliza()
        {
            if (cboxBaliza.Checked)
            {
                return new Baliza();
            }
            else
            {
                return null;
            }
        }
        private LuzNeon DevuelveLuzNeon()
        {
            if (cboxNeon.Checked)
            {
                return new LuzNeon();
            }
            else
            {
                return null;
            }
        }
        private Vidrio DevuelveVidrio()
        {
            if (cboxVidrio.Checked)
            {
                return new Vidrio();
            }
            else
            {
                return null;
            }
        }
        private void rbtnAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if (!cmboxAutomoviles.Enabled)
            {
                cmboxAutomoviles.Enabled = true;
                cmboxCamionetas.Enabled = false;
            }
            btnPrecio.Enabled = true;
        }
        private void rbtnCamioneta_CheckedChanged(object sender, EventArgs e)
        {
            if (!cmboxCamionetas.Enabled)
            {
                cmboxCamionetas.Enabled = true;
                cmboxAutomoviles.Enabled = false;
            }
            btnPrecio.Enabled = true;
        }
    }  
}
