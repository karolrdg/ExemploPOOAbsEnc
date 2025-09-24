// Arquivo: ContaCorrente.cs

using System;

namespace ExemploPoo.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
            : base(numeroConta, saldoInicial) { }

        public override void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor}.");
            }
        }
    }
}