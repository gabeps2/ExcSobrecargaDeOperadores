using System;
using System.Collections.Generic;

namespace ExcSobrecargaDeOperadores.Q3 {
    class TesteQ3 {
        public static void testar () {
            List<Fracao> lista = new List<Fracao> ();
            lista.Capacity = 10;
            Fracao soma = new Fracao (0, 1);
            Random rnd = new Random ();
            for (int i = 0; i < 10; i++) {
                Fracao obj = new Fracao (rnd.Next (1, 10), rnd.Next (1, 10));
                lista.Add (obj);
            }

            foreach (Fracao obj in lista) {
                soma = soma + obj;
                System.Console.WriteLine (obj);
            }
            System.Console.WriteLine ("\nSoma: " + soma);
        }
    }
}