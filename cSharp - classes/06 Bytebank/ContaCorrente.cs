
namespace _06_Bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 200;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }



        
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return "Saldo Insuficiente";
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência concluída";
            }
        }
    }
}