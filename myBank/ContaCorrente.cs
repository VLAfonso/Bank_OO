public class ContaCorrente{
    public string Titular { get; set; }
    public int Agencia { get; set; }
    public int Conta { get; set; }
    private double _saldo;
    public double Saldo { 
        get{
            return this._saldo;
        }
        set{
            if (value >= 0){
                this._saldo = value;
            }
        }
    }

    public ContaCorrente() {}

    public ContaCorrente(string titular, int agencia,/*  int conta, */ double saldo)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        /* this.Conta = conta; */
        this.Saldo = saldo;
    }

    public bool Sacar(double valor){
        if (this.Saldo < valor){
            return false;
        }
        else{
            this.Saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor){
        this.Saldo += valor;
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
