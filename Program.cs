using ExemploPOOAbsEnc.Models;

Aluno aluno = new Aluno("Sasuke Uchiha", new DateTime(2005, 7, 23), 17, "Konoha, Vila da Folha", 1122334455, 8.5);
aluno.Apresentar();

Professor professor = new Professor("Iruka Umino", new DateTime(1980, 4, 1), 42, "Konoha, Vila da Folha", 998877665, 3000);
professor.Apresentar();

Diretor diretor = new Diretor("Hiruzen Sarutobi", new DateTime(1950, 1, 1), 72, "Konoha, Vila da Folha", 556677889, 10000);
diretor.AreaFormacao = "Ninjutsu";
diretor.NumeroFuncionarios = 150;
diretor.Apresentar();


// ContaCorrente conta = new ContaCorrente();
// conta.Creditar(500);
// //ContaBancaria teste = new ContaBancaria();
// conta.ExibirSaldo();

// Aluno aluno = new Aluno();
// aluno.NomeCompleto = "Naruto Uzumaki";
// aluno.DataNascimento = new DateTime(2006, 10, 10);
// aluno.Idade = 16;
// aluno.Endereco = "Konoha, Vila da Folha";
// aluno.Telefone = 123456789;
// aluno.Nota = 9.5;
// aluno.Apresentar();


// Professor professor = new Professor();
// professor.NomeCompleto = "Kakashi Hatake";
// professor.DataNascimento = new DateTime(1995, 9, 15);
// professor.Idade = 29;
// professor.Endereco = "Konoha, Vila da Folha";
// professor.Telefone = 987654321;
// professor.Salario = 5000;
// professor.Apresentar();















// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ContaCorrente conta = new ContaCorrente(12345, 1000);

//         //Erro abaixo
//         //ContaBancaria contaGenerica = new ContaBancaria(98765, 500);

//         conta.ExibirSaldo();
//         conta.Sacar(200);
//         conta.ExibirSaldo();
//     }
// }