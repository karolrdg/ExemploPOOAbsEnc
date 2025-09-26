using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nomeCompleto, DateTime dataNascimento, int idade, string endereco, int telefone, decimal salario)
            : base(nomeCompleto, dataNascimento, idade, endereco, telefone, salario)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Salario = salario;
        }

        public string AreaFormacao { get; set; }
        public int NumeroFuncionarios { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor: {NomeCompleto}, Data Nascimento: {DataNascimento}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}, Salário: {Salario}, Área de Formação: {AreaFormacao}, Número de Funcionários: {NumeroFuncionarios}");
        }
    }
}