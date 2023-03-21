using System;

namespace stringReverse.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Exemplo de string a ser invertida";
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            string strInvertida = new string(arr);
            Console.WriteLine(strInvertida);
        }
    }
}
