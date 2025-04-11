using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante
{
    internal static class DiamanteDeX
    {

        public static void DesenharDiamante(int tamanho)
        {
            int meio = tamanho / 2;

            // Parte superior
            for (int i = 0; i <= meio; i++)
            {
                EscreverLinha(tamanho, i);
            }

            // Parte inferior
            for (int i = meio - 1; i >= 0; i--)
            {
                EscreverLinha(tamanho, i);
            }
        }

        static void EscreverLinha(int tamanho, int linhaAtual)
        {
            int quantidadeDeX = linhaAtual * 2 + 1;
            int espacos = (tamanho - quantidadeDeX) / 2;

            string margem = new string(' ', espacos);
            Console.Write(margem);

            string linhaDeX = new string('X', quantidadeDeX);
            Console.WriteLine(linhaDeX);
        }
    }
}
