using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using CsvHelper.Configuration.Attributes;

namespace Work_Tasks
{
    [Serializable]
    internal class Employee
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("ssn")]
        public string SSN { get; set; }

        [Name("first_name")]
        public string FirstName { get; set; } // Updated to PascalCase

        [Name("last_name")]
        public string LastName { get; set; } // Updated to PascalCase

        [Name("gender")]
        public string Gender { get; set; } // Updated to PascalCase

        [Name("street_name")]
        public string StreetName { get; set; } // Updated to PascalCase

        [Name("street_number")]
        public string StreetNumber { get; set; } // Updated to PascalCase

        [Name("zipcode")]
        public string Zipcode { get; set; } // Updated to PascalCase

        [Name("city")]
        public string City { get; set; } // Updated to PascalCase

        [Name("email")]
        public string Email { get; set; } // Updated to PascalCase

        [Name("Department")]
        public string Department { get; set; }

        public List<Task> AssignedTasks { get; private set; }

        public Employee()
        {
            AssignedTasks = new List<Task>();

        }
        public void AssignTask(Task task)
        {
            if (!AssignedTasks.Contains(task))
            {
                AssignedTasks.Add(task);
            }

        }
        
    }
}