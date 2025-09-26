using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nomeCompleto, DateTime dataNascimento, int idade, string endereco, int telefone, decimal salario)
            : base(nomeCompleto, dataNascimento, idade, endereco, telefone)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Salario = salario;
        }
        public decimal Salario { get; set; }


        public override void Apresentar()
        {
            Console.WriteLine($"Professor: {NomeCompleto}, Data Nascimento: {DataNascimento}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}, Salário: {Salario}");
        }
    }
}