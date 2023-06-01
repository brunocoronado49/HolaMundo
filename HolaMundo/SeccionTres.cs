using System;
namespace HolaMundo
{
	public class SeccionTres
	{
		public static void ValorBooleano()
		{
			int a = 30, b = 20;

			Console.WriteLine(a == b); // false
			Console.WriteLine(a != b); // true
			Console.WriteLine(a < b); // false
			Console.WriteLine(a > b); // true
			Console.WriteLine(a <= b); // false
			Console.WriteLine(a >= b); // true
		}

		public static void PalabrasClave()
		{
			// usar esta manera para indicar que
			// se usara int como variable,
			// indicando con un @ al principio
			// y asi con cada palabra clave (keyword)
			int @int = 27;
			Console.WriteLine(@int);
		}

		public static void Condiciones()
		{
			byte edad;

			Console.Write("Ingresa tu edad: ");
			edad = Convert.ToByte(Console.ReadLine());

			if (edad >= 18)
			{
				Console.WriteLine("Eres MAYOR de edad");
			} else
			{
				Console.WriteLine("Eres MENOR de edad");
			}

			if (edad == 210)
				Console.WriteLine("No digas mamadas meryjein");
		}

		public static void IfAnidados()
		{
			decimal num1, num2, result;
			byte opcion;

			Console.WriteLine("Elige una opcion:");
			Console.WriteLine("1. Suma");
			Console.WriteLine("2. Resta");
			Console.WriteLine("3. Multiplicacion");
			Console.WriteLine("4: Division");

			opcion = Convert.ToByte(Console.ReadLine());
			Console.Write("Dame el primer numero: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Dame el segundo numero: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			if (opcion == 1)
			{
				result = num1 + num2;
				Console.WriteLine($"El resultado de la suma es {result}");
			} else if (opcion == 2)
			{
				result = num1 - num2;
				Console.WriteLine($"El resultado de la resta es {result}");
			} else if (opcion == 3)
			{
				result = num1 * num2;
				Console.WriteLine($"El resultado de la multiplicacion es {result}");
			} else if (opcion == 4)
			{
				if (num2 != 0)
				{
					result = num1 / num2;
					Console.WriteLine($"El resultado de la division es {result}");
				} else
				{
					Console.WriteLine("No es posible dividir entre 0");
				}
			} else
			{
				Console.WriteLine("No hay numero maistro");
			}
		}

		public static void OperadoresLogicos()
		{
			// signo = operador
			// !   =  negacion logica
			// &   =  and logico
			// |   =  or logico
			// ^   =  or exclusico logico
			// &&  =  and logico condicional
			// ||  =  or logico condicional

			bool isOn;
			Console.Write("Enciende el interruptor (true / false): ");
			isOn = Convert.ToBoolean(Console.ReadLine());

			if (!(isOn == true))
			{
				Console.WriteLine($"Esta apagado {!isOn}");
			} else
			{
				Console.WriteLine($"Esta encendido {isOn}");
			}

			bool backendDev = true, frontendDev = false, fullstack;

			if (frontendDev == true && backendDev == true)
			{
				fullstack = true;
				Console.WriteLine($"Eres un fullstack: {fullstack}");
			} else
			{
				fullstack = false;
				Console.WriteLine($"No eres un fullstack {fullstack}");
			}

			bool vscode = true, visualstudio = false;

			if (vscode || visualstudio)
			{
				Console.WriteLine("Puedes programar en C#");
			} else
			{
                Console.WriteLine("No puedes programar en C#");
            }
		}

		public static void InstruccionSwitch()
		{
			string? color;
			Console.Write("Ingresa la letra o palabra para el codigo del color rgb: ");
			color = Console.ReadLine();

			switch (color)
			{
				case "r":
				case "red":
				case "Red":
				case "rojo":
					Console.WriteLine($"255, 0, 0 para {color}");
					break;
				case "g":
                case "green":
                case "Green":
                case "verde":
                    Console.WriteLine($"0, 255, 0 para {color}");
					break;
                case "b":
                case "blue":
                case "Blue":
                case "azul":
                    Console.WriteLine($"0, 0, 255 para {color}");
                    break;
				default:
					Console.WriteLine("Ingresa bien la letra como se pide");
					break;
            }

			byte edad = 118;

			switch (edad)
			{
				case 18:
					Console.WriteLine("Ya eres menor de edad");
					break;
				case 10:
					Console.WriteLine("Eres un bebe");
					break;
				default:
					Console.WriteLine("No tienes edad valida");
					break;
			}

			double num1, num2;
			double resultado;
			string? operacion;

			Console.Write("Ingresa un numero: ");
			num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa otro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Que operacion quieres hacer (+, -, *, /): ");
			operacion = Console.ReadLine();

			if (operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/")
			{
                switch (operacion)
                {
                    case "+":
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado de la suma es {resultado}");
                        break;
                    case "-":
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado de la resta es {resultado}");
                        break;
                    case "*":
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado de la multiplicacion es {resultado}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"El resultado de la division es {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0 estupido imbecil");
                        }
                        break;
                    default:
                        Console.WriteLine("00000");
                        break;
                }
            } else
			{
				Console.WriteLine("Ingresa una operacion valida imbecil");
			}
        }

		public static void ValoresConstantes()
		{
			// const no pueden cambiar su valor
			const string nombre = "Bruce";
			byte edad = 25;

			Console.WriteLine($"Hola soy {nombre} y tengo {edad} años");
		}
    }
}
