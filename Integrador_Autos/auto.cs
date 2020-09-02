using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Autos
{
    public class auto
    {
        public auto()
        {
            
        }
        public auto(string patente, string marca , string modelo, string anio, decimal precio)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
        }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }

        public persona propietario { get; set; }
        public persona Propietario()
        {
           
            return null;
        }

        public override string ToString()
        {
            return Patente + Propietario();
        }

        ~auto()
        {

        }

    }
}
