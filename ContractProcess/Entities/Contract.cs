namespace ContractProcess.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; private set; }
        private List<Installments> Installment { get; set; } = new List<Installments>();


        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installments installment)
        {
            Installment.Add(installment);
        }

        public override string ToString()
        {
            string data = string.Empty;
            foreach (Installments installment in Installment)
            {
                data += installment.ToString() + "\n";
            }
            return data;
        }
    }
}
