using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ClothesInventoryControl.cs
{
    public class Program
    {
        static void Menu()
        {
            Console.WriteLine("Bem vinda(o) ao seu closet!");
            Console.WriteLine("Mantenha o controle de suas peças :)");
            Console.WriteLine("VAMOS LÁ!!");
            MyCloset myCloset = new MyCloset();

            var option = 0;
            while (option != 9)
            {
                Console.WriteLine("Adicionar nova peça, digite 1 para Shoes ou 2 para Clothes ou 3 para vizualiar o Closet e 9 para sair!");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        RegisterShoes(myCloset);
                        break;

                    case 2:
                        RegisterClothes(myCloset);
                        break;
                    case 3:
                        ClosetInventory(myCloset);
                        break;
                }
            }
            Console.WriteLine("Ate mais!!");
        }
        static void Main(string[] args)
        {
            Menu();

        }

        private static void RegisterShoes(MyCloset myCloset)
        {
            Console.WriteLine("Você selecionou o Item Shoes.");
            Console.WriteLine("1 para Sneakers ou 2 para Sandal! ");

            var type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.WriteLine("Você esta adicionando um item á: Sneakers");
                    break;
                case 2:
                    Console.WriteLine("Você esta adicionando um item á: Sandal");
                    break;
            }
            Console.WriteLine("Tamanho do calçado:");
            var tamanhoCalcado = int.Parse(Console.ReadLine());

            Console.WriteLine("Cor do calçado:");
            var corCalcado = Console.ReadLine();

            Console.WriteLine("Marca do calçado:");
            var marcaCalcado = Console.ReadLine();

            var tipoShoes = (ShoesType)type - 1;

            var shoes = new Shoes(tipoShoes, marcaCalcado, tamanhoCalcado, corCalcado);

            myCloset.AddShoes(shoes);

            Console.WriteLine("Item adicionado com sucesso!!!");
        }

        private static void RegisterClothes(MyCloset myCloset)
        {
            Console.WriteLine("Você selecionou o Item Clothes.");
            Console.WriteLine("1 para Dress, 2 para Denim ou 3 para Shirt ");

            var type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Console.WriteLine("Você esta adicionando um item á Dress");
                    break;
                case 2:
                    Console.WriteLine("Você esta adicionando um item á Denim");
                    break;
                case 3:
                    Console.WriteLine("Você esta adicionando um item á Shirt");
                    break;
            }
            Console.WriteLine("Tamanho da peça:");
            var tamanhoPeca = (Console.ReadLine());

            Console.WriteLine("Cor da peça:");
            var corPeca = Console.ReadLine();

            Console.WriteLine("Modelagem da peça:");
            var modelagemPeca = Console.ReadLine();

            var tipoClothes = (ClothesType)type - 1;

            var clothes = new Clothes(tipoClothes, tamanhoPeca, corPeca, modelagemPeca);

            myCloset.AddClothes(clothes);

            Console.WriteLine("Item adicionado com sucesso!!!");
        }

        private static void ClosetInventory(MyCloset closet)
        {
            Console.WriteLine("Você selecionou visualizar Closet.");

            if (closet.Shoes.Any())
            {
                var numShoes = closet.Shoes.Count();
                Console.WriteLine($"Você possui {numShoes} sapatos.");
                Console.WriteLine("Você deseja ver detalhes ou excluir algum item? sim para visualizar ou excluir item, nao parar retornar ao menu!");
                var opcao = (Console.ReadLine());
                switch (opcao)
                {
                    case "sim":
                        DetailsShoes(closet.Shoes);
                        RemoveItemShoes(closet);
                        break;

                    default:
                        Console.WriteLine("Retornando ao menu...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Você não possuí Sapatos adicionados!");
            }

            if (closet.Clothes.Any())
            {
                var numClothes = closet.Clothes.Count();
                Console.WriteLine($"Você possui {numClothes} roupas.");
                Console.WriteLine("Você deseja ver detalhes? \n " +
                    "sim para visualizar, nao parar retornar ao menu!");
                var opcao = (Console.ReadLine());
                switch (opcao)
                {
                    case "sim":
                        DetailsClothes(closet.Clothes);
                        RemoveItemClothes(closet);
                        break;

                    default:
                        Console.WriteLine("Retornando ao menu...");
                        break;
                }
            }

            else
            {
                Console.WriteLine("Você não possuí Roupas adicionados!");
            }

        }
        public static void DetailsShoes(List<Shoes> shoes)
        {
            foreach (var shoe in shoes)
            {
                Console.WriteLine($"Detalhe de seus sapatos disponiveis:{shoes.IndexOf(shoe) + 1} - {shoe.Type}, {shoe.Brand}, {shoe.Size}, {shoe.Color}");
            }
        }

        public static void DetailsClothes(List<Clothes> clothes)
        {
            foreach (var clothe in clothes)
            {
                Console.WriteLine($"Detalhes de suas roupas disponiveis: {clothes.IndexOf(clothe)+1} - {clothe.Type}, {clothe.Size},{clothe.Color}, {clothe.Modeling}");
            }
        }

        public static void RemoveItemShoes (MyCloset closet)
        {
            
            Console.WriteLine("Escreva a linha que esta o item a ser excluido (ex: 14)");
            var line = int.Parse(Console.ReadLine())-1;
            closet.Shoes.RemoveAt(line);

        }

        public static void RemoveItemClothes(MyCloset closet)
        {

            Console.WriteLine("Escreva a linha que esta o item a ser excluido (ex: 14)");
            var line = int.Parse(Console.ReadLine());
            closet.Clothes.RemoveAt(line);

        }
    } 
}
