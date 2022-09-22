﻿using System;
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

            viewModel.Init();
        }


    }
}
