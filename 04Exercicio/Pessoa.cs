using System;

class Pessoa
{
    public double peso, altura;

    public double calcImc()
    {
        double somaImc = peso/(altura * altura);
        return somaImc;
    }

    public string classificarImc(double imc)
    {
        var classificacoes = new (double Limite, string Classificacao)[]
        {
            (18.5, "Abaixo do peso"),
            (24.9, "Peso normal"),
            (29.9, "Sobrepeso"),
            (34.9, "Obesidade grau 1"),
            (39.9, "Obesidade grau 2"),
            (double.MaxValue, "Obesidade grau 3")
        };

         foreach (var classificacao in classificacoes)
        {
            if (imc <= classificacao.Limite)
            {
                return classificacao.Classificacao;
            }
        }

        return "Classificação desconhecida"; 
    }

    public void exibirResultado()
    {
        double imc = calcImc();
        string classificacao = classificarImc(imc);
        Console.WriteLine($"IMC: {imc:F2}. Classificação: {classificacao}");
    }

}