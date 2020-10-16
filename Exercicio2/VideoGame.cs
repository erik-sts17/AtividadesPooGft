using System;
public class VideoGame : Produto, Imposto {
    private String _marca;
    private String _modelo;
    private Boolean _isUsado; 

    public VideoGame(){}

    public VideoGame(String nome, double preco, int qtd, String marca, String modelo, Boolean isUsado) : base(nome, preco, qtd){

        _marca = marca;
        _modelo = modelo;
        _isUsado = isUsado;
    }

    public String GetMarca(){
        return _marca;
    }

    public void SetMarca(String marca){
        _marca = marca;
    }

     public String GetModelo(){
        return _modelo;
    }

    public void SetModelo(String modelo){
        _modelo = modelo;
    }
 
    public Boolean GetIsUsado(){
        return _isUsado;
    }

    public void SetIsUsado(Boolean isusado){
        _isUsado = isusado;
    }

    public double CalculaImposto(){
        if (_isUsado == true)
        {
            double impostoGame = (base.GetPreco() * 0.25);
            System.Console.WriteLine("Imposto " + base.GetNome()  + " " +  _modelo + " usado " + "R$" + impostoGame.ToString("F2"));
            return impostoGame;
        }

        else
        {
           double ImpostoLivro = (base.GetPreco() * 0.45);
            System.Console.WriteLine("Imposto " + base.GetNome() + " " +  _modelo + " " + "R$" + ImpostoLivro.ToString("F2"));
            return ImpostoLivro;
        }
    }

        public override string ToString()
    {
        return "Video-game: " + base.GetNome() + " Modelo: " + _modelo + " preco: " + base.GetPreco().ToString("F2") 
        + " quantidade: " + base.GetQuantidade() + " em estoque";
    }
    
}