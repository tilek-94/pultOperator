using PultOperatorNetCore.ViewModel;
using PultOperatorNetCore.ViewModel.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PultOperatorNetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width);
            this.Top = desctop.Bottom - (this.Height);
            AndBtn_Click();
            Button2_Click();


            StaticClass.styleMethod += () =>
            {
                NextBtnPesr.IsEnabled = false;
                NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNextFals");
                Pause.IsEnabled = false;
                Pause.Style = (Style)Pause.FindResource("ButtonNextFals");
                Btn(true);
            };
            StaticClass.styleEndMethod += () =>
            {
                NextBtnPesr.IsEnabled = true;
                NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
                Pause.IsEnabled = true;
                Pause.Style = (Style)Pause.FindResource("ButtonNext");
                Btn(false);
            };
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Button2_Click();
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width - 300);
            this.Top = desctop.Bottom - this.Height;

            BtnShow.Visibility = Visibility.Visible;
            BtnHide.Visibility = Visibility.Hidden;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            /*var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width - 300);
            this.Top = desctop.Bottom - this.Height;
            BtnShow.Visibility = Visibility.Visible;*/
        }


        private void BtnShow_MouseEnter(object sender, MouseEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width);
            this.Top = desctop.Bottom - (this.Height);
            BtnShow.Visibility = Visibility.Hidden;
            BtnHide.Visibility = Visibility.Visible;
        }

        private void Button2_Click(object sender = null, RoutedEventArgs e = null)
        {
            List2.Height = 180;
            List2.Visibility = Visibility.Visible;
            if (List1.Visibility == Visibility.Visible)
            {
                List1.Height = 0;
                List1.Visibility = Visibility.Hidden;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            List1.Height = 180;
            List1.Visibility = Visibility.Visible;
            if (List2.Visibility == Visibility.Visible)
            {
                List2.Height = 0;
                List2.Visibility = Visibility.Hidden;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowNambe.Text = "Окно №";
            OzidanieBtn.Text = "Завершенные";
            OcheredBtn.Text = "Очередь";
            NextBtnPesr.Tag = "Следуюший";
            Pause.Tag = "Пауза";
            //Next.Tag = "Начать Обслуживание";
            Vyzov.Tag = "Вызов";
            Kassa.Tag = "На кассу";
            AndBtn.Tag = "Завершить";
            Otlozhit.Tag = "Отложить";
            Perevod.Tag = "Перенаправить";
            ButtonFaile.Tag = "Неявка";
        }

        private void Button_Click_2(object sender = null, RoutedEventArgs e = null)
        {
            WindowNambe.Text = "Терезе №";
            OzidanieBtn.Text = "Аяктаган";
            OcheredBtn.Text = "Күтүдө";
            NextBtnPesr.Tag = "Кийинки";
            Pause.Tag = "Тыным";
            //Next.Tag = "Тейлеп Баштоо";
            Vyzov.Tag = "Чакыруу";
            Kassa.Tag = "Кассага";
            AndBtn.Tag = "Бүтүрүү";
            Otlozhit.Tag = "Күтүүгө койуу";
            Perevod.Tag = "Которуу";
            ButtonFaile.Tag = "Келбеди";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowNambe.Text = "Window №";
            WindowNambe.FontSize = 17;
            OzidanieBtn.Text = "Completed";
            OcheredBtn.Text = "Turns";
            NextBtnPesr.Tag = "Next";
            Pause.Tag = "Pause";
            // Next.Tag = "Start Service";
            Vyzov.Tag = "Call";
            AndBtn.Tag = "Complete";
            Kassa.Tag = "To the Cash";
            Otlozhit.Tag = "Postpone";
            Perevod.Tag = "Redirect";
            ButtonFaile.Tag = "Absence";
        }
        private void NextBtnPesr_Click(object sender = null, RoutedEventArgs e = null)
        {
            NextBtnPesr.IsEnabled = false;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNextFals");
            Pause.IsEnabled = false;
            Pause.Style = (Style)Pause.FindResource("ButtonNextFals");
            Btn(true);
        }
        private void Btn(bool x)
        {
            string xx;
            if (x)
                xx = "ButtonNext";
            else xx = "ButtonNextFals";



            Vyzov.IsEnabled = x;
            Vyzov.Style = (Style)Pause.FindResource(xx);
            //Pause.IsEnabled = !x;
            ButtonFaile.IsEnabled = x;
            ButtonFaile.Style = (Style)Pause.FindResource(xx);
            Otlozhit.IsEnabled = x;
            Otlozhit.Style = (Style)Pause.FindResource(xx);
            AndBtn.IsEnabled = x;
            AndBtn.Style = (Style)Pause.FindResource(xx);
            Kassa.IsEnabled = x;
            Kassa.Style = (Style)Pause.FindResource(xx);
            Perevod.IsEnabled = x;
            Perevod.Style = (Style)Pause.FindResource(xx);
        }
        bool pauseb = false;
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            pauseb = !pauseb;
            string x = Pause.Tag.ToString();
            if (NextBtnPesr.IsEnabled == true)
            {

                if (x == "Пауза") Pause.Tag = "Продолжить";
                if (x == "Тыным") Pause.Tag = "Улантуу";
                if (x == "Pause") Pause.Tag = "Continue";
                Btn(false);
                NextBtnPesr.IsEnabled = false;
                NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNextFals");
            }
            else
            {
                if (x == "Продолжить") Pause.Tag = "Пауза";
                if (x == "Улантуу") Pause.Tag = "Тыным";
                if (x == "Continue") Pause.Tag = "Pause";
                NextBtnPesr.IsEnabled = true;
                NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
                //Btn(true);
            }
        }


        private void AndBtn_Click(object sender = null, RoutedEventArgs e = null)
        {
            NextBtnPesr.IsEnabled = true;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
            Pause.IsEnabled = true;
            Pause.Style = (Style)Pause.FindResource("ButtonNext");
            Btn(false);
        }

        private void ButtonFaile_Click(object sender, RoutedEventArgs e)
        {
            NextBtnPesr.IsEnabled = true;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
            Pause.IsEnabled = true;
            Pause.Style = (Style)Pause.FindResource("ButtonNext");
            Btn(false);
        }

        public void MeassageT()
        {
            NextBtnPesr_Click();
        }
        public void MeassageT1()
        {
            AndBtn_Click();
        }
        private void Otlozhit_Click(object sender, RoutedEventArgs e)
        {
            NextBtnPesr.IsEnabled = true;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
            Pause.IsEnabled = true;
            Pause.Style = (Style)Pause.FindResource("ButtonNext");
            Btn(false);
        }

        private void Perevod_Click(object sender, RoutedEventArgs e)
        {
            NextBtnPesr.IsEnabled = true;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
            Pause.IsEnabled = true;
            Pause.Style = (Style)Pause.FindResource("ButtonNext");
            Btn(false);
        }

        private void Kassa_Click(object sender, RoutedEventArgs e)
        {
            NextBtnPesr.IsEnabled = true;
            NextBtnPesr.Style = (Style)Pause.FindResource("ButtonNext");
            Pause.IsEnabled = true;
            Pause.Style = (Style)Pause.FindResource("ButtonNext");
            Btn(false);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width - 300);
            this.Top = desctop.Bottom - this.Height;
            BtnShow.Visibility = Visibility.Visible;
            BtnHide.Visibility = Visibility.Hidden;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            var desctop = System.Windows.SystemParameters.WorkArea;
            this.Left = desctop.Right - (this.Width);
            this.Top = desctop.Bottom - (this.Height);
            BtnShow.Visibility = Visibility.Hidden;
            BtnHide.Visibility = Visibility.Visible;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

