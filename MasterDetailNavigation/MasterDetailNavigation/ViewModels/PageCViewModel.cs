using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailNavigation.ViewModels
{
    class PageCViewModel : ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; private set; }

        public PageCViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page C";

            NavigateCommand = new DelegateCommand(async () =>
            {
                await NavigationService.NavigateAsync("PageD");
            });
        }
    }
}
