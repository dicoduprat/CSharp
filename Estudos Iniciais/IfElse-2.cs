using System;

namespace Aula_2___IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O professor gostaria de saber se está gostando das aulas
             * se alguém não gostar 
             * quer saber o motivo também 
             */

            String EstadoAluno;
            String RespostaSeNao;

            Console.WriteLine("Você está gostando das aulas apresentadas?(Responda com SIM ou NÃO)");
            EstadoAluno = Console.ReadLine();
            // condicional - == sim
            //ToLower - mesmo que a pessoa responda com capslock ainda irá funcionar
            if (EstadoAluno.ToLower() == "sim")
            {
                Console.WriteLine("Ficamos felizes em saber que as aulas estão te agradando");
            }
            else
            {//evitar que qualquer coisas diferente de SIM estrague o programa
                if (EstadoAluno.ToLower() == "não")
                {//pesquisa para saber o motivo
                    Console.WriteLine("Que pena, poderia nos dizer qual é motivo?");
                    //capturar o que for respondido
                    RespostaSeNao = Console.ReadLine();
                    //Printar a resposta do aluno
                    Console.WriteLine("Motivo: " + RespostaSeNao);
                }
            }
            //para o programa não fechar
            Console.ReadKey();

        }
    }
 }
