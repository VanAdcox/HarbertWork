namespace BankProgram
{
    internal class Account
    {
        public string Name { get; }

        private int _balance;
        public int Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0) { _balance = value; }
            }
        }

        public Account(string Name, int Balance)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
        public bool Transfer(Account other, int amount)
        {
            if (other.Balance >= amount)
            {
                other.Balance -= amount;
                this.Balance += amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void Show()
        {
            Console.WriteLine($"Account Holder: {Name} | Balance: {Balance}");
        }
    }
}
