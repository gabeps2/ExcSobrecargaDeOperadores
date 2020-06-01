using System;

namespace ExcSobrecargaDeOperadores.Q2 {
    class TesteQ2 {
        public static void testar () {
            Fracao obj1 = new Fracao (2, 5);
            Fracao obj2 = new Fracao (1, 3);

            System.Console.WriteLine ("Soma: " + (obj1 + obj2));
            System.Console.WriteLine ("Subtração: " + (obj1 - obj2));
            System.Console.WriteLine ("Multiplicação: " + (obj1 * obj2));
            System.Console.WriteLine ("Divisão: " + (obj1 / obj2));
            System.Console.WriteLine ("Igualdade: " + (obj1 == obj2));
            System.Console.WriteLine ("Desigualdade: " + (obj1 != obj2));
            System.Console.WriteLine ("Maior: " + (obj1 > obj2));
            System.Console.WriteLine ("Menor: " + (obj1 < obj2));
        }
    }
}