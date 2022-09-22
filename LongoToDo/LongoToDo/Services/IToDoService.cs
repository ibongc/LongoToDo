using System;
using Refit;
using System.Threading.Tasks;
using System.Collections.Generic;
using LongoToDo.Models;
using System.Net.Http;

namespace LongoToDo.Services
{
    [Headers("HOST:127.0.0.1")]
    public interface IToDoService
    {
        [Get("/api/todo")]
        Task<List<ToDoItemModel>>GetToDoList();

        [Post("/api/todo")]
        Task CreateToDoItem([Body] ToDoItemModel user);

        [Delete("/api/todo/{key}")]
        Task DeleteToDoItem(string key);

    }
}

