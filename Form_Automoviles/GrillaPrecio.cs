using System;
using Vehiculos;
using System.Windows.Forms;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class GrillaVehiculo : Form
    {
        Compra objCompra;
        float cotizacion;
        public GrillaVehiculo(Compra compra, float cotizador)
        {
            objCompra = compra;
            cotizacion = cotizador;
            InitializeComponent();
        }

        private void GrillaPrecio_Load(object sender, EventArgs e)
        {
            float precioMejoras = 0, precioFinal;
            precioFinal = objCompra.Vehiculos.Categoria.DevolverPrecio(cotizacion);
            CultureInfo argentina = new("es-ar"); //formato moneda argentina para la grilla
            int n = dgvPrecio.Rows.Add();
            dgvPrecio.Rows[n].Cells[0].Value = objCompra.Vehiculos.Modelo; //modelo
            dgvPrecio.Rows[n].Cells[1].Value = precioFinal.ToString("C", argentina); //precioVehiculo
            //si el checkbox no estaba habilitado devolvia null, entonces muestro un 0. Si esta habilitado muestro en grilla y acumulo las mejoras (aplica a los if de abajo)
            if (objCompra.Soft != null)
            {
                precioMejoras += objCompra.Soft.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[2].Value = (objCompra.Soft.DevolverCosto(cotizacion)).ToString("C", argentina); //Actualizacion de Software
            }
            else
            {
                dgvPrecio.Rows[n].Cells[2].Value = 0;
            }

            if (objCompra.Alarmas != null)
            {
                precioMejoras += objCompra.Alarmas.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[3].Value = (objCompra.Alarmas.DevolverCosto(cotizacion)).ToString("C", argentina); //Alarma
            }
            else
            {
                dgvPrecio.Rows[n].Cells[4].Value = 0;
            }

            if (objCompra.Vidrio != null)
            {
                precioMejoras += objCompra.Vidrio.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[4].Value = (objCompra.Vidrio.DevolverCosto(cotizacion)).ToString("C", argentina); //Vidrio
            }
            else
            {
                dgvPrecio.Rows[n].Cells[4].Value = 0;
            }

            if (objCompra.Balizas != null)
            {
                precioMejoras += objCompra.Balizas.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[5].Value = (objCompra.Balizas.DevolverCosto(cotizacion)).ToString("C", argentina); //Baliza
            }
            else
            {
                dgvPrecio.Rows[n].Cells[5].Value = 0;
            }

            if (objCompra.Luces != null)
            {
                precioMejoras += objCompra.Luces.DevolverCosto(cotizacion);
                dgvPrecio.Rows[n].Cells[6].Value = (objCompra.Luces.DevolverCosto(cotizacion)).ToString("C", argentina); //Luces de neón
            }
            else
            {
                dgvPrecio.Rows[n].Cells[6].Value = 0;
            }
            dgvPrecio.Rows[n].Cells[7].Value = precioMejoras.ToString("C", argentina); //Total Mejoras
            precioFinal += precioMejoras;
            dgvPrecio.Rows[n].Cells[8].Value = precioFinal.ToString("C", argentina); //Precio Final

            int m = dgvCaracteristicas.Rows.Add(); //datagrid de caracteristicas con conversion local
            dgvCaracteristicas.Rows[m].Cells[0].Value = objCompra.Vehiculos.Modelo; //Modelo del vehiculo
            dgvCaracteristicas.Rows[m].Cells[1].Value = objCompra.Vehiculos.ARGVelMax();//Velocidad Maxima en K/h
            dgvCaracteristicas.Rows[m].Cells[2].Value = objCompra.Vehiculos.ARGDistancia(); //Distancia Recorrida en km
            dgvCaracteristicas.Rows[m].Cells[3].Value = objCompra.Vehiculos.ARGTanque(); //Capacidad de tanque en Litros
        }
    }
}
