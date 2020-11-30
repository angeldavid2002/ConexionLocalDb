using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string  identificacion { get; set; }
        public string nombre { get; set; }
        public double peso { get; set; }

        public Persona()
        {

        }
        public Persona(string identificacion, string nombre, double peso)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.peso = peso;
        }
    }
}
