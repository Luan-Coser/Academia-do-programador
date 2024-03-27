// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Double primeiroN, segundoN, resultado = 0;
Boolean valido = true;
string operador = "";

while (Console.ReadLine() != "sair")
{
    valido = true;
    Console.Write("Primeiro Numero: ");
    primeiroN = Double.Parse(Console.ReadLine());

    Console.Write("Segundo Numero: ");
    segundoN = Double.Parse(Console.ReadLine());

    Console.WriteLine("\nEscolha o tipo de poeração \n1- Soma\n2 -Subtração\n3- Divisão\n4- Multiplicação");
    switch (Console.ReadLine())
    {
        case "1":
            resultado = primeiroN + segundoN;
            operador = "+";
            break;

        case "2":
            resultado = primeiroN - segundoN;
            operador = "-";
            break;

        case "3":
            resultado = primeiroN * segundoN;
            operador = "*";
            break;

        case "4":
            if (primeiroN == 0 || segundoN == 0)
            {
                Console.WriteLine("Divisao por zero não pode ser executada\n");
                valido = false;
            }
            else
            {
                resultado = primeiroN / segundoN;

            }
            operador = "/";
            break;
    }
    Console.Write("----------------------------------------------------------\n");

    if (valido == true)
    {
        Console.Write($"Resultado: {primeiroN} {operador} {segundoN} = {resultado}\n");
    }

    Console.Write("\nCaso deseje sair escreva 'sair'");

}



