using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using APIClient.ApiModels;
using APIClient.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LongoToDo.Services;
using Refit;
using Xamarin.CommunityToolkit.ObjectModel;

namespace LongoToDo.ViewModels
{
    [INotifyPropertyChanged]
    public partial class HomeViewModel
    {

        [ObservableProperty]
        private ObservableCollection<ToDoApiModel> todoItems;

        [RelayCommand]
        void NewItem()
        {
            App.NavigationService.NavigateAsync("NewItemPage");
        }

        public HomeViewModel()
        {
            
        }

        public async Task Init()
        {
            TodoItems = new ObservableCollection<ToDoApiModel>(await ToDoService.GetTodoItems());       
        }
    }
}

