using Microsoft.Extensions.DependencyInjection;
using PultOperatorNetCore.BisnesLayer.Services;
using PultOperatorNetCore.BisnesLayer.Services.AbstractServices;
using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.View;
using PultOperatorNetCore.ViewModel;
using PultOperatorNetCore.ViewModel.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PultOperatorNetCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            AppDbContextSqlLite contextSqlLite=new AppDbContextSqlLite();
            contextSqlLite.ConnectWihtBase();
            StaticClass.Login= contextSqlLite.GetLogin();
            StaticClass.IsCheck= contextSqlLite.GetIsCheck();
            StaticClass.IpAddress = contextSqlLite.GetIpAddress();
            StaticClass.WindowNumber = contextSqlLite.GetWindow();
            IServiceProvider serviceProvider = CreateServiceProvider();
            Identification identification = new Identification();
            identification.DataContext = serviceProvider.GetRequiredService<IdentificationViewModel>();
            identification.Show();
        }
        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<AppDbContextFactory>();
            services.AddSingleton<ITurnsService, TurnsService>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IOptionsService, OptionsService>();
            services.AddSingleton<IPositionSevService, PositionSevService>();
            services.AddSingleton<IPositionServices, PositionServices>();
            services.AddSingleton<ICurrentTurnService, CurrentTurnService>();
            services.AddSingleton<IHistoryTurnService, HistoryTurnService>();

            services.AddScoped<IdentificationViewModel>();
            services.AddScoped<MainWindowViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
