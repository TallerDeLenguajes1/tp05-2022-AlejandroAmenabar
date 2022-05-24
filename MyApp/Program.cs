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

Console.WriteLine("El numero ingresado invertido es:  "+numInvertido
);*/

/*---Calculadora---*/

int opcion=10;
int menu=2;
double num1,num2,resultado=0;
do
{
    Console.WriteLine("elija la operacion a realizar");
    Console.WriteLine("1-Sumar 2-Restar 3-Multiplicar 4-Dividir");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el primer numero: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            if(num2!=0){
                resultado = num1/num2;
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