using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailNavigation.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyMasterDetailPage : IMasterDetailPageOptions
    {
        public bool IsPresentedAfterNavigation => false;

        public MyMasterDetailPage ()
		{
			InitializeComponent ();
		}
	}
}