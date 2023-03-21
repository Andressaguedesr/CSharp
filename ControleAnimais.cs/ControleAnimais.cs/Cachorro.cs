using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ControleAnimais.cs
{
    public class Cachorro : Animal
    {
        public Cachorro (string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
    }
}
