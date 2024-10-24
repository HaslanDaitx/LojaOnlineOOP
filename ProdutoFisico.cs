public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public string Categoria { get; set; }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Profundidade { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public ProdutoFisico(string nome, string codigo, decimal preco, double peso, string categoria, double altura, double largura, double profundidade, int quantidadeEmEstoque) : base(nome, codigo, preco)
    {
        Peso = peso;
        Categoria = categoria;
        Altura = altura;
        Largura = largura;
        Profundidade = profundidade;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }
    public override decimal CalcularPrecofinal()
    {
        decimal imposto = Preco * 0.17m;
        decimal custoEnvio = (decimal)(Peso * 8);
        return Preco + imposto + custoEnvio;
    }

    public bool VerificarEstoque(int quantidade)
    {
        return QuantidadeEmEstoque >= quantidade;
    }

    public void AtualizarEstoque(int quantidadeVendida)
    {
        QuantidadeEmEstoque -= quantidadeVendida;
    }
}