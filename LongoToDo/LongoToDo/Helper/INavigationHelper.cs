using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LongoToDo.Helper
{
    public interface INavigationHelper
    {
        string CurrentPageKey { get; }

        void Configure(string pageKey, Type pageType);
        Task GoBack();
        Task NavigateAsync(string pageKey, bool animated = true);
        Task NavigateAsync(string pageKey, object parameter, bool animated = true);
        Page SetRootPage(string rootPageKey);
    }
}