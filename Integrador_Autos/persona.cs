using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Autos
{
    public class persona
    {
        public persona()
        {
            
        }
        public persona(string dni,string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<auto> Autos_Propios { get; set; }

        public List<auto> Lista_de_autos()
        {
           
            return Autos_Propios;
        }

        public int Cantidad_de_Autos()
        {
            return Autos_Propios.Count;
        }

        public override string ToString()
        {
            return Nombre + Apellido;
        }

        ~persona()
        {

        }
    }
}
