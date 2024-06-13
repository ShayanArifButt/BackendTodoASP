using System.Collections.Generic;
using System.Threading.Tasks;
using BackendTodoASP.DTOs;

namespace BackendTodoASP.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetTasksAsync();
        Task<TaskDto?> GetTaskByIdAsync(int id);
        Task<TaskDto> AddTaskAsync(TaskDto taskDto);
        Task UpdateTaskAsync(TaskDto taskDto);
        Task DeleteTaskAsync(int id);
    }
}
