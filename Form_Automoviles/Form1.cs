using System;
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

        private Concesionaria objConcesionaria = new();
        private Vehiculo objvehiculo = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrecio.Enabled = false; //para que no pueda calcular sin tener un vehiculo seleccionado
            cmboxAutomoviles.Enabled = false; //dehabilito combobox hasta que elija vehiculo
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
            float cotizador = 0; //luego levanto con tboxCotizador
            bool flag = true; //solo si ingreso todos los datos, se calcula
            Compra objCompra = new(); //obtiene vehiculo y mejoras
            if (rbtnAutomovil.Checked) //asigno precio de automovil
            {
                objvehiculo = (Vehiculo)(cmboxAutomoviles.SelectedItem);
                Automovil catAuto = new();
                objvehiculo.Categoria = catAuto;
            }
            if (rbtnCamioneta.Checked) //asigno precio de camioneta
            {
                objvehiculo = (Vehiculo)(cmboxCamionetas.SelectedItem);
                Camioneta catCamioneta = new();
                objvehiculo.Categoria = catCamioneta;
            }

            try
            {
                cotizador = (float.Parse(tboxCotizador.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat)); //cultureinfo toma numeros con coma y punto, lo obtuve de un foro al buscar como levantar un float de precio
                if (cotizador <= 0)
                {
                    MessageBox.Show("Ingrese un valor valido a la cotizacion! (numeros mayores a 0, con/sin punto decimal)");
                    flag = false;
                }
            }
            catch (FormatException) //si cotizador queda vacio genera excepcion
            {
                MessageBox.Show("Recuerde completar el cuadro de cotizacion!");
                flag = false;
            }
            if (flag)
            {
                objCompra.Alarmas = DevuelveAlarma(); //Mejora: si el combobox esta chequeado le asigna alarma a la compra, caso contrario devuelve null
                objCompra.Balizas = DevuelveBaliza(); //Mejora
                objCompra.Luces = DevuelveLuzNeon(); //Mejora
                objCompra.Soft = DevuelveSoft(); //Mejora
                objCompra.Vidrio = DevuelveVidrio(); //Mejora
                objCompra.Vehiculos = objvehiculo; //guarda vehiculo seleccionado
                GrillaPrecio detalle = new(objCompra, cotizador); //Form de datagridview
                detalle.Show(); //muestra el form
                //MessageBox.Show(Concesionaria.CalcularPrecio(objCompra, cotizador)); //muestra detalle del precio con una ventana
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
            if(!btnPrecio.Enabled) btnPrecio.Enabled = true;
        }
        private void rbtnCamioneta_CheckedChanged(object sender, EventArgs e) //roundbotton switchea entre la habilitacion de combobox auto/camioneta y habilita el boton para calcular precio
        {
            if (!cmboxCamionetas.Enabled)
            {
                cmboxCamionetas.Enabled = true;
                cmboxAutomoviles.Enabled = false;
            }
            if(!btnPrecio.Enabled) btnPrecio.Enabled = true;
        }
    }  
}
