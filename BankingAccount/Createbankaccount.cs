using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingAccount
{
    public partial class Createbankaccount : Form
    {
        public Createbankaccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void createaccount(object sender, EventArgs e)
        {
            string name = accountname.Text;
            string accountnumber = number.Text;
            string accountbalance = balance.Text;

            if(IsInputvalid(name) && accountvalid(accountnumber) && balancevalid(accountbalance)) 
            { 
                int accountnumbers = int.Parse(accountnumber);
                decimal balances = decimal.Parse(balance.Text);

                Customer newaccount = new Customer(name, accountnumbers, balances);
                MessageBox.Show("Successfully created bank account");

                Showbankaccount(name, accountnumbers, balances);
            }
            else
            {
                MessageBox.Show("Please enter valid inputs");
            }
            accountname.Clear();
            number.Clear();
            balance.Clear();
        }

        private bool IsInputvalid(string input)
        {
            return input.Length >= 6;
        }
        private bool accountvalid(string input)
        {
            int accountnumbers;
            return int.TryParse(input, out accountnumbers);
        }
        private bool balancevalid(string input)
        {
            decimal balancess;
            return decimal.TryParse(input, out balancess);
        }

        private void Showbankaccount(string name, int accountnumber, decimal balance)
        {
            CustomerAccount customerAccount = new CustomerAccount(name,  accountnumber, balance);
            customerAccount.Show();
        }
    }
}
