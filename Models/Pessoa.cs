using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOOAbsEnc.Models
{
    public class Pessoa
    {
        // public string Nome { get; set; }
        // public string Sobrenome { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }



        public virtual void Apresentar()
        {
            Console.WriteLine($"Aluno: {NomeCompleto}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}");
        }
    }
}