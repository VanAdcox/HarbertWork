namespace BankProgram
{
    internal class Account
    {
        string name;
        int balance;

        public Account(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount; 
        }
        public bool Transfer(Account other, int amount)
        {
            if (other.balance >= amount)
            {
                other.balance -= amount;
                this.balance += amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(int amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public void Show()
        {
            Console.WriteLine($"Account Holder: {name} | Balance: {balance}");
        }
    }
}
