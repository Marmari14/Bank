using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bank
{
    public partial class MainWindow : Form
    {
        int id_user = 0;
        string table_user = "";
        DataGridViewColumn[] table_Columns;
        string query;
        string path = Application.StartupPath+"\\images\\";

        private void ShowTable()
        {
            mainTable.Columns.Clear();
            mainTable.Columns.AddRange(table_Columns);
            DataTable table = MyDataBase.getTable(query);
            if (mainTable.RowCount > 0)
                mainTable.Rows.Clear();
            mainTable.RowCount = table.Rows.Count;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                object[] rows = row.ItemArray;

                for (int j = 0; j < mainTable.ColumnCount; j++)
                    mainTable.Rows[i].Cells[j].Value = rows[j].ToString();
            }
            rowsCount.Text = "Всего записей: " + mainTable.Rows.Count;
            mainTable.Columns[0].Visible = false;
        }
        private void ShowLoginStory()
        {
            btnChange.Visible = false;
            btnDelete.Visible = false;
            table_Columns = new DataGridViewColumn[]
                {
                     new DataGridViewTextBoxColumn() {HeaderText = "Номер"},
                new DataGridViewTextBoxColumn() { HeaderText = "Дата входа" },
                new DataGridViewTextBoxColumn() { HeaderText = "Логин" },
                new DataGridViewTextBoxColumn() { HeaderText = "Результат" }
                };
            query = "select l.ID, l.DateLogin, l.Login, dbo.TrueOrFalse(l.Result) as result from Login_history l";
            ShowTable();
        }
        private void ShowUsers()
        {
            btnChange.Visible = true;
            btnDelete.Visible = true;
            table_Columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() {HeaderText = "Номер"},
                new DataGridViewTextBoxColumn() { HeaderText = "ФИО" },
                new DataGridViewTextBoxColumn() {HeaderText="Роль"},
                new DataGridViewTextBoxColumn() { HeaderText = "Логин" }
            };
            query = "select c.ID, ( c.Surname+' '+ c.Name+' '+c.Patronymic), s.Name_status, u.login " +
               "from Clients c, Users u, Status s " +
               "where c.ID_user=u.ID and u.Deleted=0 and u.ID_status=s.ID " +
               "union " +
               "select e.ID, (e.Surname+' '+ e.Name+' '+e.Patronymic), s.Name_status,  u.login " +
               "from Employee e, Users u, Status s " +
               "where e.ID_user=u.ID and u.Deleted=0 and u.ID_status=s.ID";
            ShowTable();
        }
        private void ShowAccount() 
        {
            if (UserPost.Text == "Банкир")
            {
                table_Columns = new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn() {HeaderText = "Номер"},
                    new DataGridViewTextBoxColumn() { HeaderText = "ФИО" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Вклад" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Ставка, %" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Дата открытия" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Дата закрытия" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Сумма вклада" },
                    new DataGridViewTextBoxColumn() { HeaderText = "Валюта хранения" }
                };
                query = "select a.ID, dbo.FioByID(a.ID_client, 1) as Fio, " +
                "d.Name, " +
                "d.Bet, " +
                "a.Opening_date, " +
                "a.Closing_date, " +
                "a.Sum, " +
                "cur.Name " +
                "from Accounts a, Clients c, Deposits d, Currencies cur " +
                "where a.ID_client=c.ID and a.ID_deposit=d.ID and cur.ID = d.ID_currency";
            }
            else if (UserPost.Text == "Клиент")
            {
                table_Columns = new DataGridViewColumn[]
                {
                     new DataGridViewTextBoxColumn() {HeaderText = "Номер"},
                new DataGridViewTextBoxColumn() { HeaderText = "Вклад" },
                new DataGridViewTextBoxColumn() { HeaderText = "Ставка, %" },
                new DataGridViewTextBoxColumn() { HeaderText = "Сумма вклада" },
                new DataGridViewTextBoxColumn() { HeaderText = "Валюта вклада" }
                };
                query = "select a.ID, d.Name, d.Bet, a.Sum ,c.Name " +
                    "from Deposits d, Currencies c, Accounts a " +
                    $"where a.ID_deposit = d.ID and ID_currency = c.ID and a.ID_client = {id_user}";
            }
                ShowTable();
        }
        private void ShowDeposits() 
        {
            table_Columns = new DataGridViewColumn[]
               {new DataGridViewTextBoxColumn() { HeaderText = "Номер" },
                new DataGridViewTextBoxColumn() { HeaderText = "Вклад" },
                new DataGridViewTextBoxColumn() { HeaderText = "Срок хранения, мес" },
                new DataGridViewTextBoxColumn() { HeaderText = "Ставка, %" },
                new DataGridViewTextBoxColumn() { HeaderText = "Валюта хранения" }
               };
            query = "select d.ID, d.Name, d.Shelf_life, d.Bet, c.Name " +
                        "from Deposits d, Currencies c " +
                        "where d.ID_currency=c.ID and d.Deleted=0";
            ShowTable();
        }

        private void ShowMainTable()
        {
            if (UserPost.Text == "Администратор")
            {
                tableName.Text = "История входа";
                button2.Text = "Пользователи";
                button3.Text = "Создать пользователя";
                ShowLoginStory();
            }
            else if (UserPost.Text == "Банкир")
            {
                tableName.Text = "Все счета";
                button2.Text = "Виды вкладов";
                button3.Text = "Создать вклад";
                ShowAccount();
            }
            else if (UserPost.Text == "Клиент")
            {
                tableName.Text = "Мои счета";
                button2.Text = "Виды вкладов";
                button3.Text = "Открыть счет";
                ShowAccount();
            }
            searchText.Text = "Поиск в: " + tableName.Text;
            searchText.ForeColor = Color.Silver;
            
        }
        public MainWindow(int id, string table)
        {
            id_user = id;
            table_user = table;
            InitializeComponent();
            int tab;
            if (table_user == "Clients")
                tab = 1;
            else
                tab = 2;
            string query = $"SELECT dbo.FioByID({id}, {tab})";
            string fio = (string) MyDataBase.getOneItem(query);
            string[] fioSplit= fio.Split(' ');
            UserName.Text =string.Format("{0} {1}\n", fioSplit[0], fioSplit[1]);
            if (fioSplit[2] != "NULL" )
                UserName.Text = UserName.Text + fioSplit[2];
            if (table == "Clients")
                UserPost.Text = "Клиент";
            else
            {
                query = $"SELECT p.Name FROM Posts p, Employee e WHERE p.ID=e.Post and e.ID={id_user}";
                UserPost.Text = (string)MyDataBase.getOneItem(query);
            }    
            ShowMainTable();
            
            tableName.Location = new Point((panel4.Width - tableName.Width) / 2, 91);
            query = $"select Photo from Users u, {table_user} t where u.ID = t.ID_user and t.ID = {id_user}";
            string name;
            if (MyDataBase.getOneItem(query) == null)
                name = "default.png";
            else
               name = (string)MyDataBase.getOneItem(query);

            using (Image image = Image.FromFile(path+ name))
                    {
                        userPhoto.BackgroundImage = new Bitmap(image);
                        userPhoto.BackgroundImageLayout= ImageLayout.Zoom;
                    }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void changePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "png files (*.png)|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    userPhoto.BackgroundImage = new Bitmap(dlg.FileName);
                    query = $"select u.ID from Users u, {table_user} t where u.ID = t.ID_user and t.ID = {id_user}";
                    int t =(int) MyDataBase.getOneItem(query);
                    string savePath = $"{path}"+t.ToString() + ".png";
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }
                    userPhoto.BackgroundImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                    query = $"Update Users set Photo='{t.ToString() + ".png"}' where ID={t}";
                    MyDataBase.insert_data(query);

                }
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            tableName.Location = new Point((panel4.Width - tableName.Width) / 2, 91);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "Пользователи":
                    tableName.Text = "Пользователи";
                    MainWindow_Resize(sender, e);
                    ShowUsers();
                    button2.Text = "История входа";
                    break;
                case "Виды вкладов":
                    ShowDeposits();
                    tableName.Text = "Виды вкладов";
                    button2.Text = "Счета";
                    break;
                case "История входа":                 
                    tableName.Text = "История входа";
                    button2.Text = "Пользователи";
                    ShowLoginStory();
                    break;
                case "Счета":
                    if(UserPost.Text == "Клиент")
                    tableName.Text = "Мои счета";
                    else if (UserPost.Text == "Клиент")
                        tableName.Text = "Все счета";
                    button2.Text = "Виды вкладов";
                    ShowAccount();
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (button3.Text)
            {
                case "Создать пользователя":                    
                    CreateUser createUser= new CreateUser(0, 0);
                    createUser.FormClosing += new FormClosingEventHandler(MainWindow_Load);
                    createUser.ShowDialog();
                    break;
                case "Создать вклад":
                    CreateDeposit createDeposit = new CreateDeposit();
                    createDeposit.FormClosing += new FormClosingEventHandler(MainWindow_Load);
                    createDeposit.ShowDialog();
                    break;
                case "Открыть счет":
                    CreateAccount createAccount = new CreateAccount(id_user);
                    createAccount.FormClosing += new FormClosingEventHandler(MainWindow_Load);
                    createAccount.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           ShowMainTable();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            
            if (searchText.TextLength > 0 && searchText.Text != "Поиск в: " + tableName.Text)
            {
                for (int i = 0; i < mainTable.RowCount; i++)
                {
                    bool isVisible = false;
                    int j = 0;
                    while (j < mainTable.ColumnCount)
                    {
                        if (mainTable[j, i].Value.ToString().ToLower().Contains(searchText.Text.ToLower()))
                        {
                            isVisible = true;
                            break;
                        }
                        j++;
                    }
                    mainTable.Rows[i].Visible = isVisible;
                }
            }
        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
       
        }

        private void searchText_Enter(object sender, EventArgs e)
        {
            searchText.Text = "";
            searchText.ForeColor = Color.Black;
        }

        private void searchText_Leave(object sender, EventArgs e)
        {
            searchText.Text = "Поиск в: " + tableName.Text;
            searchText.ForeColor = Color.Silver;
            foreach (DataGridViewRow row in mainTable.Rows)
                row.Visible = true;
        }

        private void tableName_TextChanged(object sender, EventArgs e)
        {
            searchText.Text = "Поиск в: " + tableName.Text;
        }

        private void mainTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (tableName.Text == "Пользователи")
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(mainTable.CurrentRow != null)
            {
                int id =int.Parse( mainTable.CurrentRow.Cells[0].Value.ToString());
                int role=0;
                if (mainTable.CurrentRow.Cells[2].Value.ToString()=="Клиент")
                    role = 3;
                else if (mainTable.CurrentRow.Cells[2].Value.ToString() == "Банкир")
                    role = 2;
                else if (mainTable.CurrentRow.Cells[2].Value.ToString() == "Администратор")
                    role = 1;
                CreateUser createUser = new CreateUser(id, role);
                createUser.FormClosing += new FormClosingEventHandler(MainWindow_Load);
                createUser.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(mainTable.CurrentRow.Cells[0].Value.ToString());
            if (mainTable.CurrentRow.Cells[2].Value.ToString() == "Клиент")
                MessageBox.Show("Нельзя удалять клиентов!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить сотрудника?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    query = $"delete from Employee where ID={id}";
                    if(MyDataBase.insert_data(query)==0)
                        MessageBox.Show("Сотрудник удален!", "Усппешное удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowMainTable();
                }

            }
        }
    }
}   
