using System;
using System.Collections.Generic;
using System.Net.Http;
using APIClient.Services;
using LongoToDo.ViewModels;
using Refit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LongoToDo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();

            
            viewModel = new HomeViewModel();

            this.BindingContext = viewModel;

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.Init();
        }

        void New_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewItemPage());
        }

    }
}

