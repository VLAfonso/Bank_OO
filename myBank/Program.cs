using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaVirginia = new ContaCorrente("Virginia", 1234, 789, 100.50);
            
            ContaCorrente contaDoMateus = new ContaCorrente("Mateus", 1234, 790, 120);

            ContaCorrente contaDoJonatan = new ContaCorrente("Jonatan", 5678, 312, 15234.89);
            
            bool retorno = contaDaVirginia.Sacar(50);
            Console.WriteLine(retorno);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.saldo);

            contaDaVirginia.Depositar(150);

            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.saldo);

            contaDoJonatan.Transferir(200, contaDaVirginia);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginia.saldo);
            Console.WriteLine("O saldo da conta do Jonatan é: "+ contaDoJonatan.saldo);

        }
    }
}
