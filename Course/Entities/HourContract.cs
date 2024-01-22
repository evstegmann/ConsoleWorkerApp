using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }

        public int Hour { get; set; }

        public List<HourContract> hourContracts { get; set; } = new List<HourContract>();

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
            
    }

        public double TotalValue()
        {
           return ValuePerHour * Hour;
        }
    }
}
