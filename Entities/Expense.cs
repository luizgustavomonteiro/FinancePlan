using System.ComponentModel;

namespace FinancePlan.Entities
{
    public class Expense
    {
        public int Id { get; set; } // Expense ID
        public string? Description { get; set; } // Description of Expense

        public decimal Amount { get; set; } // Amount of Expense

        public DateTime DateTime { get; set; } // Could be DateTime.NOW

        public Category? Category { get; set; } // Category of Expense E.g "food", "college"
    }
}

