using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Work_Tasks
{
    public partial class frmWorkTasks : Form
    {
        private FileHandling fileHandler;
        private int TaskIDCounter = 0;
        private Company company;

        public frmWorkTasks()
        {
            InitializeComponent();
            fileHandler = new FileHandling();
            company = new Company("Nai-dobrata Firma");           
            lstbTasks.SelectedIndexChanged += lstbTasks_SelectedIndexChanged;
            btnUpdate.Click += btnUpdate_Click;
            LoadTasksIntoListBox();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtbFile.Text = dialog.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var employeeList = fileHandler.LoadCSVData(txtbFile.Text);
            dtgData.DataSource = employeeList;
            txtbFile.Text = "";
        }

        private void lstbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbTasks.SelectedIndex != -1)
            {
                Task selectedTask = (Task)lstbTasks.SelectedItem;
                FillTaskFields(selectedTask);
            }
        }

        private void FillTaskFields(Task task)
        {
            txtbTitle.Text = task.Title;
            rchtxtDescr.Text = task.Description;
            cmbStatus.SelectedItem = task.Status;
            dtpDeadline.Value = task.Deadline;

            chbHR.Checked = false;
            chbMarketing.Checked = false;
            chbSales.Checked = false;
            chbSupport.Checked = false;
            chbRD.Checked = false;

            // Check the boxes based on the task's departments
            foreach (var department in task.Departments)
            {
                if (department == chbHR.Text) chbHR.Checked = true;
                if (department == chbMarketing.Text) chbMarketing.Checked = true;
                if (department == chbSales.Text) chbSales.Checked = true;
                if (department == chbSupport.Text) chbSupport.Checked = true;
                if (department == chbRD.Text) chbRD.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtbTitle.Text;
            string description = rchtxtDescr.Text;
            string status = cmbStatus.Text;
            DateTime deadline = dtpDeadline.Value;

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please fill in all fields to create a task.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsAnyDepartmentChecked())
            {
                MessageBox.Show("Please select at least one department for the task.", "No Department Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTask = new Task
            {
                TaskID = company.TaskIDCounter++,
                Title = title,
                Description = description,
                Status = status,
                Deadline = deadline,
                Departments = new List<string>() // assuming departments are handled this way
            };

            // Add departments based on checkboxes
            AddDepartmentsToTask(newTask);  

            company.AddTask(newTask);
            RefreshTaskList();
        }

        private void AddDepartmentsToTask(Task task)
        {
            if (chbHR.Checked) task.Departments.Add(chbHR.Text);
            if (chbMarketing.Checked) task.Departments.Add(chbMarketing.Text);
            if (chbSales.Checked) task.Departments.Add(chbSales.Text);
            if (chbSupport.Checked) task.Departments.Add(chbSupport.Text);
            if (chbRD.Checked) task.Departments.Add(chbRD.Text);
        }

        private void LoadTasksIntoListBox()
        {
            lstbTasks.DataSource = company.Tasks;
            company.TaskIDCounter = company.Tasks.Any() ? company.Tasks.Max(task => task.TaskID) + 1 : 1;
        }
        private bool IsAnyDepartmentChecked()
        {
            return chbHR.Checked || chbMarketing.Checked || chbSales.Checked || chbSupport.Checked || chbRD.Checked;
        }
        private void RefreshTaskList()
        {
            int currentIndex = lstbTasks.SelectedIndex;

            lstbTasks.DataSource = null;
            lstbTasks.DataSource = company.Tasks;
            // Restore the selected index
            if (currentIndex >= 0 && currentIndex < lstbTasks.Items.Count)
            {
                lstbTasks.SelectedIndex = currentIndex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstbTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to update.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the selected index
            int selectedIndex = lstbTasks.SelectedIndex;

            Task selectedTask = (Task)lstbTasks.SelectedItem;

            // Get the updated details from the UI
            selectedTask.Title = txtbTitle.Text;
            selectedTask.Description = rchtxtDescr.Text;
            selectedTask.Status = cmbStatus.Text;
            selectedTask.Deadline = dtpDeadline.Value;

            // Update departments
            selectedTask.Departments.Clear();
            AddDepartmentsToTask(selectedTask);

            // Optionally, update the task in the company's task list
            company.UpdateTask(selectedTask);

            // Refresh the ListBox to reflect changes
            RefreshTaskList();

            // Reselect the task
            if (selectedIndex >= 0 && selectedIndex < lstbTasks.Items.Count)
            {
                lstbTasks.SelectedIndex = selectedIndex;
            }

            MessageBox.Show("Task updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstbTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task to remove.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task selectedTask = (Task)lstbTasks.SelectedItem;

            if (selectedTask.Status != "Open")
            {
                MessageBox.Show("Only tasks with the status 'Open' can be removed.", "Cannot Remove Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove the selected task?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                company.RemoveTask(selectedTask.TaskID);
                RefreshTaskList();
                MessageBox.Show("Task removed successfully.", "Removal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAssignEmployee_Click(object sender, EventArgs e)
        {
            if (lstbTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTask = (Task)lstbTasks.SelectedItem;

            // Get selected employees
            var selectedEmployees = dtgData.SelectedRows
                                        .OfType<DataGridViewRow>()
                                        .Select(row => (Employee)row.DataBoundItem)
                                        .ToList();
            if (!selectedEmployees.Any())
            {
                MessageBox.Show("Please select at least one employee.", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check department match and assign task
            foreach (var employee in selectedEmployees)
            {
                if (selectedTask.Departments.Contains(employee.Department))
                {
                    employee.AssignTask(selectedTask);
                    selectedTask.AssignEmployee(employee);
                    MessageBox.Show($"Employee {employee.FirstName} {employee.LastName} successfully assigned to the task.");
                }
                else
                {
                    MessageBox.Show($"Employee {employee.FirstName} {employee.LastName} is not in the correct department for this task.", "Department Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            RefreshTaskList();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchTitle.Text.ToLower();

            string selectedStatus = cmbSearchStatus.SelectedIndex > -1 ? cmbSearchStatus.SelectedItem.ToString() : "All";
            string selectedDepartment = cmbSearchDepartment.SelectedIndex > -1 ? cmbSearchDepartment.SelectedItem.ToString() : "All";

            var filteredTasks = company.Tasks.Where(task =>
                (string.IsNullOrWhiteSpace(searchTitle) || task.Title.ToLower().Contains(searchTitle)) &&
                (selectedStatus == "All" || task.Status == selectedStatus) &&
                (selectedDepartment == "All" || task.Departments.Contains(selectedDepartment))).ToList();


            lstbTasks.DataSource = null;
            lstbTasks.DataSource = filteredTasks;
            lstbTasks.DisplayMember = "Title";


        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "WorkTasks Data File (*.workTasks)|*.workTasks";
            saveFileDialog.DefaultExt = "WorkTasks";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileHandler.SaveCompanyData(saveFileDialog.FileName, company);
                MessageBox.Show("Data saved successfully.");
            }
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WorkTasks Data File (*.workTasks)|*.workTasks";
            openFileDialog.DefaultExt = "WorkTasks";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var loadedCompany = fileHandler.LoadCompanyData(openFileDialog.FileName);
                if (loadedCompany != null)
                {
                    company = loadedCompany;
                    TaskIDCounter = company.Tasks.Any() ? company.Tasks.Max(task => task.TaskID) + 1 : 1;
                    LoadTasksIntoListBox();
                    MessageBox.Show("Data loaded successfully.");
                }
            }
        }
    }
}
