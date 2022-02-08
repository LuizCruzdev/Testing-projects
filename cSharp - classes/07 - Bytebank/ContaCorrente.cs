
namespace _07_Bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}

        public static int TotaldeContasCriadas { get; private set; }

        public static int ObterTotaldeContas()
        { 
            return TotaldeContasCriadas;
        }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }

        }
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


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            ContaCorrente.TotaldeContasCriadas++;
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