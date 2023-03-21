using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace sorteadordenomes.cs
{
    public class sorteadordenomes
    {
        public List<string> Names { get; set; }
        public sorteadordenomes()
        {
            Names = new List<string>();
            
        }
        public void AddNames(string name)
        {
            Names.Add(name);

        }
        public void SortearName ()
        {
            Random randNum = new Random();
            var posicao = randNum.Next(0, Names.Count -1);
            Console.WriteLine(Names[posicao]);
        }
    }
}
