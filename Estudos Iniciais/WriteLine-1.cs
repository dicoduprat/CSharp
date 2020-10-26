using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {


            // inputar informação - criando variável
            String Sonho; 


            // Separa em linhas o que for escrito
            Console.WriteLine("Olá Mundo!");

            // Deita printado tudo na mesma linha / sem organização alguma
            Console.Write("Qual seu maior sonho?");

            // Pega o que for escrito de resposta
            Condicao = Console.ReadLine();

            // printar resposta buscando a variável que foi escrita
            Console.WriteLine("Seu maior sonho é:" + Sonho);


         /* O programa só será fechado se alguma tecla for pressionada
          * 
          * Pode colocar parâmetros como boelano e etc... 
          * 
         */

            Console.ReadKey();

        }
    }
}
