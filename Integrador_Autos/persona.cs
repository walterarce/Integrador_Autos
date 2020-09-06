using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Autos
{
    public class Persona
    {
        public Persona()
        {
            
        }
        List<Auto> Autos_Propios;
        public Persona(string dni,string nombre, string apellido)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Autos_Propios = new List<Auto>();
        }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

       

        public void Agregar_Auto(Auto car)
        {
            try
            {
                if (car.GetPersona() == null)
                {
                    Autos_Propios.Add(new Auto(car.Patente,car.Marca,car.Modelo,car.Anio,car.Precio));
                    Autos_Propios.Last<Auto>().SetPersona(this);
                  car.SetPersona(this);
                }
                else
                {
                    throw new Exception("Ya fue asignado");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        public void Eliminar_auto(Auto car)
        {
            int contara = 0;
            try
            {
                foreach (var autosPropio in Autos_Propios)
                {
                    if (car.Patente == autosPropio.Patente)
                    {
                        Autos_Propios.RemoveAt(contara);
                    }

                    contara++;
                }

            }
            catch (Exception )
            {
                
            }
        }

        public List<Auto> RetornarAutos()
        {
            List<Auto> listaAutos = new List<Auto>();
            foreach (var autos in Autos_Propios)
            {
              listaAutos.Add(new Auto(autos.Patente,autos.Marca,autos.Modelo,autos.Anio,autos.Precio));   
            }
            return listaAutos;
        }


    }
}
