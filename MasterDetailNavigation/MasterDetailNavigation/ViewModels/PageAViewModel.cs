using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailNavigation.ViewModels
{
    class PageAViewModel : ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; private set; }

        public PageAViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page A";
            NavigateCommand = new DelegateCommand(async () =>
            {
                var result = await NavigationService.NavigateAsync("PageB");
                if (!result.Success)
                {

                }
            });
        }
    }
}
