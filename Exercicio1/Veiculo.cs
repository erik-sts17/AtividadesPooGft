using System;

public class Veiculo{
    private String _marca;
    private String _modelo;
    private String _placa;
    private String _cor;

    private float _km;

    private Boolean _isLigado;

    private int _litrosCombustivel;

    private int _velocidade;

    private double _preco;

        public String GetMarca(){
            return  _marca;
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

        public double GetPreco(){
            return _preco;
        }

        public void SetPreco(double preco){
            _preco = preco;
        }

        public String GetPlaca(){
            return _placa;
        }

        public void SetPlaca(String placa){
            _placa = placa;
        }

        public String GetCor(){
            return _cor;
        }
     
        public void SetCor(String cor){

            _cor = cor;
        }
    
        public float GetKm(){
            return _km;
        }
    
        public void SetKm(float km){

            _km = km;
        }

        public Boolean GetLigado(){
            return _isLigado;
        }
       
       public int GetLitrosCombustivel(){
            return _litrosCombustivel;
        }
      
        public void Acelerar(){
          if (_isLigado)
          {
              _velocidade += 20;
          }
          else
          {
              System.Console.WriteLine("Veiculo esta desligado");
          }
        }   

        public int GetVelocidade(){
            return _velocidade;
        }
       
        public void Abastecer(int litros){
            if (litros <= 60){
                    _litrosCombustivel += litros;
                    }
            else
            {
                System.Console.WriteLine("---Capacidade maxima: 60 litros----");
            }
         }
      
        public void Frear(){
            if (_velocidade == 0){
                   System.Console.WriteLine("Veiculo Parado");
                    }
            else
            {
               _velocidade -= 20;
            }
        }
    
        public void Pintar (String cor){
            _cor = cor;
        }

        public void Ligar (){
           if (_isLigado)
           {    
               System.Console.WriteLine("Veiculo ja esta ligado");
           }

           else
           {
               _isLigado = true;
           }
        }

        public void Desligar (){
          if (_isLigado == false)
           {    
               System.Console.WriteLine("Veiculo já esta desligado");
           }

           else
           {
               _isLigado = false;
           }
        }
    }