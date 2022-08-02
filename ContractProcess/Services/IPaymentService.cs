using ContractProcess.Entities;

namespace ContractProcess.Services
{
    public interface IPaymentService
    {
        public void Process(Contract contract, int numberOfInstallments);
    }
}
