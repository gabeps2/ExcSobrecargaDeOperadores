using System;

namespace ExcSobrecargaDeOperadores.Q1
{
    class TesteQ1
    {
        public static void testar()
        {
            Fracao obj1 = new Fracao(1,2);
            Fracao obj2 = new Fracao(1,3);

            System.Console.WriteLine("Soma: " + obj1.soma(obj2));
            System.Console.WriteLine("Subtração: " + obj1.subtracao(obj2));
            System.Console.WriteLine("Multiplicação: " + obj1.multplicacao(obj2));
            System.Console.WriteLine("Divisão: " + obj1.divisao(obj2));
        }
    }
}