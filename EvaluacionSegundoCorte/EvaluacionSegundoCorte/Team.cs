using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Team
    {
        private string name;
        private string description;
        private DateTime foundationDate;
        private Player[] players = new Player[10];
        private Coach[] coach = new Coach[1];
        public Team(string name, string description, DateTime foundationDate, Player unplayer)
        {
            this.name = name;
            this.description = description;
            this.foundationDate = foundationDate;
            this.players[0] = unplayer;
        }
        public void agregarPlayer(Player unPlayer)
        {
            int posicion = 0;
            for(int i = 0; i < players.Length; i++)
            {
                if (players[i] == null)
                    break;
                posicion++;
            }
            players[posicion] = unPlayer;
        }
        public void agregarCoach(Coach unCoach)
        {
            coach[0] = unCoach;
        }
        public Player searchPlayerByName(string firstname)
        {
            for(int i = 0; i < this.players.Length; i++)
            {
                if (players[i] == null)
                    break;
                if (firstname.Equals(players[i].getFirstName()))
                    return players[i];
                //Console.WriteLine(players[i]);
            }
            return null;
        }
        public Player searchOldestPlayer()
        {
            for(int i = 0; i < this.players.Length; i++)
            {
                if (players[i+1]==null)
                    break;
                if (players[i].getBirthdayDate() < players[i + 1].getBirthdayDate())
                    return players[i];
                else
                    return players[i + 1];
            }
            return players[0];
        }
        public Player searchYoungestPlayer()
        {
            for (int i = 0; i < this.players.Length; i++)
            {
                if (players[i + 1] == null)
                    break;
                if (players[i].getBirthdayDate() > players[i + 1].getBirthdayDate())
                    return players[i];
                else
                    return players[i + 1];
            }
            return players[0];
        }
        public override string ToString()
        {
            return "Nombre del equipo: "+name+"\nDescripcion del equipo: "+description+
                "\nFecha de fundación: "+getFoundationDate()+"\nPrimerJugador\n"+players[0]+
                "\nTecnico\n"+coach[0];
        }
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getFoundationDate()
        {
            return foundationDate.ToString("dd")+" de "+foundationDate.ToString("MMMM yyyy");
        }

        public void setFoundationDate(DateTime foundationDate)
        {
            this.foundationDate = foundationDate;
        }
        public Player[] getPlayers()
        {
            return this.players;
        }
    }
}
