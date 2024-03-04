namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.Deposit(500.00);

            bankAccount.GetBalance();

            bankAccount.Withdraw(50.50);
            Console.WriteLine("updated Balance: ");
            bankAccount.GetBalance();

        }
    }
}
