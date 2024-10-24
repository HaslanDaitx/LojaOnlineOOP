public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, string codigo, decimal preco, double tamanhoArquivo, string formato) : base (nome, codigo, preco)
    {
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecofinal()
    {
        decimal desconto = Preco * 0.15m;
        return Preco - desconto;
    }
}