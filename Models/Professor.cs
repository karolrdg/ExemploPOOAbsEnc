using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }


        public override void Apresentar()
        {
            Console.WriteLine($"Professor: {NomeCompleto}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}, Salário: {Salario}");
        }
    }
}