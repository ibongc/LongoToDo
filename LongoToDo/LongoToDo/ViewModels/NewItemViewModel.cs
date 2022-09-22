using System;
using System.Threading.Tasks;
using APIClient.ApiModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LongoToDo.Services;

namespace LongoToDo.ViewModels
{
    [INotifyPropertyChanged]
    public partial class NewItemViewModel
    {
        [ObservableProperty]
        ToDoApiModel toDoItem;

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
            toDoItem = new ToDoApiModel();
        }
    }
}

