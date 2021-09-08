using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaVirginia = new ContaCorrente();

            contaDaVirginia.titular = "Barbara";
            contaDaVirginia.agencia = 1234;
            contaDaVirginia.conta = 789;
            contaDaVirginia.saldo = 100.50;
            
            ContaCorrente contaDoMateus = new ContaCorrente();

            contaDoMateus.titular = "Mateus";
            contaDoMateus.agencia = 1234;
            contaDoMateus.conta = 790;
            contaDoMateus.saldo = 120;

            Console.WriteLine("O titular da conta é: "+ contaDaVirginia.titular);
            Console.WriteLine("O titular da conta é: "+ contaDoMateus.titular);
        }
    }
}
