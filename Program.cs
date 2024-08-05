// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

int numero=100;
int auxiliar;

console.WriteLine("valor de a: "+ a);
console.WriteLine("valor de b: "+ b);

if (numero > 0)
{
    if (numero<10)
    {
        console.WriteLine("el numero invertido es: "+ numero);

    }else
    {
        while (numero>10)
        {
            auxiliar=numero%10;
            numero=numero/10;
            console.WriteLine(auxiliar);
        }
        auxiliar=numero;
        console.WriteLine(aux);
    }
}




//punto 2

int num1;
int num2;
int opcion;
int resultado;

console.WriteLine("++++++++++++++++++++++++++++++++++++++");
console.WriteLine("****** MENU *******");
console.WriteLine("1)- sumar");
console.WriteLine("2)- restar");
console.WriteLine("3)- multiplicar");
console.WriteLine("4)- dividir");
opcion = console.ReadLine();

switch (opcion)
{
    case 1:
        console.WriteLine("ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("ingrese el segundo numero: ");
        num2 = console.ReadLine();
        resultado = num1+num2;
    case 2:
        console.WriteLine("ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("ingrese el segundo numero: ");
        num2 = console.ReadLine();
        resultado = num1-num2;
    case 1:
        console.WriteLine("ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("ingrese el segundo numero: ");
        num2 = console.ReadLine();
        resultado = num1*num2;
    case 1:
        console.WriteLine("ingrese el primer numero: ");
        num1 = console.ReadLine();
        console.WriteLine("ingrese el segundo numero: ");
        num2 = console.ReadLine();
        resultado = num1/num2;
    default:
}