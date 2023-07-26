using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace LaboratoryWork.OOP._5
{
	public partial class MainWindow : Window
	{
		private readonly BankAccount bankAccount1;
		private readonly BankAccount bankAccount2;
		public ObservableCollection<Currency> Currencies { get; } = new ObservableCollection<Currency>();

		public MainWindow()
		{
			InitializeComponent();

			// Инициализация банковских счетов и валюты
			Currencies.Add(new Currency() { Name = "RUB", Price = 1M });
			Currencies.Add(new Currency() { Name = "AMD", Price = 0.1574M });
			Currencies.Add(new Currency() { Name = "CNY", Price = 11.99M });

			bankAccount1 = new BankAccount(30000, Currencies[0]);
			bankAccount2 = new BankAccount(50000, Currencies[0]);

			// Привязка данных к элементам управления
			DataContext = this;
			BindingOperations.EnableCollectionSynchronization(Currencies, Currencies);
			textBoxAccount1.DataContext = bankAccount1;
			textBoxAccount2.DataContext = bankAccount2;
		}

		private void ButtonDeposit_Click(object sender, RoutedEventArgs e)
		{
			if (decimal.TryParse(textBoxTransactionAmount.Text, out decimal amount))
			{
				bankAccount1.Deposit(amount, (Currency)comboBoxCurrency.SelectedItem);
			}
		}

		private void ButtonWithdraw_Click(object sender, RoutedEventArgs e)
		{
			if (decimal.TryParse(textBoxTransactionAmount.Text, out decimal amount))
			{
				bankAccount1.Withdraw(amount, (Currency)comboBoxCurrency.SelectedItem);
			}
		}
	}
}