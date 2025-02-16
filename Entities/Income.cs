namespace FinancePlan.Entities
{
    public class Income
    {
        public int Id { get; set; } // Expense ID
        public string? Source { get; set; } // Description of Expense

        public decimal Amount { get; set; } // Amount of Expense

        public DateTime DateTime { get; set; } // Could be DateTime.NOW

        
    }
}
