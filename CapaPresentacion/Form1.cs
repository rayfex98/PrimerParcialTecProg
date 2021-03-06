using System;
using System.Globalization;
using System.Windows.Forms;
using Vehiculos;
using Vehiculos.Excepciones;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Concesionaria objConcesionaria = new();
        private Vehiculo objvehiculo = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboxAutomoviles.Enabled = false; //dehabilito combobox hasta que elija categoria para vehiculo
            cmboxCamionetas.Enabled = false;
            cmboxAutomoviles.DataSource = objConcesionaria.AutomovilesDisponibles(); //lista de autos
            cmboxAutomoviles.DisplayMember = "Modelo";
            cmboxCamionetas.DataSource = objConcesionaria.CamionetasDisponibles(); //lista de camionetas
            cmboxCamionetas.DisplayMember = "Modelo";
        }
        private void btnCaracteristicas_Click(object sender, EventArgs e) //agrega vehiculo a grilla para comparar caracteristicas con conversion local
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
            dgvVeh.Rows[n].Cells[0].Value = objvehiculo.Modelo; //modelo seleccionado
            dgvVeh.Rows[n].Cells[1].Value = objvehiculo.ARGVelMax(); //velocidad maxima del vehiculo
            dgvVeh.Rows[n].Cells[2].Value = objvehiculo.ARGDistancia(); //distancia recorrida del vehiculo
            dgvVeh.Rows[n].Cells[3].Value = objvehiculo.ARGTanque(); // capacidad del tanque del vehiculo
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            float cotizador; //luego levanto con tboxCotizador
            Compra objCompra = new(); //instancio vehiculo y mejoras
            if (rbtnAutomovil.Checked) //asigno precio de automovil a vehiculo
            {
                objvehiculo = (Vehiculo)(cmboxAutomoviles.SelectedItem);
                Automovil catAuto = new();
                objvehiculo.Categoria = catAuto;
            }
            if (rbtnCamioneta.Checked) //asigno precio de camioneta a vehiculo
            {
                objvehiculo = (Vehiculo)(cmboxCamionetas.SelectedItem);
                Camioneta catCamioneta = new();
                objvehiculo.Categoria = catCamioneta;
            }

            try
            {
                if (objvehiculo.Categoria == null) //sin seleccionar roundbotton de categoria
                {
                    throw new ExcepcionVehiculoVacio();
                }
                if (String.IsNullOrEmpty(tboxCotizador.Text)) //txtbox cotizacion sin llenar
                {
                    throw new ExcepcionCotizacionVacia();
                }
                cotizador = (float.Parse(tboxCotizador.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat)); //cultureinfo toma numeros con coma y punto, lo obtuve de un foro al buscar como levantar un float de precio
                if (cotizador <= 0)
                {
                    throw new ExcepcionCotizacionInvalida();
                }
                objCompra.Alarmas = DevuelveAlarma(); //Mejoras: si el combobox esta chequeado le asigna alarma a la compra, caso contrario devuelve null
                objCompra.Balizas = DevuelveBaliza();
                objCompra.Luces = DevuelveLuzNeon();
                objCompra.Soft = DevuelveSoft();
                objCompra.Vidrio = DevuelveVidrio();
                objCompra.Vehiculos = objvehiculo; //guarda vehiculo seleccionado en cbox
                GrillaVehiculo detalle = new(objCompra, cotizador); //instancio datagridview con detalle del precio y caracteristicas
                detalle.Show(); //muestra el form
            }
            catch (ExcepcionCotizacionVacia ex) //si cotizador queda vacio, genera excepcion
            {
                MessageBox.Show(ex.Descripcion);
            }
            catch(ExcepcionCotizacionInvalida ex) //si numero es 0 o menos, genera excepcion
            {
                MessageBox.Show(ex.Descripcion);
            }
            catch (ExcepcionVehiculoVacio ex) //Vehiculo sin categoria
            {
                MessageBox.Show(ex.Descripcion);
            }
            catch (FormatException)//En la entrega, me olvide contemplar las letras
            {
                MessageBox.Show("No se permiten letras, pruebe con numeros");
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
        private void rbtnAutomovil_CheckedChanged(object sender, EventArgs e) //roundbotton switchea entre la habilitacion de combobox auto/camioneta y habilita el boton para calcular precio
        {
            if (!cmboxAutomoviles.Enabled)
            {
                cmboxAutomoviles.Enabled = true;
                cmboxCamionetas.Enabled = false;
            }
        }
        private void rbtnCamioneta_CheckedChanged(object sender, EventArgs e) //roundbotton switchea entre la habilitacion de combobox auto/camioneta y habilita el boton para calcular precio
        {
            if (!cmboxCamionetas.Enabled)
            {
                cmboxCamionetas.Enabled = true;
                cmboxAutomoviles.Enabled = false;
            }
        }
    }  
}
