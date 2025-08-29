using JuegoTurno.Model;

namespace JuegoTurno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejecutarMenu();
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
