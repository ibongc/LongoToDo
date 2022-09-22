using System;
using LongoToDo;
using System.Threading.Tasks;

namespace LongoToDo.Helper
{
    public class MessagesHelper : IMessagesHelper
    {
        public async Task ShowMessageAsync(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }
    }
}

