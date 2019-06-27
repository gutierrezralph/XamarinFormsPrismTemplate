using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsPrismTemplate.Common.Mapper;
using XamarinFormsPrismTemplate.Common.Mapper.Mapper;
using XamarinFormsPrismTemplate.Managers;
using XamarinFormsPrismTemplate.Managers.Bluetooth;
using XamarinFormsPrismTemplate.Managers.User;
using XamarinFormsPrismTemplate.Repository;
using XamarinFormsPrismTemplate.Repository.Repository;
using XamarinFormsPrismTemplate.View;
using XamarinFormsPrismTemplate.ViewModel;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinFormsPrismTemplate
{
	public partial class App : PrismApplication
	{
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Startup, StartupViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<BluetoothPage, BluetoothPageViewModel>();
            containerRegistry.RegisterForNavigation<ApiPage, ApiPageViewModel>();
            containerRegistry.RegisterForNavigation<DatabasePage, DatabasePageViewModel>();
            containerRegistry.Register<IBluetoothManager, BluetoothManager>();
            containerRegistry.RegisterSingleton<IMapperService, MapperService>();
            containerRegistry.Register<IUserRepository, UserRepository>();
            containerRegistry.Register<IUserManager, UserManager>();
            containerRegistry.Register<IDataProvider, DataProvider>();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
