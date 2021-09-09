using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico
{
    public class Omnibus : TransportePublico
    {
        
        public Omnibus(int cantidadDePasajeros,string nombre) : base(cantidadDePasajeros, nombre)
        {

        }

        public override string Avanzar()
        {
            return $"Avanza el omnibus ";
        }

        public override string Detenerse()
        {
            return base.Detenerse();
        }
    }
}
