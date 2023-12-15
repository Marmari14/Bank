using LibraryForDataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UnitTestsForDataBase
{
    [TestClass]
    public class UnitTest1
    {
        private string sqlstr = "Data Source=DESKTOP-I12KO2O;Initial Catalog=Bank;Integrated Security=True";
        private MyDataBase myData;
        public UnitTest1()
        {
            myData = new MyDataBase(sqlstr);
        }
        [TestMethod]
        public void GetOneItem()
        {
            string query = "select 25";
            int result = (int)myData.getOneItem(query);
            Assert.AreEqual(result, 25);
        }
        [TestMethod]
        public void GetOneItemException()
        {
            try
            {
                string query = "select Count(*) from Mytable";
                int result = (int)myData.getOneItem(query);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Произошла ошибка! Проверьте входные данные!");
                return;
            }
            Assert.Fail("Ожидаемое исключение не получено.");
        }

        [TestMethod]
        public void AuthorizationTrue()
        {
            int id;
            string table;
            bool result = myData.authorization("marmari", "56732", out id, out table);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void AuthorizationFalse()
        {
            int id;
            string table;
            bool result = myData.authorization("mari", "123", out id, out table);
            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void InsertData()
        {
            /*string query = "insert into Operation_type values ('Снятие наличных', 0)";
            int result = (int)myData.insert_data(query);
            Assert.AreEqual(result, 0);*/
        }
        [TestMethod]
        public void InsertData_NotExistTable()
        {
            try
            {
                string query = "insert into my values ('Снятие наличных', 0)";
                int result = (int)myData.insert_data(query);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Произошла ошибка! Проверьте входные данные!");
                return;
            }
        }
        [TestMethod]
        public void UpdateData()
        {
            string query = "Update Operation_type  set Deleted=1 where Name='Снятие наличных'";
            int result = (int)myData.insert_data(query);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void UpdateData_ResultRowCountZero()
        {
            string query = "Update Operation_type  set Deleted=1 where Name='Привет'";
            int result = (int)myData.insert_data(query);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void getItemsForComboBox_NotExistTable()
        {
            try
            {
                DataTable table =myData.getItemsForComboBox("Mytable");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Таблица не найдена!");
                return;
            }
            Assert.Fail("Ожидаемое исключение не получено.");
        }

        [TestMethod]
        public void getTable_NotExistTable()
        {
            try
            {
                DataTable table = myData.getTable("select * from MyTable");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Произошла ошибка! Проверьте входные данные!");
                return;
            }
            Assert.Fail("Ожидаемое исключение не получено.");
        }


    }
}
