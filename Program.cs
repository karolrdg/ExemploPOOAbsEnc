using System;
using ExemploPoo.Models;

ContaCorrente conta = new(12345, 1000);
conta.ExibirSaldo();
conta.Sacar(200);
conta.ExibirSaldo();