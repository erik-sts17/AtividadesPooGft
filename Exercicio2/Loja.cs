using System.Collections.Generic;
using System;
public class Loja{
    private String _nome;
    private String _cnpj;
    private List<Livro> _livros;
    private List<VideoGame> _videoGames;    
    Loja(){}

    public Loja(String nome, String cnpj, List<Livro> livros, List<VideoGame> videogames){
        _nome = nome;
        _cnpj = cnpj;
        _livros = livros;
        _videoGames = videogames;
    }

    public String GetNome(){
        return _nome;
    }     


     public String GetCnpj(){
        return _cnpj;
    } 

    public void SetCnpj(string cnpj){
        _cnpj = cnpj;
    }    

    public void SetLivros(List<Livro> livro){
        _livros = livro;
    }

    public void SetVideoGame(List<VideoGame> videoGame){
        _videoGames = videoGame;
    }

    public void listaLivros(){

        System.Console.WriteLine("-------------------------------------------------------------");

        if(_livros.Count == 0)
        {
            System.Console.WriteLine("A loja não tem livros em seu estoque");
        }
        
        else
        {
        System.Console.WriteLine("A loja " + _nome + " possui estes livros para venda: ");

        
            foreach (Livro livro in _livros)
            {
                System.Console.WriteLine(livro);
            }
        }

        System.Console.WriteLine("-------------------------------------------------------------");
    }
    public void listaVideoGames(){
          
        if(_videoGames.Count == 0)
        {
            System.Console.WriteLine("A loja não tem Video-Games em seu estoque");
        }
        
        else{
       
             System.Console.WriteLine("A loja " + _nome + " possui estes video-games para venda: ");
      
            foreach (VideoGame games in _videoGames)
            {
                System.Console.WriteLine(games);
            }
        }
        System.Console.WriteLine("-------------------------------------------------------------");
    }

        public double CalculaPatrimonio(){
          
          double total = 0;
           foreach (Produto produto in _livros)
           {
               total += (produto.GetPreco()) * produto.GetQuantidade();
           }

           foreach (Produto produto in _videoGames)
           {
               total += (produto.GetPreco()) * produto.GetQuantidade();
           }

            System.Console.Write("O patrimonio da loja: " + _nome + " é de R$ " + total.ToString("F2"));
            return total; 
        }
}