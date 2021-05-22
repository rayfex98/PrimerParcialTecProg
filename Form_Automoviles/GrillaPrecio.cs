using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BLL_Automoviles;
using System.Windows.Forms;

namespace Form_Automoviles
{
    public partial class GrillaPrecio : Form
    {
        Compra objCompra;
        float cotizacion;
        public GrillaPrecio(Compra compra, float cotizador)
        {
            objCompra = compra;
            cotizacion = cotizador;
            InitializeComponent();
        }

        private void GrillaPrecio_Load(object sender, EventArgs e)
        {
            float precioMejoras = 0, precioFinal;
            precioFinal = objCompra.Vehiculos.Categoria.DevolverPrecio(cotizacion);
            int n = dgvPrecio.Rows.Add(); //agrego 9 columnas
            dgvPrecio.Rows[n].Cells[0].Value = objCompra.Vehiculos.Modelo; //modelo
            dgvPrecio.Rows[n].Cells[1].Value = precioFinal; //precioVehiculo
            //si el checkbox no estaba habilitado devolvia null, entonces muestro un 0. Si esta habilitado procedo a mostrar en grilla y acumular las mejoras (aplica a los if de abajo)
            if (objCompra.Soft != null) 
            {
                precioMejoras += objCompra.Soft.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[2].Value = objCompra.Soft.DevolverCosto(cotizacion); //Actualizacion de Software
            }
            else
            {
                dgvPrecio.Rows[n].Cells[2].Value = 0;
            }

            if (objCompra.Alarmas != null)
            {
                precioMejoras += objCompra.Alarmas.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[3].Value = objCompra.Alarmas.DevolverCosto(cotizacion); //Alarma
            }
            else
            {
                dgvPrecio.Rows[n].Cells[4].Value = 0;
            }

            if (objCompra.Vidrio != null)
            {
                precioMejoras += objCompra.Vidrio.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[4].Value = objCompra.Vidrio.DevolverCosto(cotizacion); //Vidrio
            }
            else
            {
                dgvPrecio.Rows[n].Cells[4].Value = 0;
            }

            if (objCompra.Balizas != null)
            {
                precioMejoras += objCompra.Balizas.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[5].Value = objCompra.Balizas.DevolverCosto(cotizacion); //Baliza
            }
            else
            {
                dgvPrecio.Rows[n].Cells[5].Value = 0;
            }

            if (objCompra.Luces != null)
            {
                precioMejoras += objCompra.Luces.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[6].Value = objCompra.Luces.DevolverCosto(cotizacion); //Luces de neón
            }
            else
            {
                dgvPrecio.Rows[n].Cells[6].Value = 0;
            }
            dgvPrecio.Rows[n].Cells[7].Value = precioMejoras; //Total Mejoras
            precioFinal += precioMejoras; 
            dgvPrecio.Rows[n].Cells[8].Value = precioFinal; //Precio Final
        }
    }
}
