using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculator
    {

        public int Score { get; set; }
        private string nome;
        public double Point { get; set; }

        public Calculator()
        {

        }

        public Calculator(int score, string nome, double point)
        {
            Score = score;
            Nome = nome;
            Point = point;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 0 || value != null)
                {
                    Nome = value;
                }
            }
        }
    }
}
