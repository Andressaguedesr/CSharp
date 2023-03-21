using System;

namespace array.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Array = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Elemento {i + 1} do Array: ");
            //    Array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine($"O Maior Valor do Array é {AcharMaior(Array)}");
            //Console.WriteLine($"O Menor Valor do Array é {AcharMenor(Array)}");
            //Console.WriteLine($"Existem {ContarPares(Array)} elementos Pares no Array");
            //Console.WriteLine($"Existem {ContarImpares(Array)} elementos Ímpares no Array");
            //Console.WriteLine($"A Média Aritmética dos elementos do Array é {AcharMedia(Array)}");
            //Console.ReadKey();
            estrategia(5);

        }
        public static int estrategia(int n)
        {
            Console.WriteLine(n + " ");
            if (n == 1) 
                return 1;
            else 
                return (n * estrategia(n - 1));
        }
    }
    
}

    
//        static public int AcharMaior (int[] Array)
//        {
//            int Maior = Array[0];

//            for (int i = 0; i < 10; i++)
//            {
//                if (Array[i] > Maior)
//                {
//                    Maior = Array[i];
//                }
//            }
//            return Maior;
//        }

//        static int AcharMenor(int[] Array)
//        {
//            int Menor = Array [0];

//            for (int i = 0; i < 10; i++)
//            {
//                if (Array[i] < Menor)
//                {
//                    Menor = Array[i];
//                }
//            }
//            return Menor;
//        }

//        static int ContarPares(int[] Array)
//        {
//            int Pares = 0;

//            for (int i = 0; i < 10; i++)
//            {
//                if (Array[i] % 2 == 0)
//                {
//                    Pares++;
//                }

//            }
//            return Pares;
//        }
//            static int ContarImpares(int[] Array)
//            {
//                int Impares = 0;

//                for (int i = 0; i < 10; i++)
//                {
//                    if (Array[i] %2 != 0)
//                    {
//                        Impares++;
//                    }

//                }
//                return Impares;
//            }

//            static double AcharMedia (int[] Array)
//            {
//                 double Media = 0;
            
//                 for (int i = 0; i < 10; i++)
//                 {
//                    Media += Array[i];
//                 }
//                 return Media /10;
//            }
        
//    }
//}