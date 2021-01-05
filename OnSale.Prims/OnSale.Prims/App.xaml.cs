using OnSale.Common.Services;
using OnSale.Prims.ViewModels;
using OnSale.Prims.Views;
using Prism;
using Prism.Ioc;
using Syncfusion.Licensing;
using System;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace OnSale.Prims
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("Mzc4MjA5QDMxMzgyZTM0MmUzMG9xQlJqQkNsc0RmWWhHTThsZTJrMmF5NEFJby9OQ212NVd3K1Y0bCtZSTQ9");
            InitializeComponent();

            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ProductsPage)}");
        }

        private object Products()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
        }
    }
}
