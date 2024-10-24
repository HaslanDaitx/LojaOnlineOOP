using System.Threading.Tasks.Dataflow;

Loja minhaLoja = new Loja("Magazine Haslan", "Avenida José Bonifácio, 1054");


ProdutoFisico notebook = new ProdutoFisico("Notebook", "123", 3500.00m, 2.9, "Eletrônicos", 47.0, 36.0, 8.0, 10);
ProdutoFisico Iphone = new ProdutoFisico("Iphone", "165", 5500.00m, 0.100, "Eletrônicos", 18.54, 9.4, 1.78, 0);

ProdutoDigital cursoOnline = new ProdutoDigital("Curso C#", "234", 199.99m, 1.5, "MP4");

minhaLoja.AdicionarProduto(notebook);
minhaLoja.AdicionarProduto(cursoOnline);
minhaLoja.AdicionarProduto(Iphone);
minhaLoja.ExibirProdutos();


Cliente cliente1 = new Cliente("Carlos Azevedo", "2348584085", "Rua Santa Maria, 54", "carlosazevedo@gmail.com");

cliente1.ExibirInformacoes();
Pedido pedidoCarlos = minhaLoja.CriarPedido(cliente1);

pedidoCarlos.AdicionarProduto(notebook);
pedidoCarlos.AdicionarProduto(cursoOnline);
pedidoCarlos.AdicionarProduto(Iphone);



Console.WriteLine($"Total do Pedido: {pedidoCarlos.CalcularTotal():C}");

pedidoCarlos.FinalizarPedido();

minhaLoja.ExibirPedidos();