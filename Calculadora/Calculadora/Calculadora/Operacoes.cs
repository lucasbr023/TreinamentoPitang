using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    class Operacoes {

        

        double resultado = 0;
                

        public double Somar(double a, double b) {
            
            resultado = a + b;

            return resultado;

        }

        public double Subtrair(double a, double b) {

            resultado = a - b;
            return resultado;
        }

        public double Multiplicar(double a, double b) {
            resultado = a * b;

            return resultado;
        }

        public double Dividir(double a, double b) {
            resultado = a / b;
            return resultado;
        }

        public double ElevarQuadrado(double a) {
            resultado = a * a;
            return resultado;
        }

        public double Raiz(double a) {
            resultado = Math.Sqrt(a);
            return resultado;
        }


    }
}
