using MyBudget.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace MyBudget.ViewModels
{
    public class OverViewPageViewModel : BindableBase
    {

        public IList<BudgetItem> BudgetItems { get; private set; }
        public OverViewPageViewModel()
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
    }
}
