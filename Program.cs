// Arquivo: Program.cs

using System;
using ExemploPoo.Models;
using ExemploPOOAbsEnc.Models;

Aluno aluno = new Aluno();
aluno.NomeCompleto = "Naruto Uzumaki";
aluno.DataNascimento = new DateTime(2006, 10, 10);
aluno.Idade = 16;
aluno.Endereco = "Konoha, Vila da Folha";
aluno.Telefone = 123456789;
aluno.Nota = 9.5;
aluno.Apresentar();


Professor professor = new Professor();
professor.NomeCompleto = "Kakashi Hatake";
professor.DataNascimento = new DateTime(1995, 9, 15);
professor.Idade = 29;
professor.Endereco = "Konoha, Vila da Folha";
professor.Telefone = 987654321;
professor.Salario = 5000;
professor.Apresentar();















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