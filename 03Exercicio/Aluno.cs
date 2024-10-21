using System;

class Aluno
{
    public string? nome;
    public double nota1, nota2;


    public double media()
    {
        double somaNota = (nota1 + nota2)/2;

        return somaNota;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);

        Console.WriteLine(nome+" está "+obterSituacao+" com média "+obterMedia);
    }
}