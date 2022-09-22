using System;
using LongoToDo.ViewModels;
using System.Collections.Generic;
using LongoToDo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LongoToDo.Helper;

namespace LongoToDo
{
    public partial class App : Application
    {
        public static INavigationHelper NavigationService { get; } = new NavigationHelper();

        public App()
        {
            InitializeComponent();

            configureNavigationHelper();

            var mainPage = ((NavigationHelper)NavigationService).SetRootPage("HomePage");

            MainPage = mainPage;
        }

        private void configureNavigationHelper()
        {
            NavigationService.Configure("HomePage", typeof(Views.HomePage));
            NavigationService.Configure("NewItemPage", typeof(Views.NewItemPage));
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}

