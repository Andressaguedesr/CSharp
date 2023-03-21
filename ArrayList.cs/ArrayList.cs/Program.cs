using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.ComponentModel.Design;

namespace ArrayListExc.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();
            Menu(arlist);            
        }

        static void Menu(ArrayList arraylist)
        {
            Console.WriteLine("Ola, este programa é um ArrayList que armazena números inteiros! A seguir, você podera escolher uma das opções..");

            Console.WriteLine("Digiste uma opção: \n" +
                "1- Inserir elemento á lista \n" +
                "2- Remover elemento da lista \n" +
                "3- Listar elementos \n" +
                "4- Pesquisar elemento na lista \n" +
                "5- Ordenar elementos \n" +
                "6- Sair do sistema:");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    InsertElement(arraylist);
                    break;
                case 2:
                    RemoveElement(arraylist);
                    break;
                case 3:
                    ListElements(arraylist);
                    break;
                case 4:
                    SearchElement(arraylist);
                    break;
                case 5:
                    OrderElements(arraylist);
                    break;
                case 6:
                    ExitSystem();
                    break;
                default: Console.WriteLine("ATENÇÃO! É necessario escolher uma das opções validas!!");
                    Menu(arraylist);
                    break;
            }
            
            Menu(arraylist);
        }
        static void InsertElement(ArrayList arraylist)
        {
            Console.WriteLine("Digite um numero inteiro, para adicionar a lista.");
            int element = int.Parse(Console.ReadLine());
            arraylist.Add(element);
        }

        static void RemoveElement(ArrayList arraylist)
        {
            ListElements(arraylist);
            Console.WriteLine("Digite o numero que deseja remover (ex: 14)");
            var number = int.Parse(Console.ReadLine());
            int index = arraylist.IndexOf(number);
            

            if (index == -1)
            {
                Console.WriteLine("Este numero não existe dentro do ArrayList!");
                
            }
            else
            {
                arraylist.RemoveAt(index);
            }
        }

        static void ListElements(ArrayList arraylist)
        {
            Console.WriteLine("-------------------");

            foreach (var element in arraylist)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------");

        }

        static void SearchElement(ArrayList arraylist)
        {
            ListElements(arraylist);
            Console.WriteLine("Digite o numero que deseja encontrar/pesquisar");
            var number = int.Parse(Console.ReadLine());
            int index = arraylist.IndexOf(number);

            if (index == -1)
            {
                Console.WriteLine("Este numero não existe dentro da lista!");

            }
            else
            {
                Console.WriteLine($"O elemento {number} pesquisado esta na lista! ");
                ListElements(arraylist);
            }
        }

        static void OrderElements(ArrayList arraylist)
        {
            Console.WriteLine("Ordenando......");
            arraylist.Sort();
            ListElements(arraylist);             
        }

        static void ExitSystem()
        {
            Console.WriteLine("TCHAUUUU! :*");
            Environment.Exit(1);
        }
    }
}
