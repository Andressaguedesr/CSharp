using System;

namespace sorteadordenomes.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo ao sorteador de nomes!");
            sorteadordenomes sorteadordenomes= new sorteadordenomes();

            var name = "";
            while ( name != "sortear" )
            {
                Console.WriteLine("Digite o nome que você gostaria que fosse sorteado ou digite sortear ao terminar de adicionar os nomes:");
                name = Console.ReadLine();
                if (name != "sortear")
                {
                    sorteadordenomes.AddNames(name);
                }
            }
            sorteadordenomes.SortearName();
        }

    }
}
