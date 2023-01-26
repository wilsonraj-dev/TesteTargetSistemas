using System;

namespace TesteTargetSistemas
{
    class Exercicio_5
    {
        static void Main(string[] args)
        {
            /* 5) Escreva um programa que inverta os caracteres de um string.
                  
                  IMPORTANTE:
                  a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode 
                  ser previamente definida no código;
                  b) Evite usar funções prontas, como, por exemplo, reverse; */

            //Usando while
            string stringParaReverter = Console.ReadLine();
            string stringReversa = "";
            int length = stringParaReverter.Length - 1;

            while (length >= 0)
            {
                stringReversa += stringParaReverter[length];
                length--;
            }
            Console.WriteLine(stringReversa);

            //Usando for
            char[] stringArray = stringParaReverter.ToCharArray();
            stringReversa = String.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                stringReversa += stringArray[i];
            }
            Console.WriteLine(stringReversa);
        }
    }
}
