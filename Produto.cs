class Produto
{
   public string Nome { get; set; }
   public string Marca { get; set; }
   public decimal Valor { get; set; }
   public int Quantidade { get; set; }

   public Produto(string nome, string marca, decimal valor, int quantidade)
   {
      Nome = nome;
      Marca = marca;
      Valor =   valor;
      Quantidade = quantidade;
   }

   public void MostrarDados()
   {
      Console.WriteLine($"Nome: {Nome}");
      Console.WriteLine($"Marca: {Marca}");
      Console.WriteLine($"Valor: {Valor:C}");
      Console.WriteLine($"Quantidade: {Quantidade}");
      Console.WriteLine("--------------------");
   }

   public void AlterarValor(decimal novoValor)
    {
        if (Quantidade > 0)
        {
            Valor = novoValor;
            Console.WriteLine("Valor alterado com sucesso!");
        }
        else
        {
            Console.WriteLine("Não é possível alterar o valor de um produto sem estoque.");
        }
    }

    public void Comprar(int quantidadeComprar)
    {

        if(Quantidade >= quantidadeComprar)
        {
            Quantidade -= quantidadeComprar;
            Console.WriteLine($"Compra realizada com sucesso! Quantidade restante: {Quantidade}");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }

    public void ReporEstoque(int quantidadeRepor)
    {
        if(quantidadeRepor > 0)
        {
            Quantidade += quantidadeRepor;
            Console.WriteLine($"Estoque reposto com sucesso! Nova quantidade: {Quantidade}");
        }
        else
        {
            Console.WriteLine("Quantidade a repor deve ser maior que zero.");
        }
    }
    
}