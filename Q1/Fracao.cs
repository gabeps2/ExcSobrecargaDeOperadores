using System;

namespace ExcSobrecargaDeOperadores.Q1 {
    class Fracao {
        private int numerador, denominador;
        public static int getMmc (Fracao obj1, Fracao obj2) {

            int num1 = obj1.denominador;
            int num2 = obj2.denominador;
            int resto;

            while (num2 != 0) {
                resto = num1 % num2;
                num1 = num2;
                num2 = resto;
            }
            return ((obj1.denominador * obj2.denominador) / num1);
        }
        public Fracao (int numerador, int denominador) //Construtor
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }
        public int getNumerador () {
            return numerador;
        }
        public int getDenominador () {
            return denominador;
        }

        public Fracao soma (Fracao obj) {
            int mmc = getMmc (this, obj);
            int numerador1 = mmc / this.denominador * this.numerador;
            int numerador2 = mmc / obj.denominador * obj.numerador;

            return new Fracao (numerador1 + numerador2, mmc);
        }
        public Fracao subtracao (Fracao obj) {
            int mmc = getMmc (this, obj);
            int numerador1 = mmc / this.denominador * this.numerador;
            int numerador2 = mmc / obj.denominador * obj.numerador;

            return new Fracao (numerador1 - numerador2, mmc);
        }
        public Fracao multplicacao (Fracao obj) {
            return new Fracao (this.numerador * obj.numerador, this.denominador * obj.denominador);
        }
        public Fracao divisao (Fracao obj) {
            return new Fracao (this.numerador * obj.denominador, this.denominador * obj.numerador);
        }
        public override string ToString () {
            return $"{numerador}/{denominador}";
        }
    }
}