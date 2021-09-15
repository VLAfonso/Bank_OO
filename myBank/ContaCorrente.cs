public class ContaCorrente{
    public string titular;
    public int agencia;
    public int conta;
    public double saldo;

    public ContaCorrente() {}

    public ContaCorrente(string cc_titular, int cc_agencia, int cc_conta, double cc_saldo)
    {
        titular = cc_titular;
        agencia = cc_agencia;
        conta = cc_conta;
        saldo = cc_saldo;
    }

    public bool Sacar(double valor){
        if (this.saldo < valor){
            return false;
        }
        else{
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor){
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino){
        if(this.Sacar(valor)){
            contaDestino.Depositar(valor);
            return true;
        }
        else{
            return false;
        }
    }
}
