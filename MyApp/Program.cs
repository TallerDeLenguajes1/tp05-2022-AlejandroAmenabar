// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hola mundo!");
Console.WriteLine("A ver si sale");

Console.WriteLine("Ingrese un numero");
string numero1 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero");
string numero2 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero");
string numero3 = Console.ReadLine();

int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2) + Convert.ToInt32(numero3);
Console.WriteLine("La suma de los dos numeros es "+ resultado);
