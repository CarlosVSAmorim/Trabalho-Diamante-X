using System;

        int numero = SolicitarNumeroImpar();
        DesenharDiamante(numero);

    static int SolicitarNumeroImpar()
    {
        int numero;
        do
        {
            Console.Write("Digite um número ímpar: ");
            bool ehValido = int.TryParse(Console.ReadLine(), out numero);

            if (!ehValido || numero % 2 == 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro ímpar.");
            }

        } while (numero % 2 == 0);

        return numero;
    }
    static void EscreverLinha(int larguraTotal, int linhaAtual)
    {
        int quantidadeDeX = linhaAtual * 2 + 1;
        int espacos = (larguraTotal - quantidadeDeX) / 2;

        Console.Write(new string(' ', espacos));
        Console.WriteLine(new string('X', quantidadeDeX));
    }
