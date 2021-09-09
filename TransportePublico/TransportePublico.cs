using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePublico
{
    public abstract class TransportePublico
    {
        private int pasajeros;
        private string nombre;

        public int Pasajeros
        { 
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public TransportePublico(int cantidadDePasajeros,string nombre)
        {
            this.pasajeros = cantidadDePasajeros;
            this.nombre = nombre;
        }

        public virtual string Avanzar()
        {
            return $"Avanza!";
        }

        public virtual string Detenerse()
        {
            return $"Se detiene! pueden bajar pasajeros...";
        }
    }
}
