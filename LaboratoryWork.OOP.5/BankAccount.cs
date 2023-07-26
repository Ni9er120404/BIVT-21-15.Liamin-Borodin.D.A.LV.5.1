using System.ComponentModel;
using System.Windows;

namespace LaboratoryWork.OOP._5
{
	public class BankAccount : INotifyPropertyChanged
	{
		private decimal _balance;
		public decimal Balance
		{
			get => _balance;
			set
			{
				_balance = value;
				OnPropertyChanged(nameof(Balance));
			}
		}

		public Currency Currency { get; set; } = null!;

		public BankAccount(decimal balance, Currency currency)
		{
			Balance = balance;
			Currency = currency;
		}

		public void Deposit(decimal amount, Currency currency)
		{
			if (currency is not null)
			{
				decimal convertedAmount = amount * currency.Price;
				Balance += convertedAmount;
			}
		}

		public void Withdraw(decimal amount, Currency currency)
		{
			if (currency is not null)
			{
				decimal convertedAmount = amount * currency.Price;
				if (Balance >= convertedAmount)
				{
					Balance -= convertedAmount;
				}
				else
				{
					_ = MessageBox.Show("Insufficient funds.");
				}
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}