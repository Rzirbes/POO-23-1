
using Exercicio02.Domain;
using Exercicio02.Interface;

Console.WriteLine("Hello, World!");

IPessoa professor = new Professor("Professor 1", 34);
IPessoa aluno = new Aluno("Professor 1", 34);

Escola escola = new Escola(professor, aluno);

escola.Aluno.Falar();
escola.Professor.Falar();

