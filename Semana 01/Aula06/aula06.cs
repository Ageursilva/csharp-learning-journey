using System;
//Formatando a saida no console

class Aula06
{
    static void Main()
    {
        //int n1, n2, n3;
        //n1 = 10;n2 = 20;n3 = 30;

        //Console.WriteLine(n1 + "," + n2 + "," + n3);
        //Indice
        //Console.Write("N1 ={0},N2 ={1},N3 ={2}", n1, n2, n3);
        //Quebra de linha
        //Console.Write("\nN1 ={0}\nN2 ={1}\nN3 ={2}", n1, n2, n3);
        //Tabulação
        //Console.Write("\nN1=\t{0}\nN2=\t{1}\nN3=\t{2}",n1,n2,n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);
        
        Console.WriteLine("Produto.............:{0,15}",produto);
        Console.WriteLine("Val.Compra..........:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro...............:{0,15:p}", lucro);
        Console.WriteLine("Var.Venda...........:{0,15:c}",valorVenda);
    }
    }
