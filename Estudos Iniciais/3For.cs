using System;

namespace Aula3WhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            // uma empresa te contratou para desenvolver um aplicativo que realiza a média
            // de notas das avaliações que variam de 1 a 10
            // com o universo de 30 pessoas

            Console.WriteLine("Média de avaliações");
            /*
             * modo feio
             * float aluno 1 = 5
             * float aluno 2 = 6
             * 
             */
            // Precisa colocar um valor para a variável iniciar
            float soma = 0;
            float media = 0;

            // para x coisa faça y 
            // começa do zero e vai até o número 29 e para cada resposta de soma 1 = i++
            // Padrão = for (int i = 0; i < 30; i++)
            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine("Digite uma nota de 0 a 10 em relação ao grau de satisfação do atendimento da loja" + i + ":");
                float nota = 0;
                //ler o que foi escrito e salva em nota
                float.TryParse(Console.ReadLine(), out nota);
                //necessário somar = somar o soma com nota
                soma += nota;
            }

            // enquanto for verdade faça y
            // while () ;

            media = soma / 30;
            Console.WriteLine("Média das avaliações é de: " + media);
            Console.ReadKey();

 
        }
    }
}
