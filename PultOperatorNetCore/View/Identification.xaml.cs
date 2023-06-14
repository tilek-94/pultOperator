using Microsoft.EntityFrameworkCore;
using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.ViewModel;
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
    /// Логика взаимодействия для Identification.xaml
    /// </summary>
    public partial class Identification : Window
    {
        
        public Identification()
        {
            InitializeComponent();
            
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (window.Height < 200)
            {
                window.Height = 365;
            }
            else
            {
                window.Height = 190;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        private void savePassCB_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SettingWindow window = new SettingWindow();
            window.Owner = this;
            window.ShowDialog();
 
        }

       

        private void BidablePasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                var viewModel = (IdentificationViewModel)DataContext;
                
                if (viewModel.ExitCommand.CanExecute(this))
                    viewModel.ExitCommand.Execute(this);
                
            }
        }
    }
}
