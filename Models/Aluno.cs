using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Aluno: {NomeCompleto}, Data Nascimento: {DataNascimento}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}, Nota: {Nota}");
        }
    }
}