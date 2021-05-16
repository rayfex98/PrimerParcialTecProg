using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Automoviles
{
    public class Camioneta : Categoria
    {
        public override float DevolverPrecio(float cotizacion)
        {
            return 150000 * cotizacion;
        }
        public Camioneta()
        {
            this.Nombre = "Camioneta";
        }
    }
}
