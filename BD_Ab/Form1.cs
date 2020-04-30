using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BD_Ab
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();

        }
        string connectionString = string.Format("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={0};Integrated Security = True", GetConnectionSting());

        public static string GetConnectionSting()
        {
            var exeDirectory = Environment.CurrentDirectory;
            exeDirectory = exeDirectory.Substring(0, exeDirectory.Length - 10);
            var dbDirectory = "Db.mdf";
            return Path.Combine(exeDirectory, dbDirectory);
        }


        void updateAbonentDGV()
        {
            var request = "SELECT * FROM abonent";
            var adapter = new SqlDataAdapter(request, connectionString);
            var abonentTable = new DataTable();
            adapter.Fill(abonentTable);
            abonent_t.DataSource = abonentTable;
            abonent_t.Columns["id"].Visible = false;
            abonent_t.Columns["name"].HeaderText = "Имя";
            abonent_t.Columns["patronymic"].HeaderText = "Отчество";
            abonent_t.Columns["surname"].HeaderText = "Фамилия";
            abonent_t.Columns["adress"].HeaderText = "Адрес";
            abonent_t.Columns["birthdate"].HeaderText = "Дата рождения";
            abonent_t.Columns["comment"].HeaderText = "Комментарий";
            var exeDirectory = Environment.CurrentDirectory;
        }

        void updateContactDGV()
        {
            var request = "SELECT * FROM contact";
            var adapter = new SqlDataAdapter(request, connectionString);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            contact_t.DataSource = contactTable;
            contact_t.Columns["id"].Visible = false;
            contact_t.Columns["phone"].HeaderText = "Телефон";
            contact_t.Columns["type"].HeaderText = "Тип";
            contact_t.Columns["provider_id"].Visible = false;
        }

        void updateProviderDGV()
        {
            var request = "SELECT * FROM provider";
            var adapter = new SqlDataAdapter(request, connectionString);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            provider_t.DataSource = contactTable;
            provider_t.Columns["id"].Visible = false;
            provider_t.Columns["provider_company"].HeaderText = "Название";
            provider_t.Columns["score"].HeaderText = "Рейтинг";
        }

        void updatePhone_TabDGV()
        {
            var request =
            @"SELECT * FROM abonent JOIN 
           abonent_has_contact 
            ON abonent.id=abonent_has_contact.abonent_id 
            JOIN contact
            ON contact.id=abonent_has_contact.contact_id
            LEFT JOIN provider 
            ON provider.id=contact.provider_id ";

            var adapter = new SqlDataAdapter(request, connectionString);
            var Phone_Table = new DataTable();
            adapter.Fill(Phone_Table);

            ab_tab.DataSource = Phone_Table;
           // ab_tab.Columns["id"].Visible = false;
            ab_tab.Columns["id1"].Visible = false;
            ab_tab.Columns["id2"].Visible = false;
            ab_tab.Columns["provider_id"].Visible = false;
            ab_tab.Columns["abonent_id"].Visible = false;
            ab_tab.Columns["contact_id"].Visible = false;
            ab_tab.Columns["birthdate"].Visible = false;
            ab_tab.Columns["score"].Visible = false;
            ab_tab.Columns["name"].HeaderText = "Имя";
            ab_tab.Columns["provider_company"].HeaderText = "Провайдер";
            ab_tab.Columns["patronymic"].HeaderText = "Отчество";
            ab_tab.Columns["surname"].HeaderText = "Фамилия";
            ab_tab.Columns["adress"].HeaderText = "Адрес";
            ab_tab.Columns["phone"].HeaderText = "Телефон";
            ab_tab.Columns["type"].HeaderText = "Тип";
            ab_tab.Columns["comment"].HeaderText = "Комментарий";
        }


      

        private void button_find_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FIO_Text.Text) || !string.IsNullOrEmpty(find_phone.Text))
            {
                var request = @"SELECT *FROM abonent JOIN 
                            abonent_has_contact 
                              ON abonent.id=abonent_has_contact.abonent_id 
                              JOIN contact
                              ON contact.id=abonent_has_contact.contact_id
                              LEFT JOIN provider 
                              ON provider.id=contact.provider_id ";

                if (!string.IsNullOrEmpty(FIO_Text.Text))
                    request += string.Format(@"WHERE abonent.surname + ' '   
                            +abonent.patronymic + ' '
                            +abonent.name LIKE N'%{0}%'", FIO_Text.Text);


                if (!string.IsNullOrEmpty(find_phone.Text))
                    request += string.Format("WHERE contact.phone LIKE '%{0}%'",find_phone.Text);

                var adapter = new SqlDataAdapter(request, connectionString);
                var Phone_Table = new DataTable();
                adapter.Fill(Phone_Table);
                ab_tab.DataSource = Phone_Table;
                ab_tab.Columns["id1"].Visible = false;
                ab_tab.Columns["id2"].Visible = false;         
            }
        }

        private void button_add_Click(object sender, EventArgs e)//добавить абонента
        {
            var form = new Form_c();
            {
                var request = "SELECT * FROM provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var prTable = new DataTable();
                adapter.Fill(prTable);
                var dict = new Dictionary<int, string>();
                foreach (DataRow row in prTable.Rows)
                {
                    dict.Add((int)row["id"], row["provider_company"].ToString());
                }
                form.ProviderData = dict;
                dict.Clear();

                List<string> qwe = new List<string>();

                request = "SELECT DISTINCT  type From contact";
                adapter = new SqlDataAdapter(request, connectionString);
                prTable = new DataTable();
                adapter.Fill(prTable);

                foreach (DataRow row in prTable.Rows)
                {
                    qwe.Add(row["type"].ToString());
                }
                form.TypeData = qwe;

            }
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var surname = form.textBox_surname.Text;
                var name = form.textBox_name.Text;
                var patronymic = form.textBox_patronymic.Text;
                var address = form.textBox_adres.Text;
                var comment = form.textBox_comment.Text;
                var providerId = form.ProviderId;
                var phone = form.textBox_phone.Text;
                var type = form.comboBox_type.Text;            
                var connection = new SqlConnection(connectionString);
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.Transaction = transaction;

                        command.CommandText = string.Format(@"INSERT INTO abonent (surname, name, patronymic, adress, comment) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
                                                                surname, name, patronymic, address, comment);
                        command.ExecuteNonQuery();
                        command.CommandText = string.Format("INSERT INTO contact VALUES (N'{0}',N'{1}',N'{2}')",
                                                             phone, type, providerId);
                        command.ExecuteNonQuery();

                        command.CommandText = string.Format("INSERT INTO dbo.abonent_has_contact values" +
                                                           "((select id from dbo.abonent where name=N'{0}'), (select id from dbo.contact where Phone = N'{1}'))",name,phone );
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        connection.Close();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }

            }
            updateAbonentDGV();
            updateContactDGV();
            updatePhone_TabDGV();
        }

        private void button_red_Click(object sender, EventArgs e)//редактировать
        {
            var row = ab_tab.SelectedRows.Count > 0 ? ab_tab.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show(" Сначала выберите строчку в Телефонном справочнике", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new Form_c();

            form.textBox_surname.Text = row.Cells["surname"].Value.ToString();        
            form.textBox_name.Text = row.Cells["name"].Value.ToString();          
            form.textBox_patronymic.Text = row.Cells["patronymic"].Value.ToString();
            form.textBox_adres.Text = row.Cells["adress"].Value.ToString();            
            form.textBox_comment.Text = row.Cells["comment"].Value.ToString();              
            form.textBox_phone.Text = row.Cells["phone"].Value.ToString();
            {
                var request = "SELECT * FROM provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var prTable = new DataTable();
                adapter.Fill(prTable);
                var dict = new Dictionary<int, string>();
                foreach (DataRow row1 in prTable.Rows)
                {
                    dict.Add((int)row1["id"], row1["provider_company"].ToString());
                }
                form.ProviderData = dict;
                dict.Clear();

                List<string> qwe = new List<string>();

                request = "SELECT DISTINCT  type From contact";
                adapter = new SqlDataAdapter(request, connectionString);
                prTable = new DataTable();
                adapter.Fill(prTable);

                foreach (DataRow row2 in prTable.Rows)


                {
                    qwe.Add(row2["type"].ToString());
                }
                form.TypeData = qwe;

            }
        
       //form.ProviderId = (int) row.Cells["id"].Value;
  //     form.TypeId = row.Cells["type"].Value.ToString();
      
           
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var surname = form.textBox_surname.Text;
                var name = form.textBox_name.Text;
                var patronymic = form.textBox_patronymic.Text;
                var adress = form.textBox_adres.Text;
                var comment = form.textBox_comment.Text;
                var phone = form.textBox_phone.Text;
                var type = form.comboBox_type.Text;
                var id = row.Cells["id"].Value.ToString();
                var connection = new SqlConnection(connectionString);
              
                connection.Open();
                var request = string.Format(@"UPDATE  abonent SET surname=N'{0}',name=N'{1}', patronymic=N'{2}', adress=N'{3}', comment=N'{4}' WHERE id={5}
                                              UPDATE  contact SET Phone=N'{6}', type=N'{7}'",
                                              surname, name, patronymic, adress, comment, id, phone, type);
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();
                updateAbonentDGV();
                updatePhone_TabDGV();
                updateContactDGV();

            }
        }

        private void button_delete_Click(object sender, EventArgs e)//удалить 
        {
            var row = ab_tab.SelectedRows.Count > 0 ? ab_tab.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Выберите строчку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = row.Cells["id"].Value.ToString();
            var phone = row.Cells["phone"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var request = string.Format(@"DELETE dbo.abonent_has_contact where contact_id = (select id from dbo.contact where Phone = N'{0}')
                                          DELETE dbo.contact where Phone = N'{0}'
                                          DELETE dbo.abonent where id ={1}", phone, id);

            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();
            connection.Close();
            updateAbonentDGV();
            updateContactDGV();
            updatePhone_TabDGV();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateAbonentDGV();
            updateContactDGV();
            updateProviderDGV();
            updatePhone_TabDGV();
        }
    }
}
