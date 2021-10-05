using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //int id, string nombre, char genero, string oficio, DateTime fechaNacimiento, DateTime fechaDeMuerte
            Aldea unaAldea = new Aldea("La aldea", "America");
            int totalGuerreros = 0;
            int totalAldeanos = 0;

            for (int i = 0; i < 100; i++)
            {
                Habitante unhabitante = Spawner.generarNuevoHabitante();

                unaAldea.RecibirHabitante(unhabitante);
                Console.WriteLine(unhabitante);

            }

            Console.WriteLine("Digite el nombre de su consulta");
            string nombreConsulta = Console.ReadLine();
            var veces = unaAldea.contarHabitantesPorNombre(nombreConsulta);
            unaAldea.contarGuerrerosyAldeanos();

            totalGuerreros = unaAldea.getTotalGuerreros();
            totalAldeanos = unaAldea.getTotalAldeanos();
            Console.WriteLine("\nTotal de Guerreros: "+totalGuerreros+" Total de Aldeanos: " +totalAldeanos);
            Console.WriteLine("El nombre "+nombreConsulta+" esta repetido "+veces+" veces");
        }
    }
}
