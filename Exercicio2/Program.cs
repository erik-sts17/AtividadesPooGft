using System;
using System.Collections.Generic;

namespace GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J.K Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Aneis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("Xbox one", 1500, 500, "Microsoft", "Slim", false);


            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);
            

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(xbox);
            games.Add(ps4Usado);

            Loja americanas = new Loja("Americanas", "124546546", livros, games);

            l2.CalculaImposto();
            l3.CalculaImposto();
            
            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();
            

            americanas.listaLivros();
            americanas.listaVideoGames();        
            americanas.CalculaPatrimonio();
            
        }      
    }
}