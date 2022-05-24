// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Ejercicio 1: invertir numero de N cifras");
Console.WriteLine("ingrese el numero: ");

int num = Convert.ToInt32(Console.ReadLine());
int numInvertido = 0;
Console.WriteLine("El numero ingresado es:  "+num);

while (num>0)
{
    numInvertido = numInvertido *10 + (num%10);
    num = num/10;
}

Console.WriteLine("El numero ingresado invertido es:  "+numInvertido);*/

using System;

/*---Calculadora V1---*/

int opcion=10;
int menu=2;
double numero1,numero2,resultado=0;
do
{
    Console.WriteLine("elija la operacion a realizar");
    Console.WriteLine("1-Sumar 2-Restar 3-Multiplicar 4-Dividir");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el primer numero: ");
    numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    numero2 = Convert.ToDouble(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            if(numero2!=0){
                resultado = numero1/numero2;
            }else{
                Console.WriteLine("ERROR! Para dividir dos numeros el segundo debe ser distinto de cero");
            }
            break;
        default:
            Console.WriteLine("debe ingresar una opcion valida");
            break;
    }
    Console.WriteLine("El resultado es: " + resultado);
    Console.WriteLine("Desea realizar otra operacion 1-Si 0-No");
    menu = Convert.ToInt32(Console.ReadLine());
} while (menu!=0);

/*---Calculadora V2---*/



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
