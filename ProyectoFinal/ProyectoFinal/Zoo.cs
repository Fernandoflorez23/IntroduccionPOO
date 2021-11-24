using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Zoo
    {
        private string name;
        private string description;
        private DateTime foundationDate;
        private Location location;
        private Animal[] animals = new Animal[20];
        private Veterinary[] veterinaries= new Veterinary[4];
        private GeneralDirector[] generalDirectors= new GeneralDirector[1];

        public Zoo(string name,string description,DateTime foundationDate,Location location)
        {
            this.name = name;
            this.description = description;
            this.foundationDate = foundationDate;
            this.location = location;
        }
        public void addAnimal(Animal oneAnimal)
        {
            int position = 0;
            for(int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                    break;
                    position++;
            }
            animals[position] = oneAnimal;
        }
        public void addEmployee(Employee oneEmployee)
        {
            int position = 0;
            if (oneEmployee.GetType().Name.Equals("Veterinary"))
            {
                for(int i = 0; i < veterinaries.Length; i++)
                {
                    if (veterinaries[i] == null)
                        break;
                    position++;
                }
                var oneVeterinary = (Veterinary)oneEmployee;
                veterinaries[position] = oneVeterinary;
            }
            else
            {
                for (int i = 0; i < generalDirectors.Length; i++)
                {
                    if (generalDirectors[i] == null)
                        break;
                    position++;
                }
                var oneGeneralDirector= (GeneralDirector)oneEmployee;
                generalDirectors[position] = oneGeneralDirector;
            }
        }
        public override string ToString()
        {
            return "Employee: "+veterinaries[0]+"\n"+generalDirectors[0];
        }
    }
}
