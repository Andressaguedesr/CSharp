using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ControleAnimais.cs
{
    public class Peixe : Animal   
    {
        public Peixe (string nome, string tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }
    }
}
