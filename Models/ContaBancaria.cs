namespace ExemploPOOAbsEnc.Models
{
    public abstract class ContaBancaria
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}




























// namespace ExemploPoo.Models

// // {
//     public abstract class ContaBancaria
//     {
//         public int NumeroConta { get; set; }
//         protected decimal saldo;

//         public ContaBancaria(int numeroConta, decimal saldoInicial)
//         {
//             NumeroConta = numeroConta;
//             saldo = saldoInicial;
//         }

//         public void ExibirSaldo()
//         {
//             Console.WriteLine($"Saldo atual: {saldo}");
//         }

//         public abstract void Sacar(decimal valor);
//     }
// }