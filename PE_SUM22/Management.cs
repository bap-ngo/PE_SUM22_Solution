using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_SUM22
{
    public partial class Management : Form
    {
        const string format = "dd/MM/yyyy";
        BankAccountServices bankServices = new BankAccountServices();
        //BindingSource _source = new BindingSource();
        UserServices userServices = new UserServices();
        AccountTypeServices _type = new AccountTypeServices();
        BankAccount bankAccount;
        List<AccountType> listType;
        public Management()
        {
            InitializeComponent();
            Load();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            listType = _type.GetAll();
            foreach (var item in listType)
            {
                cbTypeId.Items.Add(item.TypeId);
            }
            cbTypeId.Text = listType[0].TypeId;
        }

        private void Load(string serach = "")
        {
            var listBankAccount = bankServices.GetAll().Where(p => p.BranchName.Contains(serach));
            //_source.DataSource = listBankAccount;
            dgvList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvList.DataSource = listBankAccount.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string branchName = txtSearch.Text;
            Load(branchName);
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountId.Enabled = false;
            var bankAccounts = bankServices.GetAll();
            bankAccount = bankAccounts[e.RowIndex];
            txtAccountId.Text = bankAccount.AccountId;
            txtAccountName.Text = bankAccount.AccountName;
            txtOpenDate.Text = bankAccount.OpenDate.ToString();
            txtBranchName.Text = bankAccount.BranchName;
            cbTypeId.Text = bankAccount.TypeId;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "1")
            {
                DialogResult result = MessageBox.Show("Are you sure to delete", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bankServices.Delete(bankAccount);
                    Load();
                }
                else return;
            }
            else MessageBox.Show("You are not allowed to access this function", "Notification", MessageBoxButtons.OK);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "1")
            {
                txtAccountId.Enabled = true;
                txtAccountId.Text = "";
                txtAccountName.Text = "";
                txtOpenDate.Text = "";
                txtBranchName.Text = "";
                cbTypeId.Text = listType[0].TypeId;
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function", "Notification", MessageBoxButtons.OK);
            }

        }

        private bool CheckLimit(int min, int max, int year)
        {
            return (year<min || year > max) ? false : true;
        }

        private string[] GetElementOfTime(string dateString)
        {
            string pattern = @"^(\d{1,2})[/-](\d{1,2})[/-](\d{4})$";
            DateTime date;
            string[] arr = new string[3];
            Match match = Regex.Match(dateString, pattern);
            if(match.Success)
            {
                arr[0] = match.Groups[1].Value;
                arr[1] = match.Groups[2].Value;
                arr[2] = match.Groups[3].Value;
            }
            return arr;
        }

        private string ConverDateString(string dateString)
        {
            string[] arr = GetElementOfTime(dateString);
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            { 
                if (arr[i].Length == 1) arr[i] =  "0" + arr[i];
                if (i == arr.Length - 1)
                {
                    result += arr[i]+"";
                }
                else result += arr[i] + "/";
            }
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "1")
            {
                BankAccount bankAccount = new BankAccount();
                bankAccount.AccountId = txtAccountId.Text;
                bankAccount.AccountName = txtAccountName.Text;
                //bankAccount.OpenDate = DateTime.Parse(txtOpenDate.Text);
                string[] array = GetElementOfTime(txtOpenDate.Text);
                int year = int.Parse(array[array.Length - 1]);
                
                if (CheckLimit(2000, 2022, year))
                {
                    bankAccount.OpenDate = DateTime.ParseExact(ConverDateString(txtOpenDate.Text), format, CultureInfo.InvariantCulture);
                }
                else { 
                    MessageBox.Show("Range in [2000, 2022]", "Notification", MessageBoxButtons.OK);
                    return;
                }
                bankAccount.BranchName = txtBranchName.Text;
                bankAccount.TypeId = cbTypeId.Text;
                bankServices.Add(bankAccount);
                Load();
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UserSession.Instance.Role == "1")
            {
                DialogResult result = MessageBox.Show("Are you sure to update", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
          
                    bankAccount.AccountId = txtAccountId.Text;
                    bankAccount.AccountName = txtAccountName.Text;
                    string[] arr = GetElementOfTime(txtOpenDate.Text);
                    int year = int.Parse(arr[arr.Length-1]);
                    if (CheckLimit(2000, 2022, year))
                    {
                        bankAccount.OpenDate = DateTime.ParseExact(ConverDateString(txtOpenDate.Text), format, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        MessageBox.Show("Year in range [2000-2022]", "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    bankAccount.BranchName = txtBranchName.Text;
                    bankAccount.TypeId = cbTypeId.Text;
                    bankServices.Update(bankAccount);
                    Load();
                }
                else return;
            }
            else MessageBox.Show("You are not allowed to access this function", "Notification", MessageBoxButtons.OK);
        }
    }
}
