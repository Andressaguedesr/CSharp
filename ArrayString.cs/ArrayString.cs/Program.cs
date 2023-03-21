using System;
using System.Collections;
using System.Linq;

namespace ArrayString.cs
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

            Console.WriteLine("Digite uma opção: \n" +
                    "1- Inserir aluno ao sistema \n" +
                    "2- Remover aluno do sistema \n" +
                    "3- Listar alunos \n" +
                    "4- Pesquisar aluno \n" +
                    "5- Ordenar alunos em ordem alfabetica\n" +
                    "6- Sair do sistema:");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                    InsertStudant(arraylist);
                        break;
                    case 2:
                    RemoveStudant(arraylist);
                        break;
                    case 3:
                    ListStudant(arraylist);
                        break;
                    case 4:
                    SearchStudant(arraylist);
                        break;
                    case 5:
                    OrderStudant(arraylist);
                        break;
                    case 6:
                        ExitSystem();
                        break;
                    default:
                        Console.WriteLine("ATENÇÃO! É necessario escolher uma das opções validas!!");
                        Menu(arraylist);
                        break;
                }

                Menu(arraylist);
            }
            static void InsertStudant(ArrayList arraylist)
            {
            Console.WriteLine("Bem vindo ao amazenamento de dados do aluno, digite o que se pede a seguir..");
            Console.WriteLine("Nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Número da matricula:");
            int numeroMatricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Turma:");
            int turma = int.Parse(Console.ReadLine());
            Console.WriteLine("Turno");
            var turno = Console.ReadLine();

            var aluno = new Aluno(nome, numeroMatricula, turma, turno);
            arraylist.Add(aluno);
            }

            static void RemoveStudant(ArrayList arraylist)
            {
                ListStudant(arraylist);
                Console.WriteLine("Digite a palavra que deseja remover (ex: batata)");
                var word = Console.ReadLine();
                int index = arraylist.IndexOf(word);


                if (index == -1)
                {
                    Console.WriteLine("Esta palavra não existe dentro do ArrayList!");

                }
                else
                {
                    arraylist.RemoveAt(index);
                }
            }

            static void ListStudant(ArrayList arraylist)
            {
                Console.WriteLine("-------------------");

                foreach (Aluno element in arraylist)
                {
                    Console.WriteLine($" {element.Nome}  , {element.NumeroMatricula}  , {element.Turma} , {element.Turno}");
                }
                Console.WriteLine("-------------------");

            }

            static void SearchStudant(ArrayList arraylist)
            {
                ListStudant(arraylist);
                Console.WriteLine("Digite o aluno que deseja encontrar/pesquisar");
                var aluno = Console.ReadLine();
                int index = arraylist.IndexOf(aluno);

                if (index == -1)
                {
                    Console.WriteLine("Este aluno não existe dentro do sistema!");

                }
                else
                {
                    Console.WriteLine($"O {aluno} pesquisado esta no sistema! ");
                    ListStudant(arraylist);
                }
            }

            static void OrderStudant(ArrayList arraylist)
            {
                Console.WriteLine("Ordenando......");
                var list = arraylist.Cast<Aluno>().ToList();
                var ordered = list.OrderBy(a => a.Nome).ToList();
                arraylist = new ArrayList(ordered);
                ListStudant(arraylist);
            }

            static void ExitSystem()
            {
                Console.WriteLine("Programa finalizado");
                Environment.Exit(1);
            }
    }
}
