using System;
using System.Collections.Generic;
using IkaroSchool.Classes;

namespace IkaroSchool
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
      Console.WriteLine("Bem vindo, Ikaro School");
      Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

      string option = "0";

      List<Aluno> listaAlunos = new List<Aluno>();




      do
      {
        Console.WriteLine("\nSelecione uma opção");
        Console.WriteLine("1 - Adicionar Aluno");
        Console.WriteLine("2 - Exibe Aluno");
        Console.WriteLine("s - Para encerrar o programa!");
        option = Console.ReadLine();

        switch (option)
        {
          case "1":
            AddNewAluno(listaAlunos);
            break;
          case "2":
            ListAllAlunos(listaAlunos);
            break;
          default:
            break;
        }

      } while (option.ToLower() != "s");
    }

    private static void ListAllAlunos(List<Aluno> lista)
    {
      foreach (Aluno item in lista)
      {
        Console.WriteLine(item.ToString());
      }
    }

    private static void AddNewAluno(List<Aluno> lista)
    {
      string nome, cpf, telefone;

      Console.WriteLine("Digite o nome do aluno:");
      nome = Console.ReadLine();
      Console.WriteLine("Digite o cpf do aluno:");
      cpf = Console.ReadLine();
      Console.WriteLine("Digite o telefone do aluno:");
      telefone = Console.ReadLine();

      Aluno aluno = new Aluno(nome, cpf, telefone, Aluno.Status.Analise);

      lista.Add(aluno);

      Console.WriteLine($"A lista de aluno tem {lista.Count}");
    }
  }
}
