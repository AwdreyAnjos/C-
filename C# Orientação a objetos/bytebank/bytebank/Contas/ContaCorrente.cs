using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        //------------------ DADOS DA CONTA --------------------------------
        public static int TotalDeContasCriadas { get; private set; }
        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set
            {
                if(value > 0)
                {
                    this.numeroAgencia = value;
                }
                
            }
        }
        public string conta { get; set; }
        // saldo é privado pois precisa de validação para acrecentar valores
        private double saldo = 100;
        // Cliente vem de outra classe
        public Cliente titular; 
        //------------------------------------------------------------------

        //------------------ EXIBIR DADOS DA CONTA -------------------------
        public void exibirDadosConta()
        {
            Console.WriteLine($"Titular da Conta: {titular.nome}");
            Console.WriteLine($"Titular da Conta: {titular.cpf}");
            Console.WriteLine($"Titular da Conta: {titular.profissao}");
            Console.WriteLine($"Número da Conta: {conta} ");
            Console.WriteLine($"Agência: {numeroAgencia}");
            Console.WriteLine($"Saldo $ {String.Format("{0:0.00}", saldo)}");

        }
        // Mostra o saldo para o usuário
        public double getSaldo()
        {
            return this.saldo;
        }
        //------------------------------------------------------------------

        //---------------------- MOVIMENTAR CONTA --------------------------
        // para definir o saldo inicial da conta 
        public void setSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        // ----> DEPOSITAR VALOR 
        public void Depositar(double valor) 
        {
            this.saldo += valor;
        }
        // ----> SAQUE UM VALOR 
        public bool Sacar(double valor) 
        {

            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
                return false;
            }
        }
        // ----> TRANSFERIR UM VALOR PARA OUTRA CONTA
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        // -----------------------------------------------------------
        // -------------- Parametros Obrigadores ---------------------
        public ContaCorrente(int numeroAgencia, string numero_conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.conta = numero_conta;
            TotalDeContasCriadas++;

        }
    }
}
