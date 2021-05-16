using System;

namespace BLL_Automoviles
{
    public class Mejoras
    {
        private float _softUpdate;
        private float _alarma;
        private float _vidrio;
        private float _baliza;
        private float _luzNeon;

        
        public float SoftUpdate
        {
            get { return _softUpdate; }
            set { _softUpdate = value; }
        }
        public float Alarma
        {
            get { return _alarma; }
            set { _alarma = value; }
        }
        public float Vidrio
        {
            get { return _vidrio; }
            set { _vidrio = value; }
        }
        public float Baliza
        {
            get { return _baliza; }
            set { _baliza = value; }
        }
        public float LuzNeon
        {
            get { return _luzNeon; }
            set { _luzNeon = value; }
        }
        public float ARGSoft(float _cotizacion)
        {
            return _softUpdate * _cotizacion;
        } 
    }
}
