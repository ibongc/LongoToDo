using System;
using System.Collections.Generic;
using LongoToDo.ViewModels;
using Xamarin.Forms;

namespace LongoToDo.Views
{
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

