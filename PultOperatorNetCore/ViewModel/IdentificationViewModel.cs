using PultOperatorNetCore.BisnesLayer.Services.AbstractServices;
using PultOperatorNetCore.Commands;
using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.Model;
using PultOperatorNetCore.ViewModel.BaseViewModel;
using PultOperatorNetCore.ViewModel.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PultOperatorNetCore.ViewModel
{
    public class IdentificationViewModel : BaseView
    {
        public ICommand ExitCommand { get; }
        public ICommand UpdatePassword { get; }
        public ICommand SaveDataToProjectCommand { get; }
        private bool CanSaveServiceCommandExecute(object arg) => true;
        private readonly IUserService _userService;
        private readonly IPositionSevService _positionServices;
        private readonly ITurnsService _turnServices;
        private readonly ICurrentTurnService _currentTurnService;
        private readonly IHistoryTurnService _historyTurnService;
        private readonly IOptionsService _optionsService;


        #region Properties
        private string login;
        public string Login
        {
            get { return login; }
            set { Set(ref login, value); }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }
        private string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set { Set(ref newPassword, value); }
        }
        private string repeatPassword;
        public string RepeatPassword
        {
            get { return repeatPassword; }
            set { Set(ref repeatPassword, value); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { Set(ref message, value); }
        }

        private int heightWindow;
        public int HeightWindow
        {
            get { return heightWindow; }
            set { Set(ref heightWindow, value); }
        }
        private bool _isLoading = false;
        public bool IsLoading
        {
            get { return _isLoading; }
            set { Set(ref _isLoading, value); }
        }
        private bool _isCheckedBox;
        public bool IsCheckedBox
        {
            get { return _isCheckedBox; }
            set { Set(ref _isCheckedBox, value); }
        }
        #endregion Properties
        public IdentificationViewModel(IUserService userService,
            IPositionSevService positionServices,
            ITurnsService turnServices,
            ICurrentTurnService currentTurnService,
            IHistoryTurnService historyTurnService,
            IOptionsService optionsService)
        {

            ExitCommand = new Command(ExitCommandExecuted, CanSaveServiceCommandExecute);
            UpdatePassword = new Command(UpdateCommandExecuted, CanSaveServiceCommandExecute);
            SaveDataToProjectCommand = new Command(SaveDataToProjectMethod, CanSaveServiceCommandExecute);
            _userService = userService;
            _positionServices = positionServices;
            _turnServices = turnServices;
            _currentTurnService = currentTurnService;
            _historyTurnService = historyTurnService;
            _optionsService = optionsService;

            if (StaticClass.IsCheck)
            {
                login = StaticClass.Login;
                IsCheckedBox = true;
            }
            LoadAllOptionsMethod();


        }
        private async void LoadAllOptionsMethod()
        {
            try
            {
                StaticClass.Options = await _optionsService.GetAllAsync();
            }
            catch
            {
                Message = "Нет соединения с сервером!";
            }
        }
        private void SaveDataToProjectMethod(object obj)
        {
            CheckBox checkBox = obj as CheckBox;
            AppDbContextSqlLite contextSqlLite = new AppDbContextSqlLite();
            if (checkBox.IsChecked == true)
            {
                contextSqlLite.SqlLiteCommand($"UPDATE AllBase SET Login='{Login}'," +
                    $" Password='{Password}', IsCheck='{1}' WHERE id='1' ");
                
            }
            if (checkBox.IsChecked == false)
            {
                contextSqlLite.SqlLiteCommand($"UPDATE AllBase SET IsCheck='{0}' WHERE id='1' ");
            }
        }

        private async void UpdateCommandExecuted(object obj)
        {
            if (NewPassword != "" && RepeatPassword != "" && Login != "" && Password != "")
            {
                if (NewPassword == RepeatPassword)
                {
                    User user = await _userService.GetFirstAsync(x => x.Login == Login && x.Password == Password);
                    if (user != null)
                    {
                        user.Password = NewPassword;
                        await _userService.UpdateAsync(user.Id, user);
                        Message = "Пароль успешно обновлен!";
                        Password = NewPassword;
                        Window window = obj as Window;
                        window.Height = 190;
                    }
                    else
                        Message = "Неверный логин или пароль!";
                }
                else
                {
                    Message = "Новый пароль не совподаеть!";
                }

            }
            else
            {
                Message = "заполните все поля!";
            }
        }

        private async void ExitCommandExecuted(object obj)
        {

            if (Login != "" && Password != "")
            {

                IsLoading = true;

                StaticClass.user = await _userService.GetFirstAsync(x => x.Login == Login && x.Password == Password);
                if (StaticClass.user != null)
                {
                    StaticClass.user.AtWork = 1;
                    await _userService.UpdateAsync(StaticClass.user.Id, StaticClass.user);
                    MainWindow window = new MainWindow();
                    window.DataContext = new MainWindowViewModel(_positionServices,
                        _turnServices,
                        _currentTurnService,
                        _historyTurnService,
                        _userService,
                        _optionsService);
                    window.Show();
                    if (obj != null)
                    {
                        Window win = obj as Window;
                        win.Close();

                    }
                    
                }
                else
                {
                    Message = "Неверный логин или пароль!";
                    IsLoading = false;
                }
            }
            else
            {
                Message = "Введите логин или пароль!";
            }
        }


    }
}
