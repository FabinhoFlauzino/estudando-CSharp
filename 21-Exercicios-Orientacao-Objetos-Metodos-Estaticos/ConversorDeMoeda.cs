using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Exercicios_Orientacao_Objetos_Metodos_Estaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.00;

        public static double ConverterDolarParaReal(double cotacaoDolar, double valorComprado)
        {
            double porcentagem = Iof / 100;
            double totalComprado = cotacaoDolar * valorComprado;

            return totalComprado += (totalComprado * porcentagem);
        }
    }
}
