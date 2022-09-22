using System.Threading.Tasks;

namespace LongoToDo.Helper
{
    public interface IMessagesHelper
    {
        Task ShowMessageAsync(string title, string message);
    }
}