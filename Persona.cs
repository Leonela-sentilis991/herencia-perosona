using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia_Persona
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Correo: {Correo}");
        }
    }

}