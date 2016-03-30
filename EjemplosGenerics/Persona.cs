using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosGenerics
{
    public class Persona
    {
        public string Nombre { get; private set; }
        public Persona()
        {

        }
        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
