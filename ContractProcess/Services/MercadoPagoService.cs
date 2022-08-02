using ContractProcess.Entities;

namespace ContractProcess.Services
{
    public class MercadoPagoService : IPaymentService
    {
        public void Process(Contract contract, int numberOfInstallments)
        {
            for (int i = 1; i <= numberOfInstallments; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = contract.TotalValue / numberOfInstallments;

                amount = amount * (1 + (0.015 * i)); // juros de 1,5 % ao mês

                amount = amount * 1.04;

                Installments installment = new Installments(dueDate, amount);

                contract.AddInstallment(installment);
            };
        }
    }
}
