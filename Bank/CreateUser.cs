using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class CreateUser : Form
    {
        int id;
        int role;
        DataTable table;
        string query;
        int post;
        public CreateUser(int id, int role)
        {
            InitializeComponent();
            this.id = id;
            this.role = role;
            table = MyDataBase.getItemsForComboBox("Posts");
            postText.Items.Add("Все элементы");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                object[] rows = row.ItemArray;
                postText.Items.Add(rows[1].ToString());
            }
            if (id == 0)
            {
                nameWindow.Text = "Создание пользователя";
                idText.Visible = false;
                postText.Text = postText.Items[0].ToString();
            }
            else
            {
                nameWindow.Text = "Редактирование пользователя";
                idText.Visible = true;
                idText.Text = "Номер: " + id;
                loginText.Enabled = false;
                PasswordText.Enabled = false;
                surnameText.ForeColor = Color.Black;
                nameText.ForeColor = Color.Black;
                PatronymicText.ForeColor = Color.Black;
                phoneText.ForeColor = Color.Black;
                addressText.ForeColor = Color.Black;
                seriesText.ForeColor = Color.Black;
                numText.ForeColor = Color.Black;
                PasswordText.ForeColor = Color.Black;
                loginText.ForeColor = Color.Black;
                if (role == 3)
                {
                    query = $"select Surname, Name, Patronymic, Phone, Address, u.Login, u.Password, Series_passport, Num_passport " +
                        $"from Clients c, Users u " +
                        $"where c.ID={id} and c.ID_user=u.ID";
                    table =MyDataBase.getTable(query);
                    DataRow row = table.Rows[0];
                    object[] rows = row.ItemArray;
                    isEmployee.Enabled=false;
                    isEmployee.Checked = false;
                    numText.Visible = true;
                    seriesText.Visible = true;
                    surnameText.Text = row[0].ToString();
                    nameText.Text = row[1].ToString();
                    PatronymicText.Text = row[2].ToString();
                    phoneText.Text = row[3].ToString();
                    addressText.Text = row[4].ToString();
                    loginText.Text = row[5].ToString();
                    PasswordText.Text = row[6].ToString();
                    seriesText.Text = row[7].ToString();
                    numText.Text = row[8].ToString();
                }
                else if (role == 1 || role==2)
                {
                    query = $"select Surname, e.Name, Patronymic, Phone, Address, u.Login, u.Password, p.Name " +
                                           $"from Employee e, Users u, Posts p " +
                                           $"where e.ID={id} and e.ID_user=u.ID and Post = p.ID";
                    DataTable table1 = MyDataBase.getTable(query);
                    DataRow row = table1.Rows[0];
                    object[] rows = row.ItemArray;
                    isEmployee.Enabled = false;
                    isEmployee.Checked = true;
                    numText.Visible = false;
                    seriesText.Visible = false;
                    postText.Visible=true;
                    surnameText.Text = row[0].ToString();
                    nameText.Text = row[1].ToString();
                    PatronymicText.Text = row[2].ToString();
                    phoneText.Text = row[3].ToString();
                    addressText.Text = row[4].ToString();
                    loginText.Text = row[5].ToString();
                    PasswordText.Text = row[6].ToString();

                    for (int i = 0; i < postText.Items.Count; i++)
                    {
                        if (postText.Items[i].ToString() == row[7].ToString())
                             postText.SelectedItem = postText.Items[i];
                    }
                }
            }   
        }

        private void surnameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void addressText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Space
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar!='.'
                && e.KeyChar != ',')
                e.Handled = true;
        }

        private void loginText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '_')
                e.Handled = true;
        }

        private void isEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (isEmployee.Checked)
            { 
                seriesText.Visible = false;
                numText.Visible = false;
                postText.Visible = true;
            }
            else
            {
                seriesText.Visible = true;
                numText.Visible = true;
                postText.Visible = false;
            }
        }

        private void surnameText_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == Color.Silver)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (surnameText.TextLength>0 &&
                nameText.TextLength>0  &&
                phoneText.TextLength==11 &&
                addressText.TextLength>0 &&
                loginText.TextLength>0 &&
                PasswordText.TextLength>0)
            {
                if (isEmployee.Checked)
                {
                    if (postText.Text != "Все элементы")
                    {
                        int post1=0;
                        if (postText.Text == "Банкир")
                            post1 = 2;
                        else if (postText.Text == "Администратор")
                            post1 = 1;
                        if (id == 0)
                        {
                            query = $"insert into Users values ({post1}, '{loginText.Text}', '{PasswordText.Text}', DEFAULT, 0, 0)";
                            MyDataBase.insert_data(query);
                            query = $"select dbo.getUser({post1})";
                            int idUser = (int)MyDataBase.getOneItem(query);
                            table = MyDataBase.getTable(query);
                            query = $"insert into Employee values ('{surnameText.Text}', '{nameText.Text}', '{PatronymicText.Text}', " +
                                $"'{addressText.Text}', '{phoneText.Text}', {post} , {idUser}, 0)";
                            if (MyDataBase.insert_data(query) == 0)
                            {
                                MessageBox.Show("Сотрудник создан!", "Создание пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                                MessageBox.Show("Что-то пошло не так!", "Создание пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            query = $"update Employee set Surname = '{surnameText.Text}', Name='{nameText.Text}', Patronymic='{PatronymicText.Text}', " +
                                $"Address='{addressText.Text}', Phone='{phoneText.Text}', Post={post} " +
                                $"where ID={id}";
                            if (MyDataBase.insert_data(query) == 0)
                            {
                                MessageBox.Show("Сотрудник обновлен!", "Редактирование пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                                MessageBox.Show("Что-то пошло не так!", "Редактирование пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if(seriesText.TextLength==4 && numText.TextLength == 6)
                    {
                        if (id == 0)
                        {
                            query = $"insert into Users values (3, '{loginText.Text}', '{PasswordText.Text}',  DEFAULT, 0, 0)";
                            MyDataBase.insert_data(query);
                            if (PatronymicText.TextLength < 0)
                                PatronymicText.Text = "NULL";
                            query = "select dbo.getUser(3)";
                            int idUser = (int)MyDataBase.getOneItem(query);
                            table = MyDataBase.getTable(query);
                            query = $"insert into Clients values ('{surnameText.Text}', '{nameText.Text}', '{PatronymicText.Text}', " +
                                $"'{seriesText.Text}', '{numText.Text}', '{addressText.Text}', '{phoneText.Text}', {idUser}, 0)";
                            if (MyDataBase.insert_data(query) == 0)
                            {
                                MessageBox.Show("Клиент создан!  Необходимо завести счет!", "Создание пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                query = "select c.ID " +
                                    "from Clients c " +
                                    "where c.ID not in (select ID_client from Accounts) and c.Deleted=0";
                                int idClient = (int)MyDataBase.getOneItem(query);
                                CreateAccount createAccount = new CreateAccount(idClient);
                                createAccount.ShowDialog();
                                Close();
                            }
                            else
                                MessageBox.Show("Что-то пошло не так!", "Создание пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            query = $"update Clients set Surname = '{surnameText.Text}', Name='{nameText.Text}', Patronymic='{PatronymicText.Text}', " +
                                $"Series_passport='{seriesText.Text}', Num_passport='{numText.Text}', Address='{addressText.Text}', Phone='{phoneText.Text}' " +
                                $"where ID={id}";
                            if (MyDataBase.insert_data(query) == 0)
                            {
                                MessageBox.Show("Клиент обновлен!", "Редактирование пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                                MessageBox.Show("Что-то пошло не так!", "Редактирование пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void postText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (postText.SelectedIndex != 0)
            {
                DataRow row = table.Rows[postText.SelectedIndex - 1];
                object[] rows = row.ItemArray;
                string id1 = rows[0].ToString();
                post = int.Parse(id1);
            }
        }
    }
}
