using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendTodoASP.DTOs;
using BackendTodoASP.Models;
using BackendTodoASP.Repositories;

namespace BackendTodoASP.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<TaskDto>> GetTasksAsync()
        {
            var tasks = await _taskRepository.GetTasksAsync();
            return tasks.Select(t => new TaskDto
            {
                Id = t.Id,
                Description = t.Description,
                IsDone = t.IsDone,
                Deadline = t.Deadline
            });
        }

        public async Task<TaskDto?> GetTaskByIdAsync(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            if (task == null)
            {
                return null;
            }

            return new TaskDto
            {
                Id = task.Id,
                Description = task.Description,
                IsDone = task.IsDone,
                Deadline = task.Deadline
            };
        }

        public async Task<TaskItem?> GetTaskByIdEntityAsync(int id)
        {
            var task = await _taskRepository.GetTaskByIdAsync(id);
            if (task == null)
            {
                return null;
            }

            return task;
        }


        public async Task<TaskDto> AddTaskAsync(TaskDto taskDto)
        {
            var task = new TaskItem
            {
                Description = taskDto.Description,
                IsDone = taskDto.IsDone,
                Deadline = taskDto.Deadline
            };

            var createdTask = await _taskRepository.AddTaskAsync(task);

            return new TaskDto
            {
                Id = createdTask.Id,
                Description = createdTask.Description,
                IsDone = createdTask.IsDone,
                Deadline = createdTask.Deadline
            };
        }

        public async Task<TaskDto> UpdateTaskAsync(TaskItem task, TaskDto taskDto)
        {
            task.Description = taskDto.Description;
            task.IsDone = taskDto.IsDone;
            task.Deadline = taskDto.Deadline;

            await _taskRepository.UpdateTaskAsync(task);

            // Map the updated entity to a TaskDto and return it
            return new TaskDto
            {
                Id = task.Id,
                Description = task.Description,
                IsDone = task.IsDone,
                Deadline = task.Deadline
            };
        }

        public async Task DeleteTaskAsync(int id)
        {
            await _taskRepository.DeleteTaskAsync(id);
        }
    }
}
