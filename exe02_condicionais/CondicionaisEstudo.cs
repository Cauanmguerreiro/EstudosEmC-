class CondicionaisEstudo
{
    static void Main()
    {
        // Lê o nome do aluno
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        // Verifica se o nome não é vazio ou nulo
        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome não pode ser vazio.");
            return;
        }

        // Solicita ao usuário a quantidade de avaliações
        Console.WriteLine("Quantas avaliações você deseja inserir?");
        int quantidadeAvaliacoes;
        if (!int.TryParse(Console.ReadLine(), out quantidadeAvaliacoes) || quantidadeAvaliacoes <= 0)
        {
            Console.WriteLine("Quantidade de avaliações inválida.");
            return;
        }

        // Inicializa a variável para somar as notas
        double somaNotas = 0;

        // Loop para coletar as notas
        for (int i = 1; i <= quantidadeAvaliacoes; i++)
        {
            Console.WriteLine($"Digite a nota da avaliação {i}:");
            double nota;

            // Verifica se a entrada é válida
            if (!double.TryParse(Console.ReadLine(), out nota) || nota < 0)
            {
                Console.WriteLine("Nota inválida. Por favor, insira um valor numérico válido.");
                return;
            }

            somaNotas += nota; // Soma a nota à variável
        }

        // Calcula a média
        double media = somaNotas / quantidadeAvaliacoes;

        // Determina se o aluno foi aprovado ou reprovado
        string resultado = media >= 60 ? "Aprovado" : "Reprovado";

        // Exibe o resultado
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Resultado: {resultado}");
    }
}
