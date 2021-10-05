using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int id, string nombre, char genero, string oficio, DateTime fechaNacimiento, DateTime fechaDeMuerte
            Aldea unaAldea = new Aldea("La aldea", "America");
            int totalAldeanos = 0;
            int totalGuerreros = 0;
            int veces = 0;
            string nombreConsulta;
            Console.WriteLine("Digite el nombre de su consulta");
            nombreConsulta = Console.ReadLine();

            for (int i = 0; i < 100; i++)
            {
                Habitante unhabitante = Spawner.generarNuevoHabitante();
                unaAldea.RecibirHabitante(unhabitante);
                Console.WriteLine(unhabitante);
                veces+=Habitante.ContadorNombresRepetidos(unhabitante.Nombre,nombreConsulta);

                if (unhabitante.Oficio.Equals("Guerrero"))
                {
                    Console.WriteLine("Soy un Guerrero");
                    totalGuerreros++;
                }
                else
                {
                    Console.WriteLine("Soy un Aldeano");
                    totalAldeanos++;
                }
            }
            Console.WriteLine("\nTotal de Guerreros: "+totalGuerreros+" Total de Aldeanos: " +totalAldeanos);
            Console.WriteLine("El nombre "+nombreConsulta+" esta repetido "+veces+" veces");
        }
    }
}
