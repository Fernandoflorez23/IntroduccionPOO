using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProyectoFinal
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private DateTime startDate;
        private double salary;
        public Employee(string firstName, string lastName, DateTime birthDate, DateTime startDate, double salary)
        {
            setFirstName(firstName);
            setLastName(lastName);
            this.birthDate = birthDate;
            this.startDate = startDate;
            this.salary = salary;
        }
        public string getFullName()
        {
            string fullName = getFirstName() + " " + getLastName();
            return fullName;
        }
        public int getEdad()
        {
            int currentYear = DateTime.Now.Year;
            int year = getBirthDate().Year;
            return currentYear - year;
        }
        public override string ToString()
        {
            return "Nombre: "+getFullName()+"\nEdad: "+getEdad()+"\nSalario: "+getSalary();
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(firstName);
        }
        public string getLastName()
        {
            return this.lastName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(lastName);
        }
        public DateTime getBirthDate()
        {
            return this.birthDate;
        }
        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }
        public DateTime getStartDate()
        {
            return this.startDate;
        }
        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public double getSalary()
        {
            return this.salary;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
    }
    class Veterinary : Employee
    {
        private string university;
        private string specialty;
        public Veterinary(string university, string specialty, string firstName, string lastName, DateTime birthDate, DateTime startDate, double salary) : base(firstName, lastName, birthDate, startDate, salary)
        {
            this.university = university;
            this.specialty = specialty;
        }
        public override string ToString()
        {
            return "Nombre: " + getFullName() + "\nEdad: " + getEdad() + "\nSalario: " + getSalary()+"\nUniversity:"+this.university;
        }
    }
    class GeneralDirector : Employee
    {
        private string university;
        public GeneralDirector(string university, string firstName, string lastName, DateTime birthDate, DateTime startDate, double salary) : base(firstName, lastName, birthDate, startDate, salary)
        {
            this.university = university;
        }
    }
}
