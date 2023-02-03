using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = 0;
        double irrf = 0;
        double inss = 0;
        double valorPorDependentes = 0;
        double salarioLiquido = 0;
        int quantidadeDependetes = 0;
        double valorDeduzido = 0;


        Console.WriteLine("Digite o seu salario ");
        salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Posssui algum dependete? \n (Exemplo filho abaixo de 21 anos, conjuge tec)");
        string dependente = Console.ReadLine();

        if(dependente == "sim" || dependente == "s" || dependente == "yes")
        {
            Console.WriteLine("Quantos dependente você possue?");
            quantidadeDependetes = Convert.ToInt32(Console.ReadLine());

            valorPorDependentes = quantidadeDependetes * 189.59;
        }


        if (salario < 1302)
        {
            inss = (salario * 0.75) * 0.1;
        }
        if (salario > 1302.01 && salario < 2571.29)
        {
            inss = ((salario * 0.9) * 0.1) - 19.53;
        }


        valorDeduzido = salario - inss - valorPorDependentes;

        if (valorDeduzido > 1903.98 && valorDeduzido < 2826.66)
        {
            irrf = ((valorDeduzido * 0.75) * 0.1) - 142.80;
        }

        salarioLiquido = valorDeduzido - inss - irrf;

        Console.WriteLine("Seu descontos são: \n INSS - " + inss + "\n" + "IRRF - " + irrf + "\n seu salario liquido " + salarioLiquido + "\n você possue " + quantidadeDependetes + " dependete(s)");
    }
}