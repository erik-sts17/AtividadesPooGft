using System; 
    public abstract class Produto{
    String _nome;
    double _preco;
    int _qtd;


    public Produto(){

    }
    public Produto(String nome, double preco, int qtd){
        _nome = nome;
        _preco = preco;
        _qtd = qtd;
    }

    public String GetNome(){
        return _nome;
    }

    public void SetNome(String nome){
        _nome = nome;
    }

    public double GetPreco(){
        return _preco;
    }

    public void SetPreco(double preco){
        _preco = preco;
    }

    public double GetQuantidade(){
        return _qtd;
    }

    public void SetQuantidade(int qtd){
        _qtd = qtd;
    }

    public override string ToString()
    {
        return "Titulo: " + _nome + " , " +  "preco: " + _preco.ToString("F2") + " , " + "quantidade: " + _qtd + " em estoque ";
    }
}