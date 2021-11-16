using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Album
    {
        private string Street;
        private string name;
        private string description;
        private Team[] teams= new Team[10];
        public Album(string street, string name, string description)
        {
            this.Street = street;
            this.name = name;
            this.description = description;
        }
        public void agregarEquipo(Team unTeam)
        {
            int posicion = 0;
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i] == null)
                    break;
                posicion++;
            }
            teams[posicion] = unTeam;
        }
        public Player CreatePlayer(string posicionJugador, int estaturaPlayer, int nivelTiro, int nivelDefensa, int nivelVelocidad,
                int potenciaTiro, string nombreJugador, string apellidoJugador, int año, int mes, int dia)
        {
            Player playerUsuario= new Player(posicionJugador,nivelTiro,nivelDefensa,nivelVelocidad,
                potenciaTiro,nombreJugador,apellidoJugador,new DateTime(año,mes,dia));
            playerUsuario.setHeight(estaturaPlayer);
            return playerUsuario;
        }
        public Team CreateTeam(Player playerUsuario, string nombreEquipo, string descripcionEquipo)
        {
            Team playerEquipo = new Team(nombreEquipo, descripcionEquipo, DateTime.Now, playerUsuario);
            return playerEquipo;
        }
        public string searchPlayerInTeams(string name)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i] == null)
                    break;
                var player = teams[i].searchPlayerByName(name);
                if (player != null)
                    return "¡Jugador encontrado!\n" + player + "\nEquipo: " + teams[i].getName();
            }
            return "No se encontró ningún jugador";
        }
        public string searchTeams(string name)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i] == null)
                    break;
                if (teams[i].getName().Equals(name))
                {
                    return "¡Equipo encontrado!\n" + teams[i];
                }
            }
            return "No se encontró el equipo";
        }
        public Player searchOldestPlayer()
        {
            Player player3=null;
            for (int i = 1; i < teams.Length; i++)
            {
                var player1 = teams[i - 1].searchOldestPlayer();
                if (teams[i] == null)
                    return player1;
                if (teams[i + 1] == null)
                    break;
                var player2 = teams[i].searchOldestPlayer();
                if (player1.getBirthdayDate() < player2.getBirthdayDate()&&i==1)
                    player3 = player1;
                else if(i==1)
                    player3 = player2;
                if (player2.getBirthdayDate() < player3.getBirthdayDate()&&i!=1)
                    player3 = player2;
                player1 = teams[i+1].searchOldestPlayer();
                if (player1.getBirthdayDate() < player3.getBirthdayDate())
                    player3 = player1;
            }
            return player3;
        }
        public Player searchYoungestPlayer()
        {
            Player player3=null;
            for (int i = 1; i < teams.Length; i++)
            {
                var player1 = teams[i - 1].searchYoungestPlayer();
                if (teams[i] == null)
                    return player1;
                if (teams[i + 1] == null)
                    break;
                var player2 = teams[i].searchYoungestPlayer();
                if (player1.getBirthdayDate() > player2.getBirthdayDate()&&i==1)
                    player3 = player1;
                else if(i==1)
                    player3 = player2;
                if (player2.getBirthdayDate() > player3.getBirthdayDate() && i != 1)
                    player3 = player2;
                player1 = teams[i+1].searchYoungestPlayer();
                if (player1.getBirthdayDate() > player3.getBirthdayDate())
                    player3 = player1;
            }
            return player3;
        }
        public override string ToString()
        {
            return "Nombre: "+teams[0];
        }
        public Team[] getTeams()
        {
            return this.teams;
        }
    }
}