using Diamante;

int numero = SolicitarNumeroImpar();
DiamanteDeX.DesenharDiamante(numero);

int SolicitarNumeroImpar()
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

