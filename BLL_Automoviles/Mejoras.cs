using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Mejoras
    {
        private int _softUpdate = 1500;
        private int _alarma = 5000;
        private int _vidrio = 1500;
        private int _baliza = 1000;
        private int _luzNeon = 7500;

        public int SoftUPdate
        {
            get { return _softUpdate; }
        }
        public int Alarma
        {
            get { return _alarma; }
            set { _alarma = value; }
        }
        public int Vidrio
        {
            get { return _vidrio; }
            set { _vidrio = value; }
        }
        public int Baliza
        {
            get { return _baliza; }
            set { _baliza = value; }
        }
        public int LuzNeon
        {
            get { return _luzNeon; }
            set { _luzNeon = value; }
        }
    }
}
