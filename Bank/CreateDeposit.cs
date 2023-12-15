using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    public partial class CreateDeposit : Form
    {
        int currencyID;
        DataTable table;
        public CreateDeposit()
        {
            InitializeComponent();
            table = MyDataBase.getItemsForComboBox("Currencies");
            currencyText.Items.Add("Все элементы");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                object[] rows = row.ItemArray;
                currencyText.Items.Add(rows[1].ToString());
            }
            currencyText.Text = currencyText.Items[0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameText.TextLength > 0  && currencyText.Text != "Все элементы")
            {
                string bet =betText.Value.ToString().Replace(",", ".");
                string query = $"insert into Deposits values ('{nameText.Text}', {shelfLifeText.Value}, {bet}, {currencyID}, 0)";
                if (MyDataBase.insert_data(query) == 0)
                    MessageBox.Show("Вклад успешно сохранен! Вы можете посмотреть его в разделе 'Все вклады'", "Создание вклада", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Что-то пошло не так", "Открытие счета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void nameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&&e.KeyChar!= (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void betText_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == '.')
                    e.KeyChar = ',';
        }

        private void currencyText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currencyText.SelectedIndex != 0)
            {
                int r = (int)currencyText.SelectedIndex;
                DataRow row = table.Rows[currencyText.SelectedIndex - 1];
                object[] rows = row.ItemArray;
                string id = rows[0].ToString();
                currencyID = int.Parse(id);
            }
        }
    }
}
