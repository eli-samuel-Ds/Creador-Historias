using System;

namespace creadorHistoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Creador De Historia: ");

                Console.WriteLine(@"
Hacer un programa donde se introduzca el nombre de la persona, se creen
dos arrays de tipo string uno que guarde tres lugares,
y el otro donde guarde acciones como nadar, etc,
y despues se utilize la funcion random para elegir de los array una de las palabras
y utilizarlas en una oracion que una todo.
");

                //Elgir todo
                string[] lugares = { "Azua", "Bani", "San Juan" };
                string[] acciones = { "Caminando", "Nadando", "Corriendo", "Comiendo" };

                Random random = new Random();
                string lugarElegido = lugares[random.Next(lugares.Length)];
                string accionElegida = acciones[random.Next(acciones.Length)];

                //Introducir nombre y eligir historia
                Console.Write("El nombre del personaje es: ");
                string nombreHistoria = Console.ReadLine()!;
                Console.WriteLine();
                Console.WriteLine($"Historia de {nombreHistoria}");
                Console.WriteLine($"Un dia, {nombreHistoria} estaba {accionElegida} en {lugarElegido}");

                //Para salir o continuar
                Console.CursorVisible = false;
                Console.WriteLine("\nVolver a Intentar (Y) o Salir (N)");

                while (true)
                {
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.Y:
                            break;

                        case ConsoleKey.N:
                            return;

                        default:
                            continue;
                    }
                    break;
                }
            }
        }
    }
}