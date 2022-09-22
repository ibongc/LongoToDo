using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LongoToDo.Helper;
using LongoToDo.Models;
using LongoToDo.Services;
using Refit;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace LongoToDo.ViewModels
{
    [INotifyPropertyChanged]
    public partial class HomeViewModel
    {

        [ObservableProperty]
        private ObservableCollection<ToDoItemModel> todoItems;

        [RelayCommand]
        void NewItem()
        {
            //Naviagte to New Item Page
            App.NavigationService.NavigateAsync("NewItemPage");
        }

        [RelayCommand]
        async Task DeleteItem(ToDoItemModel item)
        {
            //Delete de item
            await ToDoService.DeleteToDoItem(item.Key);

            //Remove it from list
            todoItems.Remove(item);

            //Show the message
            var _messageHelper = DependencyService.Get<IMessagesHelper>();
            await _messageHelper.ShowMessageAsync("Deleted", $"ToDo item {item.Name} has been deleted correctly");
     
            
        }

        [RelayCommand]
        async Task CheckItem(ItemTappedEventArgs args)
        {
            
            var item = args.Item as ToDoItemModel;
            if (item != null)
                item.IsComplete = !item.IsComplete;
            
            
                

        }

        public HomeViewModel()
        {
            
        }

        public async Task Init()
        {
            //Get items from remote API
            TodoItems = new ObservableCollection<ToDoItemModel>(await ToDoService.GetTodoItems());       
        }
    }
}

