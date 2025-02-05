using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAccounts;

namespace BankApp
{
    public partial class Withdrawl : Form
    {
        public Withdrawl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Withdrawl_Load(object sender, EventArgs e)
        {
            Account.GenerateTestAccounts();
            foreach (var account in Account.Accounts)
            {
                cmbAccounts.Items.Add(account.AccountHolder); 
            }
        }
    }
}
