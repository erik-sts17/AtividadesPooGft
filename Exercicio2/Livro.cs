using System;
public class Livro : Produto, Imposto{
    private String _autor;
    private String _tema;
    private int _qtdPag;

    public Livro(){}

    public Livro(String nome, double preco, int qtd, String autor, String tema, int qtdPag) : base(nome, preco, qtd){
        _autor = autor;
        _tema = tema;
        _qtdPag = qtdPag;
    }

    public String GetAutor(){
        return _autor;
    }

    public void SetAutor(String autor){
        _autor = autor;
    }
    public String GetTema(){
        return _tema;
    }

    public void SetTema(String tema){
        _tema = tema;
    }
    public int GetPaginas(){
        return _qtdPag;
    }

    public void SetPaginas(int qntPag){
        _qtdPag = qntPag;
    }


    public double CalculaImposto(){
        if (_tema == "educativo")
        {
            System.Console.WriteLine("Livro educativo não tem imposto");
            return 0;
            
        }

        else{
              
            double impostoLivro = (base.GetPreco() * 0.10);
            System.Console.WriteLine("R$ " + impostoLivro.ToString("F2") + " de impostos sobre o livro " + base.GetNome());
            return impostoLivro;
            }
    }
}