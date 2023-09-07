namespace Exercicio01.Entities
{
	class SavingsAccount : Account
	{
		public double InterestRate { get; set; }

		public SavingsAccount()
		{
		}

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

		public void UpdateBalance()
		{
			Balance += Balance * InterestRate;
		}

		public override void Withdraw(double amount)
		{
			Balance -= amount;
		}

		/*BASE -> chamar um metodo comum de superclasse
        public override void Withdraw(double amount)
        {
			base.Withdraw(amount);
			Balance -= 2.0;
        }
		*/
    }
}

