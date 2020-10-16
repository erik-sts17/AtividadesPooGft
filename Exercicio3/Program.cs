using System;
using System.Collections.Generic;

namespace GFT_PERSONAGEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago = new Mago("Merlin", 80, 40, 100f, 40, 20, 1);
            System.Console.WriteLine(mago);
            
            mago.Attack();
            mago.AprenderMagia("Ressureição");
            mago.LevelUp();
            

            Guerreiro guerreiro = new Guerreiro("Kratos", 90, 20, 100f, 10, 40, 1);
            System.Console.WriteLine(guerreiro);


            guerreiro.Attack();
            guerreiro.AprenderHabilidade("Dano em dobro");
            guerreiro.LevelUp();

            mago.GetTotal();
                                                   
        }
    }
}
