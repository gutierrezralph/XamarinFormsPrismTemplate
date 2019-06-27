using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism;
using Prism.Ioc;
using XamarinForms.Android.Service;
using XamarinForms.Common.Bluetooth;
using XamarinForms.Repository;
using XamarinForms.Android.Database;

namespace XamarinForms.Android
{
    [Activity(Label = "ERNIPrismTemplate", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
           
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IBluetoothService, BluetoothService>();
            containerRegistry.Register<IDatabaseFactory, DatabaseFactory>();
        }
    }
}

