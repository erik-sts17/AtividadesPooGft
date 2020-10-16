using System;

namespace GFT_BONIFICA
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Bruno", 37, 10000.00); 
            Supervisor supervisor = new Supervisor("Erik", 20, 2000.00);
            Vendedor vendedor = new Vendedor("Fabio", 25, 1500.00); 

            gerente.Bonificacao();
            supervisor.Bonificacao();
            vendedor.Bonificacao();


        }
    }
}
