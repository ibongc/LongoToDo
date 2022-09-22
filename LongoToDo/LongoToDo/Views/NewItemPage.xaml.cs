using System;
using System.Collections.Generic;
using LongoToDo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LongoToDo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        NewItemViewModel viewModel;

        public NewItemPage()
        {
            InitializeComponent();

            viewModel = new NewItemViewModel();

            this.BindingContext = viewModel;
        }
    }
}

