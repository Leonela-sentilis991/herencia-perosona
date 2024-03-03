using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia_Persona
{
     class Profesor:Persona
    {
        public string Asignatura { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"Asignatura: {Asignatura}");
        }

    }
}
