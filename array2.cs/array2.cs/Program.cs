using System;

namespace array2.cs
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var ListaProdutos = new Produto[3];

           
            Console.WriteLine("Realize o cadastro de 3 produtos!");

            for (int i = 0; i < 3; i++)
            {            
                Console.WriteLine("Qual o nome do produto?");
                var Nome = (Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Qual o preço por unidade?");
                var Preco = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Quantas unidades do produto se tem no estoque?");
                var Quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Qual a data de validade do produto? (MM/AA)");
                var DataValidade = DateTime.Parse(Console.ReadLine());

                var produto = new Produto
                {
                    NomeProduto = Nome,
                    PrecoProduto = Preco,
                    QuantidadeProduto = Quantidade,
                    DataValidade = DataValidade
                };

                ListaProdutos[i] = produto; 
            }

            Console.Clear();
            Console.WriteLine("exibir produtos a partir de qual valor?");
            var PrecoMinimo = double.Parse(Console.ReadLine());

            foreach (var Produto in ListaProdutos)
            {
                if (Produto.PrecoProduto >= PrecoMinimo)


                Console.WriteLine($"Os produtos com valor minimo ou igual ao escolhido são: {Produto.NomeProduto}");
               
            }


        }

        
    }
}
