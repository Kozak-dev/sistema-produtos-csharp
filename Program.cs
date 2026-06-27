namespace cPOO;

public class Program
{
    public static void Main()
    {
       List<Produto> produtos = new List<Produto>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Mostrar produtos cadastrados");
            Console.WriteLine("3 - Alterar valor do produto");
            Console.WriteLine("4 - Comprar produto");
            Console.WriteLine("5 - Repor estoque do produto");
            Console.WriteLine("6 - Sair");
            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome do produto:");
                    string? nome = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome do produto não pode ser vazio. Tente novamente.");
                        break;
                    }

                    Console.WriteLine("Digite a marca do produto:");
                    string? marca = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(marca))
                    {
                        Console.WriteLine("Marca do produto não pode ser vazia. Tente novamente.");
                        break;
                    }
                    Console.WriteLine("Digite o valor do produto:");
                    decimal valor;
                    if (!decimal.TryParse(Console.ReadLine(), out valor) || valor < 0)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        break;
                    }

                    Console.WriteLine("Digite a quantidade do produto:");
                    int Quantidade;
                    if (!int.TryParse(Console.ReadLine(), out Quantidade) || Quantidade < 0)
                    {
                        Console.WriteLine("Quantidade inválida. Tente novamente.");
                        break;
                    }

                    Produto produto = new Produto(nome, marca, valor, Quantidade);
                    produtos.Add(produto);

                    break;
                case 2:
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        foreach (var p in produtos)
                        {
                            p.MostrarDados();
                        }
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("Digite o nome do produto que deseja alterar o valor:");
                    string? nomeAlterar = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeAlterar))
                    {
                        Console.WriteLine("Nome do produto não pode ser vazio. Tente novamente.");
                        break;
                    }
                    Console.WriteLine("Digite o novo valor do produto:");
                    decimal novoValor;
                    if (!decimal.TryParse(Console.ReadLine(), out novoValor) || novoValor < 0)
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        break;
                    }
                    
                    bool encontrado = false;
                    foreach (var p in produtos)
                    {

                        if (p.Nome == nomeAlterar)
                        {
                            encontrado = true;
                            p.AlterarValor(novoValor);
                            break;
                        }   
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    
                    
                    break;

                case 4:
                    
                    encontrado = false;
                    Console.WriteLine("Digite o nome do produto que deseja comprar:");
                    string? nomeComprar = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeComprar))
                    {
                        Console.WriteLine("Nome do produto não pode ser vazio. Tente novamente.");
                        break;
                    }

                    Console.WriteLine("Digite a quantidade que deseja comprar:");
                    int quantidadeComprar; 
                    if (!int.TryParse(Console.ReadLine(), out quantidadeComprar) || quantidadeComprar <= 0)
                    {
                        Console.WriteLine("Quantidade inválida. Tente novamente.");
                        break;
                    }
                    
                    foreach (var p in produtos)
                    {
                        if (p.Nome == nomeComprar)
                        {
                            encontrado = true;

                            p.Comprar(quantidadeComprar);
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    
                    break;
                case 5:
                    encontrado = false;
                    Console.WriteLine("Digite o nome do produto que deseja repor o estoque:");
                    string? nomeRepor = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeRepor))
                    {
                        Console.WriteLine("Nome do produto não pode ser vazio. Tente novamente.");
                        break;
                    }

                    Console.WriteLine("Digite a quantidade que deseja repor:");
                    int quantidadeRepor;
                    if (!int.TryParse(Console.ReadLine(), out quantidadeRepor) || quantidadeRepor <= 0)
                    {
                        Console.WriteLine("Quantidade inválida. Tente novamente.");
                        break;
                    }
                    

                    foreach (var p in produtos)
                    {
                        if (p.Nome == nomeRepor)
                        {
                            encontrado = true;
                            p.ReporEstoque(quantidadeRepor);
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Produto não encontrado.");
                    }
                    
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
