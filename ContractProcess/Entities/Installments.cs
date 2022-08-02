using System.Globalization;
using ContractProcess.Services;

namespace ContractProcess.Entities
{
    public class Installments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
