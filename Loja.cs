public class Loja
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    private List<Produto> Produtos { get; set; }
    private List<Pedido> Pedidos { get; set; }

    public Loja(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
        Produtos = new List<Produto>();
        Pedidos = new List<Pedido>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao catálogo da loja.");
    }

    public void RemoverProduto(Produto produto)
    {
        Produtos.Remove(produto);
        Console.WriteLine($"Produto {produto.Nome} removido do catálogo da loja.");
    }

    public void ExibirProdutos()
    {
        Console.WriteLine("Produtos disponíveis na loja:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto.Nome}, Código: {produto.Codigo}, Preço: R$ {produto.Preco}");
        }
    }

    public Pedido CriarPedido(Cliente cliente)
    {
        Pedido novoPedido = new Pedido(cliente);
        Pedidos.Add(novoPedido);
        Console.WriteLine($"Novo pedido criado para o cliente: {cliente.Nome}.");
        return novoPedido;
    }
    
    public void ExibirPedidos()
    {
        Console.WriteLine("Pedidos realizados:");
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"Gerando Nota Fiscal:\nCliente: {pedido.Cliente.Nome}\nData: {pedido.DataPedido}\nNota Fiscal: {pedido.NotaFiscal}\nPreço Total: R$ {pedido.CalcularTotal():C}\nStatus: {pedido.Status}");
        }
    }
}