using System;
using System.Windows.Forms;
namespace BIVT_21_15_Liamin_Borodin.D.A_LV_5_1_
{
    public partial class Form1 : Form
    {
        public decimal percent_1 = 0.01M;
        public decimal percent_2 = 0.99M;
        private static readonly Score[] scores = new Score[2]
        {
            new Score("1"),
            new Score("2")
        };
        private static readonly Currency[] currency = new Currency[3]
        {
            new Currency() { Name = "RUB", Price = 1M },
            new Currency() { Name = "AMD", Price = 0.1574M },
            new Currency() { Name = "CNY", Price = 11.99M}
        };
        private static readonly Bank_Account bank_account_1 = new Bank_Account(30000, currency[0]);
        private static readonly Bank_Account bank_account_2 = new Bank_Account(50000, currency[0]);
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(currency);
            comboBox2.Items.AddRange(currency);
            comboBox3.Items.AddRange(currency);
            comboBox4.Items.AddRange(scores);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AppendText(bank_account_1.Balance.ToString());
            textBox2.AppendText(bank_account_2.Balance.ToString());
            MessageBox.Show("За валютные переводы взымается комиссия 1%");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a = bank_account_1.Balance;
            switch (comboBox1.Text)
            {
                case "RUB":
                    textBox1.Text = textBox1.Text;
                    break;
                case "AMD":
                    textBox1.Text = Math.Round(a * percent_2 / currency[1].Price, 2).ToString();
                    break;
                case "CNY":
                    textBox1.Clear();
                    textBox1.Text = Math.Round(a * percent_2 / currency[2].Price, 2).ToString();
                    break;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal a = bank_account_2.Balance;
            switch (comboBox2.Text)
            {
                case "RUB":
                    textBox2.Text = textBox2.Text;
                    break;
                case "AMD":
                    textBox2.Clear();
                    textBox2.Text = Math.Round(a * percent_2 / currency[1].Price, 2).ToString();
                    break;
                case "CNY":
                    textBox2.Clear();
                    textBox2.Text = Math.Round(a * percent_2 / currency[2].Price, 2).ToString();
                    break;
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(textBox1.Text);
            decimal b = Convert.ToDecimal(textBox2.Text);
            decimal c = Convert.ToDecimal(textBox3.Text);
            if (comboBox4.Text == "1")
            {
                switch (comboBox3.Text)
                {
                    case "RUB":
                        c *= currency[0].Price;
                        break;
                    case "AMD":
                        c = c * currency[1].Price * percent_1;
                        break;
                    case "CNY":
                        c = c * currency[2].Price * percent_1;
                        break;
                }
                decimal d = a + c;
                textBox1.Clear();
                textBox1.AppendText(d.ToString());
            }
            else if (comboBox4.Text == "2")
            {
                switch (comboBox3.Text)
                {
                    case "RUB":
                        c *= currency[0].Price;
                        break;
                    case "AMD":
                        c = c * currency[1].Price * percent_1;
                        break;
                    case "CNY":
                        c = c * currency[2].Price * percent_1;
                        break;
                }
                decimal d = b + c;
                textBox2.Clear();
                textBox2.AppendText(d.ToString());
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(textBox1.Text);
            decimal b = Convert.ToDecimal(textBox2.Text);
            decimal c = Convert.ToDecimal(textBox3.Text);
            if (comboBox4.Text == "1")
            {
                switch (comboBox3.Text)
                {
                    case "RUB":
                        c *= currency[0].Price;
                        break;
                    case "AMD":
                        c = c * currency[1].Price * percent_1;
                        break;
                    case "CNY":
                        c = c * currency[2].Price * percent_1;
                        break;
                }
                decimal d = a - c;
                if (d >= 0)
                {
                    textBox1.Clear();
                    textBox1.AppendText(d.ToString());
                }
                else
                {
                    MessageBox.Show("У вас не достаточно средств на счету");
                }
            }
            else if (comboBox4.Text == "2")
            {
                switch (comboBox3.Text)
                {
                    case "RUB":
                        c *= currency[0].Price;
                        break;
                    case "AMD":
                        c = c * currency[1].Price * percent_1;
                        break;
                    case "CNY":
                        c = c * currency[2].Price * percent_1;
                        break;
                }
                decimal d = b - c;
                if (d >= 0)
                {
                    textBox2.Clear();
                    textBox2.AppendText(d.ToString());
                }
                else
                {
                    MessageBox.Show("У вас не достаточно средств на счету");
                }
                textBox2.Clear();
                textBox2.AppendText(d.ToString());

            }
        }
    }
    internal class Currency
    {
        public string Name
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
    internal class Bank_Account
    {
        public decimal Balance;
        public Currency Currency;
        public Currency CurrencyDisplay
        {
            set
            {
                Currency = value;
            }
        }
        public Bank_Account(decimal balance, Currency currency)
        {
            Balance = balance;
            Currency = currency;
        }
    }
    internal class Score
    {
        private readonly string Number;
        public Score(string number)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"{Number}";
        }
    }
}
