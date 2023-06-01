using System;
namespace HolaMundo
{
	public class TareaOperadoresLogicos
	{
		public static void Tarea()
		{
			bool propDerecho, propIzquierdo;
			int energia;

			Console.Write("Ingresa el porcentaje de energia: ");
			energia = Convert.ToInt32(Console.ReadLine());

			Console.Write("Ingresa si funciona el propulsor derecho (true / false): ");
			propDerecho = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Ingresa si funciona el propulsor izquierdo (ture / false): ");
            propIzquierdo = Convert.ToBoolean(Console.ReadLine());

            if (
				((propDerecho && propIzquierdo) && (energia >= 75)) ||
				((propDerecho || propIzquierdo) && (energia == 100))
			)
			{
				Console.WriteLine("Es seguro, puedes despegar");
			} else
			{
				Console.WriteLine("Lo siento, no es seguro despegar");
            }
        }
	}
}
