  
using System;
public class Pessoa{
    private String _nome;
    private int _idade;


    public Pessoa(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
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

}