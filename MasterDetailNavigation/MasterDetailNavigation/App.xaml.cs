using Prism;
using Prism.Ioc;
using MasterDetailNavigation.ViewModels;
using MasterDetailNavigation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.DryIoc;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MasterDetailNavigation
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer, true) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MyMasterDetailPage/NavigationPage/PageA");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PageA, PageAViewModel>();
            containerRegistry.RegisterForNavigation<PageB, PageBViewModel>();
            containerRegistry.RegisterForNavigation<PageC, PageCViewModel>();
            containerRegistry.RegisterForNavigation<PageD, PageDViewModel>();
            containerRegistry.RegisterForNavigation<MyTabbedPage, MyTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<MyMasterDetailPage, MyMasterDetailPageViewModel>();
        }
    }
}
