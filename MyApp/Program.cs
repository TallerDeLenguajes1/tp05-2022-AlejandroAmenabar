// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Ejercicio 1: invertir numero de N cifras");
Console.WriteLine("ingrese el numero: ");

int num = Convert.ToInt32(Console.ReadLine());
int numInvertido = 0;
Console.WriteLine("El numero ingresado es:  "+num);

while (num>0)
{
    numInvertido = numInvertido *10 + (num%10);
    num = num/10;
}

Console.WriteLine("El numero ingresado invertido es:  "+numInvertido);
*/

/*---Calculadora V2---*/

using System;

double num1, num2;

Console.WriteLine("Ingrese un número");
num1 =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor Absoluto: " + Math.Abs(num1));
Console.WriteLine("Valor Cuadrado: " + Math.Pow(num1, 2));
Console.WriteLine("Raíz Cuadrada: " + Math.Pow(num1, 0.5f));
Console.WriteLine("Seno: " + Math.Sin(num1));
Console.WriteLine("Coseno: " + Math.Cos(num1));
Console.WriteLine("Parte Entera " + Math.Floor(num1));

Console.WriteLine("Ingrese el primer número");
num1 =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
num2 =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El máximo entre los dos es: " + Math.Max(num1, num2));
Console.WriteLine("El mínimo entre los dos es: " + Math.Min(num1, num2));