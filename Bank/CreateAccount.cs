using System;
using System.Data;
using System.Windows.Forms;


namespace Bank
{
    public partial class CreateAccount : Form
    {
        int clientID;
        int depositID;
        DataTable table;
        public CreateAccount(int id)
        {
            clientID = id;
            InitializeComponent();
            table = MyDataBase.getItemsForComboBox("Deposits");
            depositsName.Items.Add("Все элементы");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                object[] rows = row.ItemArray;
                depositsName.Items.Add(rows[1].ToString()); 
            }
            depositsName.Text=depositsName.Items[0].ToString();
        }

        private void Sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                if (Sum.Text.Length == 0 && (e.KeyChar == '0' || e.KeyChar == ',' || e.KeyChar == '.'))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == ',' && Sum.Text.Contains(","))
                {
                    e.Handled = true;
                }
                // После запятой можно ввести только два числа
                if (Sum.Text.Contains(",") && Sum.Text.Substring(Sum.Text.IndexOf(",")).Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void Sum_TextChanged(object sender, EventArgs e)
        {
            if(Sum.TextLength>0 && depositsName.Text!= "Все элементы")
                btnOpenAccount.Enabled = true;
            else
                btnOpenAccount.Enabled = false;
        }

        private void depositsName_TextChanged(object sender, EventArgs e)
        { 
            if (Sum.TextLength > 0 && depositsName.Text != "Все элементы")
                btnOpenAccount.Enabled = true;
            else
                btnOpenAccount.Enabled = false;
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            string query = $"insert into Accounts values ({clientID}, {depositID}, CONVERT (date, GETDATE()), NULL, {Sum.Text}, 0)";
            if(MyDataBase.insert_data(query)==0)
                MessageBox.Show("Счет открыт! Вы можете посмотреть его в разделе 'Мои счета'", "Открытие счета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Что-то пошло не так", "Открытие счета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void depositsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (depositsName.SelectedIndex!=0)
            {
                int r = (int)depositsName.SelectedIndex;
                DataRow row = table.Rows[depositsName.SelectedIndex-1];
                object[] rows = row.ItemArray;
                string id = rows[0].ToString();
                depositID=int.Parse(id);
            }
        }
    }
}
