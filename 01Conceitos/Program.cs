using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "Lucas";
            obj.idade = 23;
            obj.mensagem();
        }
    }
}