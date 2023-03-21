using Microsoft.VisualBasic;
using System;

namespace Treinando
{
    internal class Program
    {

        static void Main(string[] args)
        {
           var boleto = new Boleto();
           boleto.Vencimento = DateTime.Now;
            boleto.Valor = 350.50;

            Console.WriteLine(boleto.ToString());
        }

    }
}
