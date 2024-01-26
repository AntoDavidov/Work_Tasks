using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Tasks
{
    [Serializable]
    internal class Company
    {

        public string Name { get; set; }
        public List<Employee> Employees {  get; set; }
        public List<Task> Tasks {  get; set; }

        public int TaskIDCounter {  get; set; }

        public Company(string name) 
        {
            this.Name = name;
            Employees = new List<Employee>();
            Tasks = new List<Task>();
            
        }
        public void AddTask(Task task)
        {
            if (!Tasks.Any(t => t.TaskID == task.TaskID))
            {
                Tasks.Add(task);
            }
        }

        public void RemoveTask(int taskId)
        {
            Task task = Tasks.FirstOrDefault(t => t.TaskID == taskId);
            if (task != null && task.CanBeRemoved())
            {
                Tasks.Remove(task);
            }
        }
        public void UpdateTask(Task updatedTask)
        {
            var task = Tasks.FirstOrDefault(t => t.TaskID == updatedTask.TaskID);
            if (task != null)
            {
                
            }
        }

    }
}
