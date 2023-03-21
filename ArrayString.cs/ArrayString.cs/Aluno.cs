using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayString.cs
{
    internal class Aluno
    {
        public Aluno(string nome, int numeroMatricula, int turma, string turno)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
            Turma = turma;
            Turno = turno;
        }

        public string Nome { get; set; }

        public int NumeroMatricula { get; set; }

        public int Turma { get; set; }

        public string Turno { get; set; }
    }

   
}
