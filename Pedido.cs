public class Pedido : ICarriavel
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public string Status { get; set; }
    public int NotaFiscal { get; set; }
    public List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Status = "Em Processamento";
        NotaFiscal = 43596;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto is ProdutoFisico produtoFisico)
        {
            if (produtoFisico.VerificarEstoque(1))
            {
                Produtos.Add(produto);
                Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido.");
            }
            else
            {
                Console.WriteLine($"Estoque Insuficiente para o produto: {produto.Nome}.\nNão adicionado ao pedido.");
            }
        }
        else
        {
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido.");
        }
    }

    public void RemoverProduto(Produto produto)
    {
        if (Produtos.Remove(produto))
        {
            Console.WriteLine($"Produto {produto.Nome} removido do pedido.");
        }
        else
        {
            Console.WriteLine($"Produto {produto.Nome} não encontrado no pedido.");
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecofinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        foreach (var produto in Produtos)
        {
            if (produto is ProdutoFisico produtoFisico)
            {
                if (produtoFisico.VerificarEstoque(1))
                {
                    produtoFisico.AtualizarEstoque(1);
                    Console.WriteLine($"Estoque atualizado.\nProduto: {produtoFisico.Nome}, Estoque restante: {produtoFisico.QuantidadeEmEstoque}");
                }
                else
                {
                    Console.WriteLine($"Estoque insuficiente para o produto: {produtoFisico.Nome}");
                }
            }
        }
        Status = "Concluído";
        Console.WriteLine("Nota Fiscal emitida.");
    }
}