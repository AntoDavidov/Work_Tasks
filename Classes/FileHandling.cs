using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tasks
{
    internal class FileHandling
    {
        public List<Employee> LoadCSVData(string filename)
        {
            var employees = new List<Employee>();
            var lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (int.TryParse(data[0], out var id)) // Here I am ensuring that data[0] is a valid int
                {
                    var employee = new Employee
                    {
                        Id = id,
                        SSN = data[1],
                        FirstName = data[2],
                        LastName = data[3],
                        Gender = data[4],
                        StreetName = data[5],
                        StreetNumber = data[6],
                        Zipcode = data[7],
                        City = data[8],
                        Email = data[9],
                        Department = data[10],
                    };
                    employees.Add(employee);
                }
            }

            return employees;
        }
        public void SaveCompanyData(string filePath, Company company)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, company);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Company LoadCompanyData(string filePath)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (Company)bf.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }
    }
}
