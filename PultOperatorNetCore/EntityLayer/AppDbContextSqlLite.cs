using PultOperatorNetCore.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.EntityLayer
{
    public class AppDbContextSqlLite
    {
        private SettingClass? settingClass { get; set; }
        public void SqlLiteCommand(string qury)
        {
            using SQLiteConnection connection = new SQLiteConnection("Data Source=UserBasa.db");
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(qury, connection);
            int number = command.ExecuteNonQuery();
        }
        public void ConnectWihtBase()
        {
            string sqlExpression = "SELECT * FROM AllBase WHERE id=1";
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=UserBasa.db")) { 
                connection.Open();
             settingClass = new SettingClass();
            SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())   // построчно считываем данные
                    {
                        settingClass.IpAddress = reader.GetString(1);
                        settingClass.WindowNumber = reader.GetInt32(2);
                        settingClass.Login = reader.GetString(3);
                        settingClass.Password = reader.GetString(4);
                        if (reader.GetInt32(5) == 1) 
                            settingClass.IsCheck = true;
                        else
                            settingClass.IsCheck = false;

                    }
                }
            }
            }
        }
        public int GetWindow()
        {
            return settingClass.WindowNumber;
            
        }
        public string GetIpAddress()
        {
            return settingClass.IpAddress;

        }
        public bool GetIsCheck()
        {
            return settingClass.IsCheck;
        }
        public string GetLogin()
        {
            return settingClass.Login;

        }
        public string GetPassword()
        {
            return settingClass.Password;

        }

    }
}
