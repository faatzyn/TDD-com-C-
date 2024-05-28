using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Models
{
    public class Calculadora
    {
        private List<string> historico;

        public Calculadora()
        {
            historico = new List<string>();
        }

        public int Somar(int numero1, int numero2)
        {
            historico.Insert(0, "Adição");
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            historico.Insert(0, "Subtração");
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            historico.Insert(0, "Multiplicação");
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            historico.Insert(0, "Divisão");
            return numero1 / numero2;
        }

        public List<string> RetornoHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
        
    }
}