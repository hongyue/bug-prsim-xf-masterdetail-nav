using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailNavigation.ViewModels
{
    class MyMasterDetailPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MyMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(async (url) =>
            {
                var result = await NavigationService.NavigateAsync(url);
                if (result.Success == false)
                {

                }
            });
        }
    }
}
