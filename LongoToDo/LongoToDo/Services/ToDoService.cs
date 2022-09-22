using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using APIClient.ApiModels;
using APIClient.Services;
using Refit;

namespace LongoToDo.Services
{
    public static class ToDoService
    {

        public static async Task<List<ToDoApiModel>> GetTodoItems()
        {
            var toDoItems = new List<ToDoApiModel>();

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


        public static async Task CreateToDoItem(ToDoApiModel item)
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
        
    }
}

