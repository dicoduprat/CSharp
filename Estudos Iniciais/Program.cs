using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //simples calculadora
            //variáveis que irão conter os números digitados
            //double aceita número quebrado
            double num1, num2;
            string tmp;

            // receber o número
            Console.WriteLine("Digite o número para realizar as operações: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);
            // receber o número
            Console.WriteLine("Digite mais um número para realizar as operações: ");
            Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;
            //Operações

            //Faz a soma e imprime o resultado

            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);

            //Faz a subtração e imprime o resultado

            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            //Faz a multiplicação e imprime o resultado

            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado);

            //Faz a divisão e imprime o resultado

            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);
        }
    }
}
