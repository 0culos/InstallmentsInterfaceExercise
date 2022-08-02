using System.Globalization;
using ContractProcess.Entities;
using ContractProcess.Services;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contract contract = new Contract(number, date, totalValue);

Console.Write("Enter number of installments: ");
int numberOfInstallments = int.Parse(Console.ReadLine());

IPaymentService paymentService = new PaypalService();

paymentService.Process(contract, numberOfInstallments);

Console.WriteLine("Installments:");
Console.WriteLine(contract.ToString());
