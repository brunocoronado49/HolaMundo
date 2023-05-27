using System;
namespace HolaMundo
{
	public class EjercicioSeccionDos
	{
		public static void Ejercicio()
		{
			// Ejercicio de calcular area y perimetro de un rectangulo
			Console.WriteLine("Ejercicio 1 Seccion 2");

			// Pedir ancho y alto
			double altura, ancho, area, perimetro;

			Console.Write("Dame el ancho del rectangulo: ");
			ancho = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el alto del rectangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

			// Calcular el area
			area = ancho * altura;
			Console.WriteLine($"El area es: {area}");

			// calcular el perimetro
			perimetro = 2 * (altura + ancho);
            Console.WriteLine($"El perimetro es: {perimetro}");
        }

		public static void EjercicioDos()
		{
			// Ejercicio que calcula el perimetro de cualquier poligono regular
			Console.WriteLine("Ejercicio 2 Seccion 2");

			double ancho, alto, perimetro;

			Console.Write("Dame la altura del triangulo: ");
			alto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el ancho del triangulo: ");
            ancho = Convert.ToDouble(Console.ReadLine());

			perimetro = (2 * alto) + ancho;
			Console.WriteLine($"El perimetro del triangulo es: {perimetro}");
        }

		public static void EjercicioTres()
		{
            // Ejercicio que convierte grados celcius a farenjeit
            Console.WriteLine("Ejercicio 3 Seccion 2");

			double celcius, farenheit;

			Console.Write("Ingresa los grados en celsius: ");
			celcius = Convert.ToDouble(Console.ReadLine());

			farenheit = (1.8 * celcius) + 32;

			Console.WriteLine($"{celcius} grados celcius, son {farenheit} grados farenheit.");
        }
	} 
}
