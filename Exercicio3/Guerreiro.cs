using System;
using System.Collections.Generic;

public class Guerreiro : Personagem{

    List<String> _habilidade;
    public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) :
                base(nome, vida, mana, xp, inteligencia, forca, level)
    {
      _habilidade = new List<string>();
    }

    public override void LevelUp(){
        base.SetLevel(GetLevel()+1);
        base.SetForca(GetForca() +8);
        base.SetVida(GetVida() +8);
        base.setInteligencia(GetInteligencia()+4);
        base.SetMana(GetMana()+4);
        base.SeTXp(GetXp()+100f);
        System.Console.WriteLine("---------------------------------------------" );
        System.Console.WriteLine("Parabens, voce subiu de level! Level atual: " + base.GetLevel());
        System.Console.WriteLine("---------------------------------------------" + "\n");
    }

    public String AprenderHabilidade(String habilidade){
        _habilidade.Add(habilidade);
        System.Console.WriteLine("--------------------------------------------");
        String habilidadeAdquirida =  "Habilidade: " + habilidade +  " adquirida";
        System.Console.WriteLine(habilidadeAdquirida);
        System.Console.WriteLine("--------------------------------------------" + "\n");
        return habilidadeAdquirida;
    }

    public void Attack(){
        Random num = new Random();
        int ataque = base.GetForca() * base.GetLevel() + num.Next(0,300);
        System.Console.WriteLine("--------------------------------------------");
        System.Console.WriteLine(base.GetNome() + " realizou ataque de dano " + ataque);
        System.Console.WriteLine("--------------------------------------------" + "\n");
    }
}