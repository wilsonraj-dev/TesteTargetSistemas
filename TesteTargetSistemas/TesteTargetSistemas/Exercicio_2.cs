using System;
using System.Collections.Generic;

namespace TesteTargetSistemas
{
    class Exercicio_2
    {
        static void Main(string[] args)
        {
            /* 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores 
                  anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, 
                  informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado 
                  pertence ou não a sequência.

                  IMPORTANTE:
                  Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código; */

            int n = int.Parse(Console.ReadLine());
            int proximo, anterior = 0, atual = 1;
            bool pertence = false;
            List<int> lstValores = new List<int> { };

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(anterior);
                }
                else
                {
                    Console.Write($"{anterior} ");
                }

                lstValores.Add(anterior);
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            foreach (var valores in lstValores)
            {
                if (valores == n)
                {
                    Console.WriteLine("Pertence a sequência.");
                    pertence = true;
                    break;
                }
            }

            if (pertence == false)
            {
                Console.WriteLine("Não pertence a sequência.");
            }
        }
    }
}
