using System;
using System.Collections.Generic;

namespace GFT_PESSOA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 4:
            List<Pessoa> p1 = new List<Pessoa>();

            p1.Add(new Pessoa("João", 15 ));
            p1.Add(new Pessoa("Leandro", 21));
            p1.Add(new Pessoa("Paulo", 17));
            p1.Add(new Pessoa("Jessica", 18));


            int idade = 0;
            String nomeMaior = "";

            for (int i = 0; i < p1.Count; i++)
            {
                if (p1[i].GetIdade() > idade)
                {   
                    idade = p1[i].GetIdade();
                    nomeMaior = p1[i].GetNome();
                }
            }
            System.Console.WriteLine(nomeMaior + " é a pessoa mais velha ");



            //Exercicio 5

            System.Console.WriteLine("\nPessoas: ");
            foreach (Pessoa pessoa in p1)
            {
                System.Console.WriteLine(pessoa.GetNome());
            }


            for (int i = 0; i < p1.Count; i++) {
			    if (p1[i].GetIdade() < 18) {
                    p1.Remove(p1[i]);
			}
        }


            System.Console.WriteLine("\nMaiores: ");
            foreach (Pessoa pessoa in p1)
            {
                System.Console.WriteLine(pessoa.GetNome());
            }

          //Exercicio 6
           for (int i = 0; i < p1.Count; i++) {
			    if (p1[i].GetNome().Equals("Jessica")) 
                {
                    System.Console.WriteLine("\nJessica possue " + p1[i].GetIdade() + " anos");
                }
           }
        }
    }
}  