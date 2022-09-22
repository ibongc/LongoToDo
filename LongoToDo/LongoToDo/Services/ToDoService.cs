using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LongoToDo.Models;
using Refit;

namespace LongoToDo.Services
{
    public static class ToDoService
    {

        public static async Task<List<ToDoItemModel>> GetTodoItems()
        {
            var toDoItems = new List<ToDoItemModel>();

            try
            {

                var todoApiSerive = RestService.For<IToDoService>(Constants.ApiUrl);
                toDoItems = await todoApiSerive.GetToDoList();

            }
            catch (Exception ex)
            {
                //TODO: Manage exception
            }

            return toDoItems;
        }


        public static async Task CreateToDoItem(ToDoItemModel item)
        {
            try
            {

                var todoApiSerive = RestService.For<IToDoService>(Constants.ApiUrl);
                await todoApiSerive.CreateToDoItem(item);

            }
            catch (Exception ex)
            {
                //TODO: Manage exception
            }
        }

        public static async Task DeleteToDoItem(string key)
        {
            try
            {

                var todoApiSerive = RestService.For<IToDoService>(Constants.ApiUrl);
                await todoApiSerive.DeleteToDoItem(key);

            }
            catch (Exception ex)
            {
                //TODO: Manage exception
            }
        }



    }
}

