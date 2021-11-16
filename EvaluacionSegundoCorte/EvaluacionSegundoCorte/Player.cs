using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Player : Person
    {
        private string position;
        private int shoot;
        private int defend;
        private int speed;
        private int power;
        public Player(string position, int shoot, int defend, int speed, int power, string firstName, string lastName, DateTime birthdayDate) : base(firstName, lastName, birthdayDate)
        {
            this.position = position;
            this.shoot = shoot;
            this.defend = defend;
            this.speed = speed;
            this.power = power;
        }
        public string longPass()
        {
            string tipoPase = "Estoy haciendo un pase largo";
            return tipoPase;
        }
        public string shortPass()
        {
            string tipoPase = "Estoy haciendo un pase corto";
            return tipoPase;
        }
        public string shooting()
        {
            string tipoAccion = "Estoy pateando al arco";
            return tipoAccion;
        }
        public string getPosition()
        {
            return this.position;
        }
        public void setPosition(string position)
        {
            this.position = position;
        }
        public int getShoot()
        {
            return this.shoot;
        }
        public void setShoot(int shoot)
        {
            this.shoot = shoot;
        }
        public int getDefend()
        {
            return this.defend;
        }
        public void setDefend(int defend)
        {
            this.defend = defend;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public int getPower()
        {
            return this.power;
        }
        public void setPower(int power)
        {
            this.power = power;
        }
    }
}
