using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailNavigation.ViewModels
{
    class PageBViewModel : ViewModelBase
    {
        public PageBViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page B";
        }
    }
}
