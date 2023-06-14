using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PultOperatorNetCore.View
{
    /// <summary>
    /// Логика взаимодействия для SeetinWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
            IpAddress.Text = StaticClass.IpAddress;
            WindowNumber.Text = StaticClass.WindowNumber.ToString();
            WindowNumber.PreviewTextInput += new TextCompositionEventHandler(textBox_PreviewTextInput);
        }

        void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }



        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            AppDbContextSqlLite contextSqlLite = new AppDbContextSqlLite();
            contextSqlLite.SqlLiteCommand($"UPDATE AllBase SET IpAddress='{IpAddress.Text}'," +
                    $" Window='{WindowNumber.Text}' WHERE id='1' ");
            IpAddress.Text = StaticClass.IpAddress;
            WindowNumber.Text = StaticClass.WindowNumber.ToString();
            this.Close();
        }
    }
}
