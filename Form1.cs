using System;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloakaControllerApp
{
    public partial class RulesController : Form
    {
        private string MySqLServerAdress = ""; // Адрес MySql сервера
        private string MySqLDataBaseName = ""; // Имя базы данных
        private string MySqLDataBaseUser = ""; // Имя пользователя базы данных
        private string MySqLDataBasePswrd = ""; // Пароль от базы данных
        private string ConnectionString; // MySQl Query для соединения
        private List<string> BadIPsList;
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand MSQLcommand;
        public RulesController()
        {
            SetupDataForConnection();
            InitializeComponent();
            MSQLBoxAdress.Text = MySqLServerAdress;
            DataBaseNameBox.Text = MySqLDataBaseName;
            DataBaseUser.Text = MySqLDataBaseUser;
            DataBasePassword.Text = MySqLDataBasePswrd;
        }
        // Возвращаем знаения полей подключения если таковые были заданы ранее
        private void SetupDataForConnection()
        {
            if (File.Exists("DataBaseData/adress.txt"))
            {
                MySqLServerAdress = File.ReadAllText("DataBaseData/adress.txt");
                if (File.Exists("DataBaseData/bsname.txt"))
                {
                    MySqLDataBaseName = File.ReadAllText("DataBaseData/bsname.txt");
                }
                if (File.Exists("DataBaseData/bsuser.txt"))
                {
                    MySqLDataBaseUser = File.ReadAllText("DataBaseData/bsuser.txt");
                }
                if (File.Exists("DataBaseData/bspswd.txt"))
                {
                    MySqLDataBasePswrd = File.ReadAllText("DataBaseData/bspswd.txt");
                }
            }
        }

        private void ConnectToMySql_Click(object sender, EventArgs e)
        {
            MySqLServerAdress = MSQLBoxAdress.Text;
            MySqLDataBaseName = DataBaseNameBox.Text;
            MySqLDataBaseUser = DataBaseUser.Text;
            MySqLDataBasePswrd = DataBasePassword.Text;

            // Сохраняем данные полей
            File.WriteAllText("DataBaseData/adress.txt", MySqLServerAdress);
            File.WriteAllText("DataBaseData/bsname.txt", MySqLDataBaseName);
            File.WriteAllText("DataBaseData/bsuser.txt", MySqLDataBaseUser);
            File.WriteAllText("DataBaseData/bspswd.txt", MySqLDataBasePswrd);

            // Формируем строку подключения
            ConnectionString = "host=" + MySqLServerAdress + ';' + "database=" + MySqLDataBaseName + ';' + "user=" + MySqLDataBaseUser + ';' + "password=" + MySqLDataBasePswrd;
            // Открываем соединение с БД
            conn = new MySqlConnection(ConnectionString);
            try
            {
                conn.Open();
                ConnMessage.Text = "Соединение установлено";
            }
            catch(Exception ex)
            {
                ConnMessage.Text = "Ошибка при попытке соединения";
            }
        }

        private void AddIPsToDB_Click(object sender, EventArgs e)
        {
            BadIPsList = new List<string>(BoxOfIPs.Lines.ToList());
            if (!BadIPsList.Any())
            {
                MessageBox.Show("В списке отсутствуют айпи адреса для добавления");
            }
            else
            {
                if (conn.State == ConnectionState.Open)
                {
                    // Создаем таблицу если она еще не существует
                    MSQLcommand = new MySqlCommand(@"CREATE TABLE IF NOT EXISTS ip_table (id INT AUTO_INCREMENT PRIMARY KEY, ip_start VARCHAR(15) NOT NULL, ip_end VARCHAR(15) NOT NULL) ENGINE=INNODB;", conn);
                    MSQLcommand.ExecuteNonQuery();
                    MSQLcommand = new MySqlCommand();
                    // Заполняем таблицу
                    int valCounter = 0;
                    string AddQuery = @"INSERT INTO ip_table(ip_start, ip_end) VALUES";
                    foreach(string s in BadIPsList)
                    {
                        AddQuery = AddQuery + "(@ipstart" + valCounter.ToString() + ", " + "@ipend" + valCounter.ToString() + ')' + ", ";
                        valCounter = valCounter + 1;
                    }
                    valCounter = 0;
                    AddQuery = AddQuery.Remove(AddQuery.Length - 2) + ';';
                    MSQLcommand = conn.CreateCommand();
                    MSQLcommand.CommandText = AddQuery;
                    string ipStart = "";
                    string ipEnd = "";
                    foreach (string z in BadIPsList)
                    {
                        if (z.Contains('-'))
                        {
                            ipStart = z.Substring(0, z.IndexOf('-'));
                            ipEnd = z.Substring(z.IndexOf('-') + 1);
                            MSQLcommand.Parameters.AddWithValue("@ipstart" + valCounter.ToString(), ipStart);
                            MSQLcommand.Parameters.AddWithValue("@ipend" + valCounter.ToString(), ipEnd);
                        }
                        else
                        {
                            MSQLcommand.Parameters.AddWithValue("@ipstart" + valCounter.ToString(), z);
                            MSQLcommand.Parameters.AddWithValue("@ipend" + valCounter.ToString(), z);
                        }
                        valCounter = valCounter + 1;
                    }
                    MSQLcommand.ExecuteNonQuery();
                    MessageBox.Show("Айпи адреса успешно добавлены в Базу данных");
                }
                else
                {
                    MessageBox.Show("Соединение с БД было потеряно");
                }
            }
        }
        private void BadIpsHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все Айпи адреса должны быть в формате списка:\r\nАйпиАдрес1\r\nАйпиадрес2\r\nПример 192.168.10.1-192.168.50.255 и т.д.");
        }
        private void RulesController_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close(); // Закрываем соединение с БД
            }
            catch(Exception ss)
            {
                // Если закрывают программу раньше чем установили соединение
            }
        }
        private void RulesHelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RulesInstructions.txt");
        }

        private void AddRulesToDataBase_Click(object sender, EventArgs e)
        {
            List<string> LinkNamesList = new List<string>(RuleNameTxBox.Lines.ToList());
            List<string> PageForBotsList = new List<string>(PageForBotsTxBox.Lines.ToList());
            List<string> PagesForSale = new List<string>(SellPagesTxBox.Lines.ToList());
            if (LinkNamesList.Any() && PageForBotsList.Any() && PagesForSale.Any() && LinkNamesList.Count() == PageForBotsList.Count() && LinkNamesList.Count() == PagesForSale.Count())
            {
                // Создаем таблицу правил если она не была создана ранее
                MSQLcommand = new MySqlCommand(@"CREATE TABLE IF NOT EXISTS rules (id INT AUTO_INCREMENT PRIMARY KEY, linknames VARCHAR(100), botpages VARCHAR(255), selpages VARCHAR(255) NOT NULL) ENGINE=INNODB;", conn);
                MSQLcommand.ExecuteNonQuery();
                MSQLcommand = new MySqlCommand();
                if (conn.State == ConnectionState.Open)
                {
                    // Заполняем базу данных нашими правилами
                    int vC = 0;
                    string RulesQuery = @"INSERT INTO rules(linknames, botpages, selpages) VALUES";
                    foreach(string g in LinkNamesList)
                    {
                        RulesQuery = RulesQuery + "(@lnknames" + vC.ToString() + ',' + "@botpg" + vC.ToString() + ',' + "@selpg" + vC.ToString() + ')' + ", ";
                        vC = vC + 1;
                    }
                    vC = 0;
                    RulesQuery = RulesQuery.Remove(RulesQuery.Length - 2) + ';';
                    MSQLcommand = conn.CreateCommand();
                    MSQLcommand.CommandText = RulesQuery;
                    foreach(string r in LinkNamesList)
                    {
                        MSQLcommand.Parameters.AddWithValue("@lnknames" + vC.ToString(), r);
                        MSQLcommand.Parameters.AddWithValue("@botpg" + vC.ToString(), PageForBotsList.ElementAt(LinkNamesList.IndexOf(r)));
                        MSQLcommand.Parameters.AddWithValue("@selpg" + vC.ToString(), PagesForSale.ElementAt(LinkNamesList.IndexOf(r)));
                        vC = vC + 1;
                    }
                    MSQLcommand.ExecuteNonQuery();
                    MSQLcommand = new MySqlCommand();
                    MessageBox.Show("Правила успешно добавлены в Базу данных");
                }
                else
                {
                    MessageBox.Show("Было потеряно соединение с БД");
                }
            }
            else
            {
                MessageBox.Show("Правила не были заполнены");
            }           
        }
        // Получаем статистику переходов на нашем сайте
        private void StatisticTakeButton_Click(object sender, EventArgs e)
        {
            string timeString = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string readerQuery = "SELECT * FROM ip_stat WHERE data_time LIKE '%" + timeString + "%';";
            if (conn.State == ConnectionState.Open)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(readerQuery, conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                Statistic.DataSource = tb;
            }
            else
            {
                MessageBox.Show("Соединение с БД не установлено");
            }
        }

        private void GenerateScripts_Click(object sender, EventArgs e)
        {
            // Создаем файл конфигураций по умолчанию адрес для внутренних подключений localhost
            // В случае отличий адреса подключения его нужно изменить вручную в config.php
            // Создаем config.php
            string configFileInfo = "<?php\r\nclass dataclass\r\n{\r\n// Данные БД\r\n  public static $data_base_adress = 'localhost';\r\n  public static $data_base_name = '" + MySqLDataBaseName + "';\r\n  public static $data_base_user = '" + MySqLDataBaseUser + "';\r\n  public static $data_base_password = '" + MySqLDataBasePswrd + "';\r\n}\r\n?>";
            File.WriteAllText("script/setfiles/config.php", configFileInfo);

            // Генерируем index.php наших ссылок
            string linkNameInFile = "";
            string GenerateQuery = "SELECT linknames FROM rules;";
            MSQLcommand = new MySqlCommand();
            MSQLcommand = conn.CreateCommand();
            MSQLcommand.CommandText = GenerateQuery;
            MySqlDataReader reader = MSQLcommand.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    linkNameInFile = reader.GetString(0);
                    string indexFileCode = "<?php\r\nif(strpos($_SERVER['DOCUMENT_ROOT'], 'public_html') == true)\r\n{\r\n  include $_SERVER['DOCUMENT_ROOT'].'/setfiles/func.php';\r\n}\r\nelse\r\n{\r\n  include $_SERVER['DOCUMENT_ROOT'].'/public_html'.'/setfiles/func.php';\r\n}\r\n$namelnk = '" + linkNameInFile + "';\r\nwork($namelnk);\r\n?>";
                    if (!Directory.Exists("script/" + linkNameInFile))
                    {
                        Directory.CreateDirectory("script/" + linkNameInFile);
                    }
                    File.WriteAllText("script/" + linkNameInFile + "/index.php", indexFileCode);
                }
            }
            MessageBox.Show("Скрипты были сгенерированны успешно");
        }

        private void DropScriptTables_Click(object sender, EventArgs e)
        {
            // Сбрасываем все таблицы связанные с нашими скриптами
            MSQLcommand = new MySqlCommand();
            MSQLcommand = conn.CreateCommand();
            MSQLcommand.CommandText = "DROP TABLE IF EXISTS ip_stat;";
            MSQLcommand.ExecuteNonQuery();
            //
            MSQLcommand = new MySqlCommand();
            MSQLcommand = conn.CreateCommand();
            MSQLcommand.CommandText = "DROP TABLE IF EXISTS ip_table;";
            MSQLcommand.ExecuteNonQuery();
            //
            MSQLcommand = new MySqlCommand();
            MSQLcommand = conn.CreateCommand();
            MSQLcommand.CommandText = "DROP TABLE IF EXISTS rules;";
            MSQLcommand.ExecuteNonQuery();

            MessageBox.Show("База данных очищена");
        }

    }
}
