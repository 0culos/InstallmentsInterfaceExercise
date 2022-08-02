using ContractProcess.Entities;

namespace ContractProcess.Services
{
    public class PaypalService : IPaymentService
    {
        public void Process(Contract contract, int numberOfInstallments)
        {
            for (int i = 1; i <= numberOfInstallments; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = contract.TotalValue / numberOfInstallments;

                amount = amount * (1 + (0.01 * i)); // juros de 1% ao mês

                amount = amount * 1.02;

                Installments installment = new Installments(dueDate, amount);

                contract.AddInstallment(installment);
            }
        }
    }
}
