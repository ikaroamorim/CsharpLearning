using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IkaroSchool.Classes
{
  public class Aluno : IComparable
  {
    protected static int currentId { get; set; }

    protected int Id { get; set; }
    protected string Nome { get; set; }
    protected string Cpf { get; set; }
    protected string Telefone { get; set; }
    protected Status StatusAluno { get; }
    protected DateTime DataMatricula { get; set; }

    public Aluno(string nome, string cpf, string telefone, Status statusAluno)
    {
      currentId++;
      Id = currentId;
      Nome = nome;
      Cpf = cpf;
      Telefone = telefone;
      StatusAluno = statusAluno;
      DataMatricula = DateTime.Now;
    }

    public override string ToString()
    {
      
      /* Esse foreach não funciona, nenhuma das props é pública
      foreach (PropertyInfo prop in typeof(Aluno).GetProperties())
      {
        Console.WriteLine($"{prop.Name} = {prop.GetValue(this)}\n");
      }
      */
      
      return $"Id = {Id} \nNome = {Nome} \nCpf = {Cpf} \nTelefone = {Telefone} \nStatus = {StatusAluno} \nData de Matrícula = {DataMatricula.ToShortDateString()}";
    }

    public int CompareTo(object obj)
    {
      var alunoObj = (Aluno)obj;
      if(Id > alunoObj.Id)
      {
        return 1;
      }else if(Id< alunoObj.Id)
      {
        return -1;
      }
      else
      {
        return 0;
      }
    }

    public enum Status
    {
      Analise,
      Matriculado,
      MensalidadeAtraso,
      Encerrado,
      Cancelado
    }
  }
}
