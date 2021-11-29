using System;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Location locationUnZoo = new Location("Tunja", "Boyacá", "Colombia");
            Zoo unZoo = new Zoo("TunZoo","description",new DateTime(2015,7,23),locationUnZoo);
            Veterinary unVeterinary = new Veterinary("Rosario", "Fishes", "fernando", "florez", new DateTime(2003, 9, 23), new DateTime(2021, 1, 30), 1500);
            GeneralDirector unGeneralDirector = new GeneralDirector("Santo Tómas", "Cristian", "Galvis", new DateTime(2003, 9, 23), new DateTime(2021, 1, 30), 2000);
            Frog unFrog = new Frog("Naveen", "flies", "Land or Water", "bufo", new DateTime(2021, 1, 25));
            Console.WriteLine(unVeterinary);
            unZoo.addEmployee(unVeterinary);
            unZoo.addEmployee(unGeneralDirector);
            Console.WriteLine(unFrog.swim());
        }
    }
}
