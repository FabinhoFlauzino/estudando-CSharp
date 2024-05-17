using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido ()
        {
            return SalarioBruto - Imposto;
        }


        public void AumentarSalario(double aumentoPercentual)
        {
            double aumento = SalarioBruto * (aumentoPercentual / 100);
            SalarioBruto += aumento;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido()}";
        }
    }
}
