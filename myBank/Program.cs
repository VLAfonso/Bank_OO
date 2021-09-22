using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaVirginia = new ContaCorrente("Virginia", 1234, /* 789, */ 100.50);
            
            ContaCorrente contaDoMateus = new ContaCorrente("Mateus", 1234, /* 790, */ 120);

            ContaCorrente contaDoJonatan = new ContaCorrente("Jonatan", 5678, /* 312, */ 15234.89);
            
            contaDaVirginia.Sacar(50);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.Saldo);

            /* contaDaVirginia.Depositar(100);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.Saldo);

            contaDaVirginia.Transferir(150.5, contaDoMateus);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.Saldo);
            Console.WriteLine("O saldo da conta do Mateus é: "+ contaDoMateus.Saldo); */
        }
    }
}
