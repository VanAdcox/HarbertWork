namespace BankProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            Account bob = new Account("Bob", 100);
            bob.Show();

            if (bob.Withdraw(150))
            {
                Console.WriteLine("Withdrew 150");
            }
            else
            {
                Console.WriteLine("Inssuffiecient funds");
            }

            Account mary = new Account("Mary", 100);
            Console.WriteLine("setting mary balance to -1238");
            mary.Balance = -1238;
            mary.Show();
        }
    }
}
