// See https://aka.ms/new-console-template for more information
using Ejercicio_Herencia_Persona;

Console.WriteLine("Ejercicio Persona");
Console.WriteLine();

//Menu de opciones
Console.WriteLine("Menu de opciones");
Console.WriteLine();

{
    bool programaAbierto = true;

    while (programaAbierto)
    {
        MostrarMenu();
        string opcion = Console.ReadLine();

        switch (opcion.ToLower())
        {
            case "1":
                Console.WriteLine("Usted acaba de ingresar a la opcion Profesor");
                Console.WriteLine();
                Profesor profesor = new Profesor();
                Console.WriteLine("\nIngrese los datos del profesor:");
                Console.Write("Nombre: ");
                profesor.Nombre = Console.ReadLine();
                Console.Write("Direccion: ");
                profesor.Direccion = Console.ReadLine();
                Console.Write("Correo: ");
                profesor.Correo = Console.ReadLine();
                Console.Write("Asignatura: ");
                profesor.Asignatura = Console.ReadLine();

                Console.WriteLine("¿Deseas cerrar el programa? (si/no): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                    Console.WriteLine("Ingresa mas datos...");

                    Console.WriteLine("\nIngrese los datos del profesor:");
                    Console.Write("Nombre: ");
                    profesor.Nombre = Console.ReadLine();
                    Console.Write("Direccion: ");
                    profesor.Direccion = Console.ReadLine();
                    Console.Write("Correo: ");
                    profesor.Correo = Console.ReadLine();
                    Console.Write("Asignatura: ");
                    profesor.Asignatura = Console.ReadLine();


                    programaAbierto = false;
                }
                else if (respuesta == "no")
                {
                    Console.WriteLine("Volviendo al menú principal...");
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Volviendo al menú principal...");
                }
                break;

            case "2":
                Console.WriteLine("Usted acaba de ingresar a la opcion Estudiante");
                Console.WriteLine();
                Estudiante estudiante = new Estudiante();
                Console.WriteLine("Ingrese los datos del estudiante:");
                Console.Write("Nombre: ");
                estudiante.Nombre = Console.ReadLine();
                Console.Write("Direccion: ");
                estudiante.Direccion = Console.ReadLine();
                Console.Write("Correo: ");
                estudiante.Correo = Console.ReadLine();
                Console.Write("Carrera: ");
                estudiante.Carrera = Console.ReadLine();
               
                Console.WriteLine("¿Deseas cerrar el programa? (si/no): ");
                string resultado = Console.ReadLine().ToLower();

                if (resultado== "si")
                {
                    Console.WriteLine("Ingresa mas datos...");

                    Console.WriteLine("Ingrese los datos del estudiante:");
                    Console.Write("Nombre: ");
                    estudiante.Nombre = Console.ReadLine();
                    Console.Write("Direccion: ");
                    estudiante.Direccion = Console.ReadLine();
                    Console.Write("Correo: ");
                    estudiante.Correo = Console.ReadLine();
                    Console.Write("Carrera: ");
                    estudiante.Carrera = Console.ReadLine();

                    programaAbierto = false;
                }
                else if (resultado == "no")
                {
                    Console.WriteLine("Volviendo al menú principal");
                }
                else
                {
                    Console.WriteLine("Respuesta no valida. Intentalo de nuevo");
                }
                break;

            default:
                Console.WriteLine("Cerrando el programa.");
                break;
        }
    }
}

static void MostrarMenu()
{
    Console.WriteLine("Menú Principal:");
    Console.WriteLine("1. Profesor");
    Console.WriteLine("2. Estudiante");
    Console.Write("Elige una opción (1 o 2): ");
}