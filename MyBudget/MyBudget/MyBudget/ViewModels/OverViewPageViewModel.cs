using MyBudget.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MyBudget.ViewModels
{
    public class OverViewPageViewModel : ViewModelBase
    {

        public IList<BudgetItem> BudgetItems { get; private set; }
        public OverViewPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            BudgetItems = new List<BudgetItem>();
            SetBudgetItems();
        }

        public void SetBudgetItems()
        {
            BudgetItems.Add(new BudgetItem
            {
                Price = 10.59,
                Title = "Hamburger",
                Description= "A hamburger from fredds",

            });
            BudgetItems.Add(new BudgetItem
            {
                Price = 10.59,
                Title = "hotDog",
                Description = "A hotdog from fredds"
            });
            BudgetItems.Add(new BudgetItem
            {
                Price = 10.59,
                Title = "Hamburger",
                Description = "A hamburger from fredds"
            });
            BudgetItems.Add(new BudgetItem
            {
                Price = 10.59,
                Title = "Hamburger",
                Description = "A hamburger from fredds"
            });
        }


            public Command moneyIn;
            public Command MoneyIn => moneyIn ?? (moneyIn = new Command( async() =>
            {
                NavigationParameters parameters = new NavigationParameters();
                await Services.TestNavigationService.TestableNavigateAsync(NavigationService, nameof(MyBudget.Views.AddItemPage), parameters, true, true);
            }));

        public Command moneyOut;
        public Command MoneyOut => moneyOut ?? (moneyOut = new Command(async () =>
        {
            NavigationParameters parameters = new NavigationParameters();
            await Services.TestNavigationService.TestableNavigateAsync(NavigationService, nameof(MyBudget.Views.SubtractItemPage), parameters, true, true);
        }));
    }
}
