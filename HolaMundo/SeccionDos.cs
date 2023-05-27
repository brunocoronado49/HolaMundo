using System;
namespace HolaMundo
{
    public class SeccionDos
    {
        public SeccionDos()
        {
        }

        public static void Recetas()
        {
            Console.WriteLine("1. Precalentar el horno");
            Console.WriteLine("2. Mezclar harina y mantequilla");
            Console.WriteLine("3. Agregar azucar y 1 huevo");
            Console.WriteLine("4. Amasar la mezcla");
            Console.WriteLine("5. Dar forma y meter en charola");
            Console.WriteLine("6. Hornear 10 minutos");

            // Sin salto de linea
            Console.Write("primer renglon sin salto de linea");
            Console.Write("segundo renglon sin salto de linea");

            Console.WriteLine();
        }

        public static void Name()
        {
            Console.WriteLine("Name");
        }

        public static void Variables()
        {
            int numeroLibros = 10;
            int librosMatematicas = 20;
            int librosTerror, librosComedia;

            librosComedia = 4;
            librosTerror = 3;

            Console.WriteLine(numeroLibros);
            Console.WriteLine(librosMatematicas);
            Console.WriteLine($"Terror: {librosTerror} - Comedia: {librosComedia}");

            char letra = 'A';
            Console.WriteLine(letra);

            string palabra = "Hola";
            Console.WriteLine(palabra);

            bool isOpen = true;
            Console.WriteLine(isOpen);

            double precioJuego = 10.8;
            Console.WriteLine(precioJuego);

            decimal promedioExamen = 8.6M;
            Console.WriteLine(promedioExamen);

            float otroPromedio = 4.3F;
            Console.WriteLine(otroPromedio);
        }

        public static void Operadores()
        {
            int numeroUno = 27;
            int numeroDos = 19;

            int suma = numeroUno + numeroDos;
            int resta = numeroUno - numeroDos;
            int multiplicacion = numeroUno * numeroDos;
            double division = numeroUno / numeroDos;
            double residuo = numeroUno % numeroDos;

            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Resta: {resta}");
            Console.WriteLine($"Multiplicacion: {multiplicacion}");
            Console.WriteLine($"Division: {division}");
            Console.WriteLine($"Residuo: {residuo}");

            // Hay gerarquia de operaciones
            // En una linea se leeran de izq a derch (*, /, %)
            // comparten prioridad
            // Al final se usaran la (+ y -)
            Console.WriteLine(2 * 5 + 3);

            // La gerarquia cambia cuando la operacion se
            // encierra en parentesis
            Console.WriteLine(25 + (6 - 4) * 3);
        }

        public static void EntradaUsuario()
        {
            string? nombre;
            //string? edadString;
            int edadInt;
            Console.Write("Ingresa tu nomrbe: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola, mucho gusto {nombre}");

            Console.Write("Ingresa tu edad: ");
            //edadString = Console.ReadLine();

            // convertimos el string a int32
            //edadInt = Convert.ToInt32(edadString); // genera excepcion
            // edadInt = Int32.Parse(edadString); sigue ejecutando el programa
            edadInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tienes {edadInt + 1} anios, ya estas viejo");
        }
 	}
}
