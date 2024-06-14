using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    class ContaBancaria
    {
        //propriedades
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //construtores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }


        //propriedades customizadas


        //outros métodos da classe
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            double taxa = 5.00;
            Saldo -= quantia + taxa;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
