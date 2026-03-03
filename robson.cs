using ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        produtos produto = new produtos();
        produto.nome = "notebook";
        produto.preco = 3000;
        produto.categoria = "eletronico";
        produto.peso = 2.5;

        clientes cliente = new clientes();
        cliente.nome = "JoaoDelas";
        cliente.cidade = "Perdizes";
        cliente.idade = 20;

        pedidos pedido = new pedidos();
        pedido.numeroPedido = 1;
        pedido.quantidade = 1;
        pedido.descontoPorcentual = 10/100;

        loja loja01 = new loja();
        loja01.nome = "eletroDelas";
        loja01.cidade = "Perdizes";
        loja01.taxaEntrega = 50;

        Console.WriteLine("clientes " + cliente.nome);
       Console.WriteLine("produto  " + produto.nome);
        Console.WriteLine(" quantidade " + pedido.quantidade);  
        Console.WriteLine("numeo do pedido"+ pedido.numeroPedido);
        Console.WriteLine("desconto" + pedido.descontoPorcentual);
        Console.WriteLine("taxa de entrega" + loja01.taxaEntrega);

    }

     
}

