using System;

namespace BLL_Automoviles
{
    public class Compra
    {
        Vehiculo _vehiculo;
        public Vehiculo Vehiculos
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        private Alarma _alarma;
        public Alarma Alarmas
        {
            get { return _alarma; }
            set { _alarma = value; }
        }

        private Baliza _baliza;
        public Baliza Balizas
        {
            get { return _baliza; }
            set { _baliza = value; }
        }

        private LuzNeon _luzneon;
        public LuzNeon Luces
        {
            get { return _luzneon; }
            set { _luzneon = value; }
        }

        private SoftwareUpdate _soft;
        public SoftwareUpdate Soft
        {
            get { return _soft; }
            set { _soft = value; }

        }

        private Vidrio _vidrio;
        public Vidrio Vidrio
        {
            get { return _vidrio; }
            set { _vidrio = value; }
        }

    }
}