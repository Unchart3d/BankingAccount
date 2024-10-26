using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingAccount
{
    public partial class CustomerAccount : Form
    {
        private Customer customer;
        public CustomerAccount(string name, int accountnumber, decimal balance)
        {
            InitializeComponent();

            customer = new Customer(name, accountnumber, balance);

            if (label1 != null)  
                label1.Text = name;
            if (label2 != null)
                label2.Text = accountnumber.ToString();
            if (label3 != null)
                label3.Text = balance.ToString("C");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal additionalAmount;
            if (decimal.TryParse(textBox1.Text, out additionalAmount))
            {
                
                customer.Deposit(additionalAmount);
                
                label3.Text = customer.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
            textBox1.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private bool balancevalid(string input)
        {
            decimal balancess;
            return decimal.TryParse(input, out balancess);
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            decimal takenAmount;
            if (decimal.TryParse(textBox2.Text, out takenAmount))
            {
                
                customer.Withdraw(takenAmount);
                
                label3.Text = customer.Balance.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
            textBox2.Clear();
        }
    }
}
