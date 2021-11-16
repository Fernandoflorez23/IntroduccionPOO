using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Coach : Person
    {
        private DateTime startDate;
        private DateTime endDate;
        private int trayectory;
        public Coach(DateTime startDate, string firstName, string lastName, DateTime birthdayDate) : base(firstName, lastName, birthdayDate)
        {
            this.startDate = startDate;
        }
        public int getTime()
        {
            int duracionContrato = endDate.Year - startDate.Year;
            return duracionContrato;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }
        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }
        public DateTime getEndDate()
        {
            return this.endDate;
        }
        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public int getTrayectory()
        {
            return this.trayectory;
        }
        public void setTrayectory(int trayectory)
        {
            this.trayectory = trayectory;
        }
    }
}
