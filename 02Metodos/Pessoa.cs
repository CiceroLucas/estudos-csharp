using System;

class Pessoa
{
    public void apresentar()
    {
        Console.WriteLine("olá");
    }
    public void apresentar(string nome)
    {
        Console.WriteLine("olá "+nome);
    }
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade);
    }
    
}