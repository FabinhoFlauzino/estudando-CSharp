using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Aluno
    {
        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;
        int pontos = 60;
        public double NotaFinal()
        {
            return (PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre);
        }

        public string Situacao()
        {
            if (NotaFinal() >= pontos)
            {
                return "APROVADO";
            }
            else
            {
                double totalPontos = pontos - NotaFinal();

                return $"REPROVADO \n" +
                       $"FALTARAM {totalPontos.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }

        public override string ToString()
        {
            return $"NOTA FINAL = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"{Situacao()}";
        }
    }
}
