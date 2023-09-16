using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect_1.Models
{
    internal class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public Expense()
        {
        }

        public Expense(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public Expense(int id, string name, decimal amount)
        {
            Id = id;
            Name = name;
            Amount = amount;
        }

        public override string ToString() => $"Id: {Id}, Name: {Name}, Amount: {Amount:C}";
    }
}
