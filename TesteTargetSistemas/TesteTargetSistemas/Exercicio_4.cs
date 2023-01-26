using System;
using System.Globalization;

namespace TesteTargetSistemas
{
    class Exercicio_4
    {
        static void Main(string[] args)
        {
            /* 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
                  
                  SP – R$67.836,43
                  RJ – R$36.678,66
                  MG – R$29.229,88
                  ES – R$27.165,48
                  Outros – R$19.849,53
                  
                  Escreva um programa na linguagem que desejar onde calcule o percentual de representação 
                  que cada estado teve dentro do valor total mensal da distribuidora. */

            decimal sp = 6783643;
            decimal rj = 3667866;
            decimal mg = 2922988;
            decimal es = 2716548;
            decimal outros = 1984953;

            decimal valorTotal = sp + rj + mg + es + outros;
            Console.WriteLine($"Valor total - {valorTotal}");

            decimal percentualSp = ((sp / valorTotal) * 100);
            decimal percentualRj = ((rj / valorTotal) * 100);
            decimal percentualMg = ((mg / valorTotal) * 100);
            decimal percentualEs = ((es / valorTotal) * 100);
            decimal percentualOutros = ((outros / valorTotal) * 100);

            Console.WriteLine($"Percentual SP - {percentualSp.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Percentual RJ - {percentualRj.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Percentual MG - {percentualMg.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Percentual ES - {percentualEs.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Percentual Outros - {percentualOutros.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
