using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_Autos
{
    public class Auto
    {
        public Auto()
        {
            
        }
        public Auto(string patente, string marca , string modelo, string anio, decimal precio)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
        }

        public  Persona propietario;
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public decimal Precio { get; set; }

       public Persona GetPersona() { return propietario;}

       public void SetPersona(Persona pPersona)
       {
     
           propietario = pPersona;
       }


    }
}
