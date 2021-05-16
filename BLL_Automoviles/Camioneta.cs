using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Camioneta : Vehiculo
    {
        public override float DevolverPrecio()
        {
            return 150000;
        }
        public Camioneta()
        {
            this.Categoria = "Camioneta";
        }
    }
}
