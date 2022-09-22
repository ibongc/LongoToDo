using System;
using System.ComponentModel;
using System.Drawing;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LongoToDo.Models
{
    [INotifyPropertyChanged]
    public partial class ToDoItemModel
    {
        public string Key { get; set; }
        public string Name { get; set; }

        [ObservableProperty]
        bool isComplete;

    }
}

