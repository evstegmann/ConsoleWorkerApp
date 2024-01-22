using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Vote
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Vote(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

    }
}
