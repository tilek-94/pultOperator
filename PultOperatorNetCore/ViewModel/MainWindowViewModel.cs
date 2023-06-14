using PultOperatorNetCore.BisnesLayer.Services;
using PultOperatorNetCore.BisnesLayer.Services.AbstractServices;
using PultOperatorNetCore.Commands;
using PultOperatorNetCore.Model;
using PultOperatorNetCore.Model.DtoModels;
using PultOperatorNetCore.View;
using PultOperatorNetCore.ViewModel.BaseViewModel;
using PultOperatorNetCore.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace PultOperatorNetCore.ViewModel
{
    public class MainWindowViewModel : BaseView
    {
        private readonly IPositionSevService _positionServices;
        private readonly ITurnsService _turnServices;
        private readonly ICurrentTurnService _currentTurnService;
        private readonly IHistoryTurnService _historyTurnService;
        private readonly IUserService _userService;
        private readonly IOptionsService _optionsService;
        public ICommand NextCommand { get; }
        public ICommand EndCommand { get; }
        public ICommand ToKassaCommand { get; }
        public ICommand CallCommand { get; }
        public ICommand PauseCommand { get; }
        public ICommand AbsenceCommand { get; }
        public ICommand PostponeCommand { get; }
        public ICommand RedirectCommand { get; }
        public ICommand CloseWindowCommand { get; }
        private bool CanSaveServiceCommandExecute(object arg) => true;
        private bool CallCommandExecute(object arg) => true;
        public static DispatcherTimer? _timer;
        public static DispatcherTimer? _timerForUpdateList;
        #region Properties
        private bool IsCheck { get; set; } = true;
        private int CurrenSecond { get; set; }
        private int IncrementValuse { get; set; }
        private IEnumerable<TurnsDto> _turnList;
        public IEnumerable<TurnsDto> TurnList
        {
            get { return _turnList; }
            set { Set(ref _turnList, value); }
        }
        private IEnumerable<HistoryTurn> _historyTurnList;
        public IEnumerable<HistoryTurn> HistoryTurnList
        {
            get { return _historyTurnList; }
            set { Set(ref _historyTurnList, value); }
        }
        private IEnumerable<User> _userList;
        public IEnumerable<User> UserList
        {
            get { return _userList; }
            set { Set(ref _userList, value); }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { Set(ref _userName, value); }
        }
        private string _timerCall;
        public string TimerCall
        {
            get { return _timerCall; }
            set { Set(ref _timerCall, value); }
        }

        private int _windowNumber;
        public int WindowNumber
        {
            get { return _windowNumber; }
            set { Set(ref _windowNumber, value); }
        }
        private TurnsDto _curentTurn;
        public TurnsDto CurentTurn
        {
            get { return _curentTurn; }
            set { Set(ref _curentTurn, value); }
        }
        private User _selectedUser;
        public User SelectedUser
        {
            get { return _selectedUser; }
            set { Set(ref _selectedUser, value); }
        }
        private TurnsDto _selectedTurn = new TurnsDto();
        public TurnsDto SelectedTurn
        {
            get { return _selectedTurn; }
            set
            {
                if (value != null)
                {
                    if (value.UserId != 0)
                    {
                        DialogWindow dialogWindow = new DialogWindow("Вы хотите выбрать?");
                        dialogWindow._mess += x =>
                        {
                            if (x == 1)
                            {
                                CurentTurn = value;
                                StaticClass.EventMethod();
                                RegisterTurnMethod();
                                CallTimerMethod();

                            }
                        };
                        dialogWindow.ShowDialog();

                    }
                }
            }
        }
        #endregion 
        public MainWindowViewModel(IPositionSevService positionServices, ITurnsService turnServices, ICurrentTurnService currentTurnService, IHistoryTurnService historyTurnService, IUserService userService, IOptionsService optionsService)
        {
            NextCommand = new Command(NextCommandExecuted, CanSaveServiceCommandExecute);
            EndCommand = new Command(EndCommandExecuted, CanSaveServiceCommandExecute);
            CallCommand = new Command(CallCommandExecuted, CallCommandExecute);
            AbsenceCommand = new Command(AbsenceCommandExecuted, CallCommandExecute);
            PostponeCommand = new Command(PostponeCommandExecuted, CallCommandExecute);
            RedirectCommand = new Command(RedirectCommandExecuted, CallCommandExecute);
            ToKassaCommand = new Command(ToKassaCommandExecuted, CallCommandExecute);
            PauseCommand = new Command(PauseCommandExecuted, CallCommandExecute);
            CloseWindowCommand = new Command(CloseWindowCommandExecuted, CallCommandExecute);
            _positionServices = positionServices;
            _turnServices = turnServices;
            _currentTurnService = currentTurnService;
            _historyTurnService = historyTurnService;
            _userService = userService;
            _optionsService = optionsService;
            LoadAllDateAsync();
            UserName = StaticClass.user.UserName;
            WindowNumber = StaticClass.WindowNumber;
            CurrenSecond = Convert.ToInt16(StaticClass.Options.Where(x => x.Key == "CustomerCall").Select(x => x.Value).FirstOrDefault());
            SetTimerMethod();
            UpdateListByTimerMethod();

        }

        private async void CloseWindowCommandExecuted(object obj)
        {
            User user = await _userService.GetByIdAsync(StaticClass.user.Id);
            user.AtWork = 0;
            await _userService.UpdateAsync(StaticClass.user.Id, user);
            Window window = obj as Window;
            window.Close();

        }

        private void UpdateListByTimerMethod()
        {
            _timerForUpdateList = new DispatcherTimer(DispatcherPriority.Render);
            _timerForUpdateList.Interval = TimeSpan.FromSeconds(5);
            _timerForUpdateList.Tick += async (sender, args) =>
            {
                TurnList = await _positionServices.GetWithTableAsync(StaticClass.user.PositionId, StaticClass.user.Id);
            };
            _timerForUpdateList.Start();
        }
        private void PauseCommandExecuted(object obj)
        {
            if (_timer.IsEnabled == true)
                _timer.Stop();
            else
                _timer.Start();
        }

        private void SetTimerMethod()
        {
            _timer = new DispatcherTimer(DispatcherPriority.Render);
            _timer.Interval = TimeSpan.FromSeconds(1);
            if (CurrenSecond > 0)
            {
                IncrementValuse = CurrenSecond;
                _timer.Tick += (sender, args) =>
               {
                   TimeSpan time = TimeSpan.FromSeconds(IncrementValuse);
                   TimerCall = time.ToString(@"mm\:ss");
                   IncrementValuse--;
                   if (IncrementValuse == 0)
                   {
                       _timer.Stop();
                       LoadAllDateAsync();
                       CurentTurn = TurnList.FirstOrDefault(x => x.Status != "waiting");
                       RegisterTurnMethod();
                       StaticClass.EventMethod();
                       if (CurentTurn == null)
                       {
                           CallTimerMethod();
                           StaticClass.EventStyleEndMethod();
                       }
                   }
               };
                _timer.Start();
            }
        }
        private void CallTimerMethod()
        {
            if (CurrenSecond > 0)
            {
                IncrementValuse = CurrenSecond;
                _timer.Start();
            }
        }
        private async void ToKassaCommandExecuted(object obj)
        {
            HistoryTurn historyTurn = await _historyTurnService.GetFirstAsync(x => x.TurnId == CurentTurn.Id);
            historyTurn.EndDate = DateTime.Now;
            historyTurn.Absence = 1;
            await _historyTurnService.UpdateAsync(historyTurn.Id, historyTurn);

            Turns? turns = await _turnServices.GetByIdAsync(CurentTurn.Id);
            if (turns != null)
            {
                turns.UserId = 0;
                turns.Status = "kassa";
                turns.CameFrom = null;
                await _turnServices.UpdateAsync(CurentTurn.Id, turns);
                await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);
            }
            LoadAllDateAsync();
            CurentTurn = null;
            CallTimerMethod();


        }

        private async void RedirectCommandExecuted(object obj)
        {
            if (SelectedUser != null)
            {
                Turns? turns = await _turnServices.GetByIdAsync(CurentTurn.Id);
                if (turns != null)
                {
                    turns.UserId = SelectedUser.Id;
                    turns.Status = "Redirect";
                    turns.CameFrom = StaticClass.user.UserName;
                    await _turnServices.UpdateAsync(CurentTurn.Id, turns);
                    await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);
                }
                LoadAllDateAsync();
                CurentTurn = null;
                SelectedUser = null;
                CallTimerMethod();

            }
            else
            {
                StaticClass.EventMethod();
                DialogWindowOk windowOk = new DialogWindowOk("Вы не выбрали сотрудника!");
                windowOk.ShowDialog();
            }

        }

        private async void PostponeCommandExecuted(object obj)
        {
            Turns? turns = await _turnServices.GetByIdAsync(CurentTurn.Id);
            if (turns != null)
            {
                turns.Status = "waiting";
                turns.CameFrom = "В ожидание";
                await _turnServices.UpdateAsync(CurentTurn.Id, turns);
                await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);

            }
            LoadAllDateAsync();
            CurentTurn = null;
            CallTimerMethod();
        }

        private async void AbsenceCommandExecuted(object obj)
        {
            await _turnServices.DeleteAsync(CurentTurn.Id);
            await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);
            LoadAllDateAsync();
            CurentTurn = null;
            CallTimerMethod();
        }

        private async void CallCommandExecuted(object obj)
        {
            if (IsCheck)
            {
                await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);

                CurrentTurn cTurn = new CurrentTurn()
                {
                    TurnNumber = CurentTurn.Number,
                    WindowNumber = StaticClass.WindowNumber,
                    Lang = CurentTurn.Lang,
                    IsSay = 0

                };
                await _currentTurnService.AddAsync(cTurn);
                IsCheck = false;
                SleepMethod();
            }

        }
        private async void SleepMethod()
        {
            await Task.Run(() =>
            {

                Thread.Sleep(1000);
                IsCheck = true;
            });
        }

        private async void EndCommandExecuted(object obj)
        {
            HistoryTurn? historyTurn = await _historyTurnService.GetFirstAsync(x => x.TurnId == CurentTurn.Id);
            historyTurn.EndDate = DateTime.Now;
            historyTurn.Absence = 1;
            await _historyTurnService.UpdateAsync(historyTurn.Id, historyTurn);
            await _turnServices.DeleteAsync(CurentTurn.Id);
            await _currentTurnService.DeleteCurrentTurnAsync(StaticClass.WindowNumber);
            LoadAllDateAsync();
            CurentTurn = null;
            CallTimerMethod();


        }
        private async void NextCommandExecuted(object obj)
        {
            LoadAllDateAsync();
            CurentTurn = TurnList.FirstOrDefault(x => x.Status != "waiting");
            RegisterTurnMethod();

        }
        private async void RegisterTurnMethod()
        {
            try
            {
                if (CurentTurn != null)
                {
                    Turns? turns = await _turnServices.GetByIdAsync(CurentTurn.Id);
                    turns.UserId = StaticClass.user.Id;
                    turns.Status = "served";
                    await _turnServices.UpdateAsync(CurentTurn.Id, turns);

                    CurrentTurn cTurn = new CurrentTurn()
                    {
                        TurnNumber = CurentTurn.Number,
                        WindowNumber = StaticClass.WindowNumber,
                        Lang = CurentTurn.Lang,
                        IsSay = 0
                    };
                    await _currentTurnService.AddAsync(cTurn);
                    HistoryTurn historyTurn = new HistoryTurn()
                    {
                        TurnId = CurentTurn.Id,
                        Number = CurentTurn.Number,
                        ServiceId = CurentTurn.ServiceId,
                        UserId = StaticClass.user.Id,
                        Lang = CurentTurn.Lang,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now
                    };
                    await _historyTurnService.AddAsync(historyTurn);
                    if (_timer.IsEnabled == true)
                        _timer.Stop();
                }
                else
                {
                    StaticClass.EventStyleEndMethod();
                }
            }
            catch
            {

            }
        }
        private async void LoadAllDateAsync()
        {
            TurnList = await _positionServices.GetWithTableAsync(StaticClass.user.PositionId, StaticClass.user.Id);
            UserList = await _userService.GetAllAsync(x => x.AtWork == 1 && x.Id != StaticClass.user.Id);
            HistoryTurnList = await _historyTurnService.GetAllAsync(x => x.UserId == StaticClass.user.Id
            && x.StartDate.Date == DateTime.Now.Date);
        }

    }
}
