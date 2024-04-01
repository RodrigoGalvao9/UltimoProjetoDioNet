using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Funcoes
    {
        private int num1;
        private int num2;

        public Funcoes()
        {

        }
        public Funcoes(int Numero1, int Numero2)
        {
            Numero1 = num1; 
            Numero2 = num2;
        }
        public void Somar()
        {
            int resultado = num1 + num2;
        }
    }
}