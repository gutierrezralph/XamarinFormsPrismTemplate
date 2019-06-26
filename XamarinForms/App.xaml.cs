using XamarinForms.Common.Mapper;
using XamarinForms.Common.Mapper.Mapper;
using XamarinForms.Managers;
using XamarinForms.Managers.Bluetooth;
using XamarinForms.Managers.User;
using XamarinForms.Repository;
using XamarinForms.Repository.Repository;
using XamarinForms.View;
using XamarinForms.ViewModel;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinForms
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
