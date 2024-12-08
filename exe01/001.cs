using System;

class ex001
{
    static void Main(string[] args)
    {
        // Solicita ao usuário a quantidade mínima e máxima
        Console.Write("Digite a quantidade mínima: ");
        double quantidadeMinima = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade máxima: ");
        double quantidadeMaxima = Convert.ToDouble(Console.ReadLine());

        // Calcula o estoque médio
        double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

        // Exibe o resultado
        Console.WriteLine($"O estoque médio é: {estoqueMedio}");
    }
}


