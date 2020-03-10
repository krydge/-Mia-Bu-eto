using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace MyBudget.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly IPageDialogService _pageDialogService;
        private string compareHash;
        private string compareUserName;
        
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogeService)
            : base(navigationService)
        {
            _pageDialogService = pageDialogeService;
            Title = "Main Page";
            Preferences.Set("Password", "true");
            Preferences.Set("UserName", "krydge");
        }

        //public void HashSet()
        //{
        //    foreach(char i in Password){

        //    }
        //    Password=
        //}

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public Command testPassword;
        public Command TestPassword => testPassword ?? (testPassword = new Command(async() =>
        {
            if (Password == Preferences.Get("Password", "") && UserName == Preferences.Get("UserName", ""))
            {
                NavigationParameters parameters = new NavigationParameters();
                await Services.TestNavigationService.TestableNavigateAsync(NavigationService, nameof(MyBudget.Views.OverViewPage), parameters, true, true);
            }
            else
            {
                await _pageDialogService.DisplayAlertAsync("Invalide Password or UserName", "Either your UserName or Passwrd does not match", "Acknowledge");
            }
        }));
    }
}
