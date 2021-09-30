using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioGabriel = new Funcionario();
            funcionarioGabriel.Nome = "Gabriel";
            funcionarioGabriel.CPF = "123.456.789-00";
            funcionarioGabriel.Cargo = "Vendedor";
            funcionarioGabriel.Salario = 1000;
            
            Funcionario funcionarioFelipe = new Funcionario();
            funcionarioFelipe.Nome = "Felipe";
            funcionarioFelipe.CPF = "098.765.432-10";
            funcionarioFelipe.Cargo = "Vendedor";
            funcionarioFelipe.Salario = 1000;

            ContaCorrente contaDaVirginiaLeticiaAfonso = new ContaCorrente("Virginia Leticia Afonso", 1234, 1000, funcionarioFelipe);
            contaDaVirginiaLeticiaAfonso.Conta = 789;
            ContaCorrente contaDoMateus = new ContaCorrente("Mateus", 1234, 120, funcionarioFelipe);
            contaDoMateus.Conta = 789;
            ContaCorrente contaDoJonatan = new ContaCorrente("Jonatan", 5678, 15000, funcionarioGabriel);
            contaDoJonatan.Conta = 123;

            Console.WriteLine("As contas são:");
            Console.WriteLine("Conta 1:\nNome: "+contaDaVirginiaLeticiaAfonso.Titular+"\nAgência: "+contaDaVirginiaLeticiaAfonso.Agencia+"\nSaldo: "+contaDaVirginiaLeticiaAfonso.Saldo);
            Console.WriteLine("\nConta 2:\nNome: "+contaDoMateus.Titular+"\nAgência: "+contaDoMateus.Agencia+"\nSaldo: "+contaDoMateus.Saldo);
            Console.WriteLine("\nConta 3:\nNome: "+contaDoJonatan.Titular+"\nAgência: "+contaDoJonatan.Agencia+"\nSaldo: "+contaDoJonatan.Saldo);

            Console.WriteLine("\nOs funcinários são:");
            Console.WriteLine("Funcionario 1:\nNome: "+funcionarioGabriel.Nome+"\nCPF: "+funcionarioGabriel.CPF+"\nCargo: "+funcionarioGabriel.Cargo+"\nSalário: "+funcionarioGabriel.Salario+"\nComissão: "+funcionarioGabriel.Comissao);
            Console.WriteLine("\nFuncionario 2:\nNome: "+funcionarioFelipe.Nome+"\nCPF: "+funcionarioFelipe.CPF+"\nCargo: "+funcionarioFelipe.Cargo+"\nSalário: "+funcionarioFelipe.Salario+"\nComissão: "+funcionarioFelipe.Comissao);

            Console.WriteLine("\nSacar R$100,00 da conta do Jonatan.");
            contaDoJonatan.Sacar(100);
            Console.WriteLine("O saldo da conta do Jonatan é: "+ contaDoJonatan.Saldo);

            Console.WriteLine("\nDepositar R$380,00 na conta do Mateus.");
            contaDoMateus.Depositar(380);
            Console.WriteLine("O saldo da conta do Mateus é: "+ contaDoMateus.Saldo);

            Console.WriteLine("\nTransferir R$500,00 da conta do Jonatan para a conta da Virginia.");
            contaDoJonatan.Transferir(500, contaDaVirginiaLeticiaAfonso);
            Console.WriteLine("O saldo da conta do Jonatan é: "+ contaDoJonatan.Saldo);
            Console.WriteLine("O saldo da conta da Virginia é: "+ contaDaVirginiaLeticiaAfonso.Saldo);

            Console.WriteLine("\nO número de contas criadas é: "+ContaCorrente.TotaldeContasCriadas);
        }
    }
}
