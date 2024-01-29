using System;

namespace programa_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
            Console.WriteLine("Vamos a encontrar el perimetro de un cuadrado");
            Console.WriteLine("por favor ingrese el tamaño del lado de su cuadrado: ");
			int lado = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"El perimetro de tu cuadrado de lado {lado} es { lado * 4 }");
			}catch (Exception ex)
			{
				Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
			}
        }
	}
}