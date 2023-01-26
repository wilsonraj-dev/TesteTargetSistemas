using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TestesParaDesafios.Serialization;

namespace TesteTargetSistemas
{
    class Exercicio_3
    {
        static void Main(string[] args)
        {
            /* 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, 
                  na linguagem que desejar, que calcule e retorne:
                  • O menor valor de faturamento ocorrido em um dia do mês;
                  • O maior valor de faturamento ocorrido em um dia do mês;
                  • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
                  
                  IMPORTANTE:
                  a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
                  b) Podem existir dias sem faturamento, como nos finais de semana e feriados. 
                  Estes dias devem ser ignorados no cálculo da média; */

            var json = File.ReadAllText("D:\\TestesParaDesafios\\TestesParaDesafios" + @"\dados.json");
            var dados = JsonConvert.DeserializeObject<List<Valores>>(json);

            decimal media = 0;
            decimal mediaMensal = 0;
            decimal menorValor = 9999999;
            decimal maiorValor = 0;
            int dias = 0;
            int diasSuperiores = 0;

            for (int i = 0; i < dados.Count; i++)
            {
                if (dados[i].Valor != 0)
                {
                    media += Convert.ToInt32(dados[i].Valor);
                    dias++;
                }
            }
            mediaMensal = media / dias;

            for (int i = 0; i < dados.Count; i++)
            {

                if (Convert.ToInt32(dados[i].Valor) < menorValor)
                    menorValor = Convert.ToInt32(dados[i].Valor);
                else if (Convert.ToInt32(dados[i].Valor) > maiorValor)
                    maiorValor = Convert.ToInt32(dados[i].Valor);

                if (maiorValor > mediaMensal)
                    diasSuperiores++;
            }

            Console.WriteLine($"Média mensal: {mediaMensal}");
            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
            Console.WriteLine($"Dias em que o faturamento diário foi superior a média mensal: {diasSuperiores}");
        }
    }
}
