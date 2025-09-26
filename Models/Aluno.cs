using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nomeCompleto, DateTime dataNascimento, int idade, string endereco, int telefone, double nota)
            : base(nomeCompleto, dataNascimento, idade, endereco, telefone)
        {
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Nota = nota;
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Aluno: {NomeCompleto}, Data Nascimento: {DataNascimento}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}, Nota: {Nota}");
        }
    }
}