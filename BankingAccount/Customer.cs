using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankingAccount
{
    internal class Customer
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public Customer(string name, int accountNumber, decimal balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount) 
        { 
            if (amount > Balance)
            {
                MessageBox.Show("Insifficiant funds");
            }
            else
            {
                Balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"Account Name: {{Name}}, Account Number: {{AccountNumber}}, Balance: {{Balance:C}}";
        }
    }
}
