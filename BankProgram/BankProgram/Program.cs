namespace BankProgram
{
    class Program
    {
        public static void Main(String[] args)
        {
            /*
            Account bob = new Account("Bob", 100);
            bob.Show();

            if(bob.Withdraw(150))
            {
                Console.WriteLine("Withdrew 150");
            } else
            {
                Console.WriteLine("Inssuffiecient funds");
            }

            Account mary = new Account("Mary", 100);

            Account a1 = new Account("bob", 100);
            Account a2 = new Account("fred", 200);

            a1 = a2;
            a1.Show();
            a2.Show();
            a1.Withdraw(10);
            a2.Withdraw(20);
            a1.Show();
            a2.Show();
            */

            Account a1 = new Account("bob", 100);
            int totalAssets = 1000;
            doIt(a1, ref totalAssets);
            Console.WriteLine("after doIt:");
            a1.Show();
            Console.WriteLine($"total assets is now {totalAssets}");

        }
        public static void doIt(Account a, ref int totalAssets)
        {
            a.Withdraw(50);
            totalAssets--;
        }
    }
}
