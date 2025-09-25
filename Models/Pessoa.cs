

namespace ExemploPOOAbsEnc.Models
{
    public class Pessoa
    {
        // public string Nome { get; set; }
        // public string Sobrenome { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }



        public virtual void Apresentar()
        {
            Console.WriteLine($"Aluno: {NomeCompleto}, Data Nascimento: {DataNascimento}, Idade: {Idade}, Endereço: {Endereco}, Telefone: {Telefone}");
        }
    }
}