using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class GeneralDirector:Employee
    {
        private string university;
        public GeneralDirector(string university,string firstName, string lastName, DateTime birthDate, DateTime startDate, double salary) : base(firstName, lastName, birthDate, startDate, salary)
        {
            this.university = university;
        }
    }
}
