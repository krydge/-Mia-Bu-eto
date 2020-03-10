using System;
using System.Collections.Generic;
using System.Text;

namespace MyBudget.Models
{
    public class BudgetItem
    {
        public double Price { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
