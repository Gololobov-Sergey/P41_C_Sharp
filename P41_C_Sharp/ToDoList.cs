using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P41_C_Sharp
{

    public enum TaskStatus
    {
        NotStarted, InProgress, Completed, Deferred
    }

    class Task
    {
        public TaskStatus Status { get; set; } = TaskStatus.NotStarted;

        public string? Name { get; set; }

        public string? Description { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} {Status} {Description}");
        }

    }
    internal class ToDoList
    {
        Task[]? tasks = null;

        public void Add(Task task)
        {
            Task[] newTasks = tasks == null ? new Task[1] : new Task[tasks.Length + 1];
            if (tasks == null) 
            {
                newTasks[0] = task;
            }
            else
            {
                Array.Copy(tasks, newTasks, tasks.Length);
                newTasks[tasks.Length] = task;
            }
               
            tasks = newTasks;
        }

        public void ChangeStatus(TaskStatus status, int index)
        {
            tasks[index].Status = status;
        }

        public void PrintTasks(TaskStatus status)
        {
            Console.WriteLine($"Task in status : {status}");
            foreach (var item in tasks)
            {
                if(item.Status == status)
                    item.Print();
            }
            Console.WriteLine();
        }
    }
}
