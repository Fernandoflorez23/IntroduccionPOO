using System;

namespace EvaluacionSegundoCorte
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = new DateTime(2021, 1, 2);
            DateTime fechaNacimiento1 = new DateTime(1972, 3, 2);

            //string name, string description, DateTime foundationDate
            //string position, int shoot, int defend, int speed, int power, string firstName, string lastName, DateTime birthdayDate
            Album unAlbum = new Album("street", "name", "description");

            Player unPlayer = new Player("DL", 98, 99, 91, 94, "lionel andres", "messi", new DateTime(1987, 6, 24));
            Player dosPlayer = new Player("DL", 92, 92, 91, 93, "Karim", "benzema", new DateTime(1987, 12, 19));
            Player tresPlayer = new Player("DFC", 91, 88, 88, 97, "david", "alaba", new DateTime(1992, 6, 24));
            Player cuatroPlayer = new Player("DL", 92, 72, 91, 93, "Amir", "rrahmani", new DateTime(1994, 2, 24));
            Player cincoPlayer = new Player("DL", 97, 88, 91, 93, "neymar", "junior", new DateTime(1992, 2, 5));
            Player seisPlayer = new Player("DFC", 84, 92, 91, 76, "ben", "Chilwell", new DateTime(1996, 12, 21));
            Coach unCoach = new Coach(inicio, "Mauricio", "Pochetino", fechaNacimiento1);
            Coach dosCoach = new Coach(new DateTime(2021, 6, 24), "Carlo", "Ancelotti", new DateTime(1959, 6, 10));
            Coach tresCoach = new Coach(new DateTime(2021, 9, 23), "luciano", "Spalletti", new DateTime(1959, 3, 7));
            
            unPlayer.setHeight(170);
            dosPlayer.setHeight(187);
            tresPlayer.setHeight(180);
            cuatroPlayer.setHeight(185);
            cincoPlayer.setHeight(175);
            seisPlayer.setHeight(180);
            unCoach.setHeight(181);
            dosCoach.setHeight(179);
            tresCoach.setHeight(168);
            
            Team Psg = new Team("Psg", "Club frances", new DateTime(1970, 6, 12),unPlayer);
            Team RealMadrid = new Team("Real Madrid", "Club Español", new DateTime(1902, 3, 6), dosPlayer);
            Team Napoli = new Team("Napoli", "Club italiano", new DateTime(1926, 11, 29), cuatroPlayer);
            Team Chelsea= new Team("Chelsea", "Club britanico", new DateTime(1905, 2, 10), seisPlayer);
            RealMadrid.agregarPlayer(tresPlayer);
            Psg.agregarPlayer(cincoPlayer);
            Psg.agregarCoach(unCoach);
            RealMadrid.agregarCoach(dosCoach);
            Napoli.agregarCoach(tresCoach);
            Chelsea.agregarCoach(unCoach);

            unAlbum.agregarEquipo(Psg);
            unAlbum.agregarEquipo(RealMadrid);
            unAlbum.agregarEquipo(Napoli);
            unAlbum.agregarEquipo(Chelsea);

            Console.WriteLine("Escoja la opción que desea realizar");
            Console.WriteLine("1 Para empezar con el modo carrera");
            Console.WriteLine("2 Para buscar un jugador por su nombre");
            Console.WriteLine("3 Para buscar un equipo por su nombre");
            Console.WriteLine("4 Para buscar el jugador más viejo");
            Console.WriteLine("5 Para buscar un jugador por joven");
            string opcionSeleccionada = Console.ReadLine();

            switch (opcionSeleccionada)
            {
                case "1":
                    Console.WriteLine("Bienvenido al modo carrera, por favor siga las siguientes " +
                        "instrucciones\nComenzaremos con la creacion de un jugador, escriba la posicion que"+
                        " desea que tenga");
                    string posicionJugador = Console.ReadLine();
                    Console.WriteLine("Escriba una estatura para su jugador");
                    int estaturaPlayer = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el nivel de tiro");
                    int nivelTiro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el nivel de defensa");
                    int nivelDefensa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el nivel de velocidad");
                    int nivelVelocidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba la potencia tiro");
                    int potenciaTiro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el nombre de su jugador");
                    string nombreJugador = Console.ReadLine();
                    Console.WriteLine("Escriba el apeliido de su jugador");
                    string apellidoJugador = Console.ReadLine();
                    Console.WriteLine("Escriba el año de nacimiento de su jugador");
                    int año = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el número del mes de nacimiento de su jugador");
                    int mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el dia de nacimiento de su jugador");
                    int dia = int.Parse(Console.ReadLine());
                    Player playerUsuario = unAlbum.CreatePlayer(posicionJugador, estaturaPlayer, 
                        nivelTiro, nivelDefensa, nivelVelocidad, potenciaTiro, nombreJugador, 
                        apellidoJugador, año,mes,dia);
                    Console.WriteLine("El siguiente paso sera crear un equipo para su jugador," +
                        " escriba el nombre que desea para su equipo");
                    string nombreEquipo = Console.ReadLine();
                    Console.WriteLine("Escriba una breve descripcion para su equipo");
                    string descripcionEquipo = Console.ReadLine();
                    Team playerEquipo = unAlbum.CreateTeam(playerUsuario, nombreEquipo,descripcionEquipo);
                    playerEquipo.agregarPlayer(playerUsuario);
                    Console.WriteLine("Su modo carrera ha sido creada satisfactoriamente \n"+playerEquipo);
                    break;
                case "2":
                    Console.WriteLine("Digite el nombre que desea buscar");
                    string playerSearch = Console.ReadLine();
                    Console.WriteLine(unAlbum.searchPlayerInTeams(playerSearch));
                    break;
                case "3":
                    Console.WriteLine("Digite el nombre del equipo que desea buscar");
                    string teamSearch = Console.ReadLine();
                    Console.WriteLine(unAlbum.searchTeams(teamSearch));
                    break;
                case "4":
                    var oldestPlayer = unAlbum.searchOldestPlayer();
                    if (oldestPlayer != null)
                        Console.Write("Jugador más viejo del Album\n" + oldestPlayer +
                            "\nFecha de nacimiento: " + oldestPlayer.getBirthdayDate() +
                            "\nEdad: " + oldestPlayer.getEdad());
                    break;
                case "5":
                    var youngestPlayer = unAlbum.searchYoungestPlayer();
                    if (youngestPlayer != null)
                        Console.Write("Jugador más joven del Album\n" + youngestPlayer+
                            "\nFecha de nacimiento: " + youngestPlayer.getBirthdayDate() +
                            "\nEdad: " + youngestPlayer.getEdad());
                    break;
                default:
                    Console.WriteLine("Esta opción no existe");
                    break;
            }
        }
    }
}
