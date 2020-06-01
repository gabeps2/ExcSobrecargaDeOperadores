using System;
using ExcSobrecargaDeOperadores.Q1;
using ExcSobrecargaDeOperadores.Q2;
using ExcSobrecargaDeOperadores.Q3;
namespace ExcSobrecargaDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n---------- Teste da questão 1 ----------\n");
            TesteQ1.testar();
            System.Console.WriteLine("\n---------- Teste da questão 2 ----------\n");
            TesteQ2.testar();
            System.Console.WriteLine("\n---------- Teste da questão 3 ----------\n");
            TesteQ3.testar();
        }
    }
}
