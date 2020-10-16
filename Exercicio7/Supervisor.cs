using System;
public class Supervisor : Funcionario{

     public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario) 
    {
    }

    public override double Bonificacao()
    {  
        double bonificacao = base.Bonificacao() + 5000.00;
        System.Console.WriteLine("Funcionário: " + base.GetNome() + " Bonificacao: " + "R$" +  bonificacao.ToString("F2"));
        return bonificacao;
    }

}