using System;
using System.Collections;

namespace CopyArray.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();
            Menu(arlist);
        }
         static void Menu(ArrayList arraylistorigem)
         {
            Console.WriteLine("Ola, este programa é um ArrayList que armazena palavras e clona uma lista! A seguir, você podera escolher uma das opções..");

            Console.WriteLine("Digite uma opção: \n" +
                "1- Inserir palavra á lista \n" +
                "2- Listar palavras \n" +
                "3- Copiar Lista \n" +
                "4- Sair do sistema:");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    InsertWord(arraylistorigem);
                    break;
                case 2:
                    ListWords(arraylistorigem);
                    break;
                case 3:
                    var novoArrayList = CopiarArrayList(arraylistorigem);
                    ListWords(novoArrayList);
                    break;
                case 5:
                    ExitSystem();
                    break;
                default:
                    Console.WriteLine("ATENÇÃO! É necessario escolher uma das opções validas!!");
                    Menu(arraylistorigem);
                    break;
            }

            Menu(arraylistorigem);
         }
        static void InsertWord(ArrayList arraylistorigem)
        {
            Console.WriteLine("Digite uma palavra, para adicionar a lista.");
            var word = Console.ReadLine();
            arraylistorigem.Add(word);
        }
        static void ListWords(ArrayList arraylistorigem)
        {
            Console.WriteLine("-------------------");

            foreach (var word in arraylistorigem)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("-------------------");
        }

        static ArrayList CopiarArrayList (ArrayList arraylistorigem)
        {
            Console.WriteLine("-------------------");

            ArrayList novoArrayList = new ArrayList();

            foreach (var word in arraylistorigem)
            {
                novoArrayList.Add(word);
            }
            Console.WriteLine("-------------------");

            return novoArrayList;

        }

        static void ExitSystem()
        {
            Console.WriteLine("TCHAUUUU! :*");
            Environment.Exit(1);
        }
    }
    
}
