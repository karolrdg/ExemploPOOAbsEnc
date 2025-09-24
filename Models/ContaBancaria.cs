// Arquivo: ContaBancaria.cs

using System;

namespace ExemploPoo.Models
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; set; }
        protected decimal saldo;

        public ContaBancaria(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }

        public abstract void Sacar(decimal valor);
    }
}