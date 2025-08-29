using JuegoTurno.Model;
using System.Collections;

namespace JuegoTurno
{
    internal class Program
    {


        private static ArrayList ArrayPersonajes = new ArrayList();
        static void Main(string[] args)
        {
            //ejecutarMenu();
            crearPersonajes();

        }
        private static void crearPersonajes()
        {

            //Habilidades de personajes
            Habilidad ataqueEspada = new Habilidad("AtaqueEspada", 10, "Un ataque poderoso que inflige daño adicional.");
            Habilidad OndaCoque = new Habilidad("OndaCoque", 15, "Una onda de choque que aturde al enemigo.");
            Habilidad Curacion = new Habilidad("Curacion", 10, "Restaura una cantidad significativa de vida.");
            Habilidad GolpeElectrico = new Habilidad("GolpeElectrico", 15, "Un ataque electrizante que puede paralizar al enemigo.");
            Habilidad Flecha = new Habilidad("FlechaExplosiva", 10, "Una flecha que causa daño al enemigo.");
            Habilidad FlechaTripls = new Habilidad("FlechaTriple", 15, "Dispara tres flechas a la vez.");

            //Habilidades de unicas de cada raza
            Habilidad VelocidadGolpe = new Habilidad("VelocidadGolpe", 20, "Aumenta la velocidad de ataque temporalmente.");
            Habilidad doblePuño = new Habilidad("DoblePuño", 20, "Un ataque rápido con ambos puños.");
            Habilidad Furia = new Habilidad("Furia", 20, "Aumenta el ataque temporalmente.");
            Habilidad resistencia = new Habilidad("Resistencia", 20, "Aumenta la resistencia al daño temporalmente.");

            //Creacion de razas
            Raza Undead = new Raza("Undead", VelocidadGolpe);
            Raza Humano = new Raza("Humano", doblePuño);
            Raza Orco = new Raza("Orco", Furia);
            Raza Elfo = new Raza("Elfo", resistencia);

            List<Habilidad> habilidadesPersonaje = new List<Habilidad> { ataqueEspada, OndaCoque };
            Caballero caballero = new Caballero("Arthas", 100, 50, 20, 10, habilidadesPersonaje, Humano, 15);

            habilidadesPersonaje = new List<Habilidad> { Curacion, GolpeElectrico };
            Hechicero hechicero = new Hechicero("Gandalf", 80, 70, 15, 5, habilidadesPersonaje, Elfo, 30);

            habilidadesPersonaje = new List<Habilidad> { Flecha, FlechaTripls };
            Arquero arquero = new Arquero("Legolas", 90, 60, 18, 8, habilidadesPersonaje, Orco, 25);

            Console.WriteLine( caballero.MostrarEstado());
            Console.WriteLine( hechicero.MostrarEstado());
            Console.WriteLine( arquero.MostrarEstado());
        }

        private void Jugar()
        {
            // Lógica del juego
        }
        private void menuPrincipal()
        {

        }

        private static List<string> mostrarPersonajes() {
            return new List<string> { "Guerrero", "Mago", "Arquero" };
        }
        private static void mostrarCabeceraMenu(string tituloCabecera)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"{tituloCabecera}");
            Console.WriteLine("===================================");
        }


        private static void mostrarOpcPrincipales()
        {
            mostrarCabeceraMenu("Bienvenido a Juego de batallas.");

            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
        }

        public static void menuPersonajes()
        {
            mostrarCabeceraMenu("Seleccion de Personaje");
            int opcion = 1;
            List<string> person = mostrarPersonajes();
            foreach(String per in person){
                Console.WriteLine($"{opcion}. {per}");
                opcion++;
            }
            Console.WriteLine($"{opcion}. Volver al menú principal");
            Console.Write("Seleccione una opción:\n");
        }

        private static void showFooter()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("********* ¡HASTA PRONTO! **********");
            Console.WriteLine("===================================");
        }





        private static int validarEntrada(Action showMenu)
        {
            //This method validates if the input is an integer
            int option;
            while (true)
            {
                string input = Console.ReadLine() ?? "0";
                if (int.TryParse(input, out option))
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido. \n\n");
                    showMenu();
                }
            }
        }

        private static void ejecutarMenu()
        {

            while (true)
            {
                mostrarOpcPrincipales();

                int option = validarEntrada(mostrarOpcPrincipales);

                switch (option)
                {
                    case 1:
                        menuPersonajes();
                        break;
                    case 2:
                        // Salir de la aplicación
                        showFooter();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo. \n\n");
                        break;
                }
            }
        }



    }
}
