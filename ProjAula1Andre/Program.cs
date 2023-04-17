using ProjAula1Andre.Services;
using ProjAula1Andre.Models;
using ProjAula1Andre.Controllers;
using System.ComponentModel;
using ProjAula1Andre;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Proj MVC - ADO.NET");

        Airplane airplane = new()
        {
            Description = "Para testes",
            Id = 1,
            Name = " TOP TURBO",
            NumberOfPassagers = 20,
            Engine = new Engine() {  Description = "Motor Legal"}
        };

        Console.WriteLine("Teste de inclusão de dados");
        
        if(new AirplaneController().Insert(airplane))
            Console.WriteLine("Sucesso! Registro inserido!");
        else
            Console.WriteLine("Erro ao inserir registro");

        new AirplaneController().FindAll().ForEach(Console.WriteLine);
    }
}