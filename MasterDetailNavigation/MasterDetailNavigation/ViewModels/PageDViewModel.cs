using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailNavigation.ViewModels
{
    class PageDViewModel : ViewModelBase
    {
        public PageDViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Page D";
        }
    }
}
