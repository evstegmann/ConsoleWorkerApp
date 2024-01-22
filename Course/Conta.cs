using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Conta
    {
        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            _titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != _titular && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return "Conta: " +
                Numero + ", Titular: " +
                _titular + ", Saldo: " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);



        }


    }
}
