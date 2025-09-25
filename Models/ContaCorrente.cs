using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}