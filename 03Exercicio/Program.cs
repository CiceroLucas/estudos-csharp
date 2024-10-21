using System;

namespace _03Excercicio;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        aluno.nome = "Lucas";
        aluno.nota1 = 10;
        aluno.nota2 = 7;
        aluno.mensagem();
    }
}
