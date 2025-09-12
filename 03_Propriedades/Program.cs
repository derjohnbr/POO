using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("12345-6");
            conta.setNome("Éder John");
            //conta.Numero = "12345-6";

            //conta.saldo = -1000.00M;
            conta.Depositar(-1000.00M);

            //Utilizando o acessador
            conta.setSaldo(1000.00M);
            //Console.WriteLine($"Saldo atual: {conta.getSaldo():C2}");
            conta.ImprimirSaldo();

            while (true)
            {
                Console.Write($"\nInforme a Operação [D] Depostitar [S] Sacacar [E] Sair: ");
                string operacao = Console.ReadLine().ToUpper();

                if (operacao == "D")
                {
                    Console.Write($"\nInforme o valor para Depósito: ");
                    decimal valorDepostio = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDepostio);
                    conta.ImprimirSaldo();
                }
                else if (operacao == "S")
                {
                    Console.Write($"\nInforme o valor para Saque: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    conta.ImprimirSaldo();
                }
                else if (operacao == "E")
                {
                    Console.WriteLine($"Conta: {conta.getNumero()} Nome: {conta.getNome()} Saldo: {conta.getSaldo()}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Operação Inválida");
                }
            }
        }
    }

    // Substitua o campo, método get/set e uso por uma propriedade somente leitura com inicialização no construtor

    public class Conta
    {
        private string nome;
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }


        // Propriedade somente leitura, inicializada no construtor
        private string numero;
        public string getNumero()
        {
            return numero;
        }

        public Conta(string numero)
        {
            this.numero = numero;
        }

        // Transformar conta Saldo em acesso provado
        private decimal saldo;

        public decimal getSaldo()
        {
            return saldo;
        }

        public void setSaldo(decimal valor)
        {
            this.Depositar(valor);
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
                saldo += valor;
            else
                Console.WriteLine($"Valor para depósito deve ser maior que zero!");
        }

        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Valor para saque deve ser maior que zero e menor ou igual ao saldo!");
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta {numero} é {saldo:C2}");
        }
    }
}
