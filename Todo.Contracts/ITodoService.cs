using Todo.Models;

namespace Todo.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoForGettingDto>> GetAllTodosAsync();
        Task<TodoForGettingDto> GetSingleTodoAsync(int id);
        Task<TodoForGettingDto> GetSingleTodoAsync(string userId, int id);
        Task AddTodoAsync(TodoForCreatingDto model);
        Task AddTodoAsync(TodoForCreatingDto model, string userId);
        Task UpdateTodoAsync(TodoForUpdatingDto model);
        Task DeleteTodoAsync(int id);
        Task DeleteTodoAsync(string userId, int id);
        Task<List<TodoForGettingDto>> GetUserTodosAsync(string userId);
    }
}
