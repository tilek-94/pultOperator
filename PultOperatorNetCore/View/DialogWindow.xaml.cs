using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public delegate void MessageDelegate(int i);
        public event MessageDelegate _mess;
        public DialogWindow(string s)
        {
            InitializeComponent();
            TextBlock1.Text = s;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mess(1);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
