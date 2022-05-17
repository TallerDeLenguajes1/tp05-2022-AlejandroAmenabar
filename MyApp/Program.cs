// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hola mundo!");
Console.WriteLine("A ver si sale");

Console.WriteLine("Ingrese un numero");
string numero1 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero");
string numero2 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero");
string numero3 = Console.ReadLine();
double cuadrado = System.Math.Pow(Convert.ToDouble(numero2),2);
double resultado = Convert.ToDouble(numero1) + cuadrado + Convert.ToDouble(numero3);
Console.WriteLine("La suma de los dos numeros es "+ resultado);
