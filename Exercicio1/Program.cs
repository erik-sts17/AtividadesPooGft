using System;

namespace ExercicioVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.SetMarca("Chevrolet");
            veiculo.SetModelo("Onix");
            veiculo.SetPlaca("FEB-4589");
            veiculo.SetCor("Preto");
            veiculo.SetKm(10.003f);
            veiculo.SetPreco(40000);


            System.Console.WriteLine(veiculo.GetMarca() + " " + veiculo.GetModelo() + " " + veiculo.GetPlaca() + " " + veiculo.GetCor() + " " 
                                    + veiculo.GetKm() +  "km"  + " " +  "R$" + veiculo.GetPreco().ToString("F2"));

            System.Console.WriteLine("\n-------------------------\n");

            veiculo.Pintar("Azul");
            System.Console.WriteLine( "Nova cor: " + veiculo.GetCor());
            
            veiculo.Abastecer(60);
            System.Console.WriteLine("Tanque: " + veiculo.GetLitrosCombustivel() + " litros");

            veiculo.Ligar();
            System.Console.WriteLine("Em funcionamento? " + veiculo.GetLigado());

            veiculo.Acelerar();
            veiculo.Acelerar();
            System.Console.WriteLine( "Velocidade: " + veiculo.GetVelocidade() + " km/h");

            veiculo.Frear();
            veiculo.Frear();
            System.Console.WriteLine( "Velocidade: " + veiculo.GetVelocidade() + " km/h");

            veiculo.Desligar();
            System.Console.WriteLine("Em funcionamento? " + veiculo.GetLigado());

        }
    }
}
