using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        private string _nome { get; set; }
        public double Valor { get; private set; }

        public  ContaBancaria(int numero, string nome, double valor) : this(numero, nome)
        {
            Valor = valor;
        }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            _nome = nome;
        }

        public void Deposito(double deposito)
        {
            Valor += deposito;
            
        }

        public void Saque(double saque)
        {
            Valor -= saque + 5;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + "," + "Titular: " + _nome + "," + "Saldo: $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}
