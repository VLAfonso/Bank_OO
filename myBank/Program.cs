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

            Console.WriteLine("O titular da conta é: "+ contaDaVirginia.titular);
            Console.WriteLine("O titular da conta é: "+ contaDoMateus.titular);
            Console.WriteLine("O titular da conta é: "+ contaDoJonatan.titular);
        }
    }
}
