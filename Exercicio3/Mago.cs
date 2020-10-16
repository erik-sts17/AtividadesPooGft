using System;
using System.Collections.Generic;
public class Mago : Personagem{

    List<String> _magia;

    public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) :
                base(nome, vida, mana, xp, inteligencia, forca, level)
    {
      _magia = new List<String>();
    }

     public override void LevelUp(){
        base.SetLevel(GetLevel()+1);
        base.SetForca(GetForca() +4);
        base.SetVida(GetVida() +4);
        base.setInteligencia(GetInteligencia()+8);
        base.SetMana(GetMana()+ 8);
        base.SeTXp(GetXp()+100f);
        System.Console.WriteLine("---------------------------------------------");
        System.Console.WriteLine("Parabens, voce subiu de level! Level atual: " + base.GetLevel());
        System.Console.WriteLine("---------------------------------------------" + "\n");
        
    }

    public String AprenderMagia(String magia){
        _magia.Add(magia);
        System.Console.WriteLine("--------------------------------------------");
        String magiaAdquirida =  "Magia: " + magia +  " adquirida";
        System.Console.WriteLine(magiaAdquirida);
        System.Console.WriteLine("--------------------------------------------" + "\n");
        return magiaAdquirida;
    }

    public void Attack(){
        Random num = new Random();
        int ataque = base.GetInteligencia() * base.GetLevel() + num.Next(0,300);
        System.Console.WriteLine("--------------------------------------------");
        System.Console.WriteLine(base.GetNome() + " realizou ataque de dano " + ataque);
        System.Console.WriteLine("--------------------------------------------" + "\n");
    }

}
