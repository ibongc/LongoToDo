using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LongoToDo.Helper;
using LongoToDo.Models;
using LongoToDo.Services;
using Xamarin.Forms;

namespace LongoToDo.ViewModels
{
    [INotifyPropertyChanged]
    public partial class NewItemViewModel
    {
        [ObservableProperty]
        ToDoItemModel toDoItem;

        [RelayCommand]
        async Task SaveItem()
        {
            //Is Name is not empty, save and go back
            if (!string.IsNullOrWhiteSpace(toDoItem.Name))
            {
                await ToDoService.CreateToDoItem(toDoItem);
                await App.NavigationService.GoBack();
            }
        }

        public NewItemViewModel()
        {
            toDoItem = new ToDoItemModel();
        }
    }
}

