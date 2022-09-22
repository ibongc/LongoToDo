using System;
using Refit;
using System.Threading.Tasks;
using System.Collections.Generic;
using APIClient.ApiModels;

namespace APIClient.Services
{
    [Headers("HOST:127.0.0.1")]
    public interface IToDoService
    {
        [Get("/api/todo")]
        Task<List<ToDoApiModel>>GetToDoList();

        [Post("/api/todo")]
        Task CreateToDoItem([Body] ToDoApiModel user);
    }
}

