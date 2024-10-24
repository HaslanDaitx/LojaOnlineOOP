public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Endereco { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Cadastro realizado com Sucesso!\nCliente: {Nome}, CPF: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}");
        
    }
}