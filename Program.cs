// Arquivo: Program.cs

using System;
using ExemploPoo.Models;

public class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente(12345, 1000);

        //Erro abaixo
        //ContaBancaria contaGenerica = new ContaBancaria(98765, 500);

        conta.ExibirSaldo();
        conta.Sacar(200);
        conta.ExibirSaldo();
    }
}