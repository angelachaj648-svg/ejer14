int numero;
int mayor = int.Parse(Console.ReadLine()); ;

do
{
	Console.Write("Ingrese un número (0 para terminar): ");
	numero = int.Parse(Console.ReadLine());

	if (numero > mayor)
	{
		mayor = numero;
	}

} while (numero != 0);

Console.WriteLine("El número mayor es: " + mayor);