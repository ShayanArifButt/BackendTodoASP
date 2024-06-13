using System.Collections.Generic;
using System.Threading.Tasks;
using BackendTodoASP.DTOs;
using BackendTodoASP.Models;

namespace BackendTodoASP.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDto>> GetTasksAsync();
        Task<TaskDto?> GetTaskByIdAsync(int id);
        Task<TaskItem?> GetTaskByIdEntityAsync(int id);
        Task<TaskDto> AddTaskAsync(TaskDto taskDto);
        Task UpdateTaskAsync(TaskItem task, TaskDto taskDto);
        Task DeleteTaskAsync(int id);
    }
}
