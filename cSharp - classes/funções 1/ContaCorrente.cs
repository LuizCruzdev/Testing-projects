
namespace Bytebank
{
    public class ContaCorrente
    {
        public Cliente titular = null;
        public int agencia;
        public int numero;
        public double saldo = 200;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return "Saldo Insuficiente";
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência concluída";
            }
        }
    }
}