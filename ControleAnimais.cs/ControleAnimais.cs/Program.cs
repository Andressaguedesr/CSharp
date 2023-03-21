using System;

namespace ControleAnimais.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 5 nomes e tipos de animais:");
            var contadorgato = 0;
            var contadorpeixe = 0;
            var contadorcachorro = 0;
            string nome = "";
            string tipo = "";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o tipo:");
                tipo = Console.ReadLine();

                Console.WriteLine("Digite o nome:");
                nome = Console.ReadLine();

                if (tipo == "Cachorro" || tipo == "cachorro")
                {
                    var cachorro = new Cachorro(nome, tipo);
                    contadorcachorro++;
                }

                if (tipo == "Gato" || tipo == "gato")
                {
                    var gato = new Gato(nome, tipo);
                    contadorgato++;
                }

                else
                {
                    var peixe = new Peixe (nome, tipo);
                    contadorpeixe++;
                    
                }
            }
            Console.WriteLine($"Foram informados {contadorpeixe} peixes ");
            Console.WriteLine($"Foram informados {contadorgato} gatos");
            Console.WriteLine($"Foram informados {contadorcachorro} cachorros");

        }
    }
}
