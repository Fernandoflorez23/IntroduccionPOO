using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Person
    {
        private string firstName;
        private string lastName;
        private double height;
        private string path;
        private DateTime birthdayDate;

        public Person(string firstName, string lastName, DateTime birthdayDate)
        {
            setFirstName(firstName);
            setLastName(lastName);
            this.birthdayDate = birthdayDate;
        }
        /*Métodos*/
        public int getEdad()
        {
            int currentYear = DateTime.Now.Year;
            int year = birthdayDate.Year;
            return currentYear - year;
        }
        public string getFullName()
        {
            string fullName = getFirstName() +" "+getLastName();
            return fullName;
        }
        public override string ToString()
        {
            return "Nombre: "+this.firstName+"\nApellido: "+this.lastName+ "\nEdad: "+getEdad()+"\nAltura: "+
                this.height+"cm";
        }
        /*gets y sets*/
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
        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double height)
        {
            if (height < 140)
                height = 170;
            this.height = height;
        }
        public string getPath()
        {
            return this.path;
        }
        public void setPath(string path)
        {
            this.path = path;
        }
        public DateTime getBirthdayDate()
        {
            return this.birthdayDate;
        }
        public void setBirthdayDate(DateTime birthdayDate)
        {
            this.birthdayDate = birthdayDate;
        }
    }
}
