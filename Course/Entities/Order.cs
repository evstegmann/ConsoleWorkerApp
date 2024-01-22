using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public int Numero { get; set; }
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;  
        }

        public Order(DateTime date, OrderStatus status, int Numero) :this (date, status)
        {

        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Add(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            Order ord = new Order();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(DateTime.Now.ToString("dd/MM/yyyy hh/mm/ss"));
            sb.Append("Order status: ");
            sb.AppendLine(OrderStatus.Processing.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
           //sb.Append(Client.Date);
            sb.Append(Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem order in Items)
            {
                sb.Append($"{order.Product}, {order.Price}, Quantity: {order.Quantity}, Subtotal: {order.SubTotal()}");
            }
            sb.Append("Total Price: ");
            sb.AppendLine(ord.Total().ToString());

            return sb.ToString();
        }

    }
}
