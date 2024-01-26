using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Tasks
{
    [Serializable]
    internal class Task
    {
        public int TaskID {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public List<string> Departments { get; set; }
        public List<Employee> AssignedEmployees { get; set; }

        public Task()
        {
            Departments = new List<string>();
            AssignedEmployees = new List<Employee>();
        }
        public override string ToString()
        {
            var assignedEmployees = String.Join(", ", AssignedEmployees.Select(e => $"{e.FirstName} {e.LastName}"));
            return $"[{TaskID}] {Title} - Assigned to: {assignedEmployees} Deadline: {Deadline}";
        }
        public bool CanBeRemoved()
        {
            return Status == "Open" && AssignedEmployees.Count == 0;
        }
        public void AssignEmployee(Employee employee)
        {
            if (!AssignedEmployees.Contains(employee))
            {
                AssignedEmployees.Add(employee);
                employee.AssignTask(this);
            }
        }
        
    }
}
