using System;

class Program
{
    enum StatusPedido
    {
        Pendente,
        Processando,
        Enviado,
        Entregue,
        Cancelado
    }

    static void Main()
    {
        Console.Write("Digite o status do pedido (0-4): ");
        int statusNum = int.Parse(Console.ReadLine());

        StatusPedido status = (StatusPedido)statusNum;

        switch (status)
        {
            case StatusPedido.Pendente:
                Console.WriteLine("Seu pedido está aguardando aprovação.");
                break;
            case StatusPedido.Processando:
                Console.WriteLine("Seu pedido está sendo preparado.");
                break;
            case StatusPedido.Enviado:
                Console.WriteLine("Seu pedido foi enviado.");
                Console.WriteLine("Código de rastreamento: ABC123");
                break;
            case StatusPedido.Entregue:
                Console.WriteLine("Seu pedido foi entregue!");
                break;
            case StatusPedido.Cancelado:
                Console.WriteLine("Seu pedido foi cancelado.");
                break;
            default:
                Console.WriteLine("Status inválido!");
                break;
        }
    }
}