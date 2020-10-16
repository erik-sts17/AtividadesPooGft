using System;
public class Funcionario{
    private String _nome;
    private int _idade;
    private double _salario;

    public Funcionario(string nome, int idade, double salario)
    {
        _nome = nome;
        _idade = idade;
        _salario = salario;
    }

    public String GetNome()
    {
        return _nome;
    }

    public void SetNome(String nome)
    {
        _nome = nome;
    }

    public int GetIdade()
    {
        return _idade;
    }

    public void SetIdade(int idade)
    {
        _idade = idade;
    }

    public double GetSalario()
    {
        return _salario;
    }

    public void SetSalario(double salario)
    {
        _salario = salario;
    }

    public virtual double Bonificacao(){
        return _salario;
    }

}
