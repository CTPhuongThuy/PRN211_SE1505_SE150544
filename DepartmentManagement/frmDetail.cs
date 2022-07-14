using DataAccess.DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DepartmentManagement
{
    public partial class frmDetail : Form
    {
        public string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:SE1505_EmployeeDepartment"];
            return strConn;
        }
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        IDepartmentRepository departmentRepository = new DepartmentRepository();
        //  public IOrderDetailRepository OrderDetailRepository { get; set; }
        public Employee EmployeeInfor { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public frmDetail()
        {
            InitializeComponent();
        }
        private void frmDetail_Load(object sender, EventArgs e)
        {
            string cs = GetConnectionString();
            SE1505_EmployeeDepartmentContext db = new SE1505_EmployeeDepartmentContext(cs);
            txtEmployeeID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtEmployeeID.Text = EmployeeInfor.EmployeeId.ToString();
                txtFullName.Text = EmployeeInfor.FullName;
                txtJobTitle.Text = EmployeeInfor.JobTitle;
                txtYear.Text = EmployeeInfor.YearOfBirth.ToString();
                txtDepartmentID.Text = departmentRepository.GetTourByID(EmployeeInfor.DepartmentId).DepartmentName.ToString();
            }
            var member = from m in db.Departments
                         select m.DepartmentName.ToString();
            foreach (var x in member)
            {
                txtDepartmentID.Items.Add(x);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string cs = GetConnectionString();
            try
            {
                //SE1505_EmployeeDepartmentContext db = new SE1505_EmployeeDepartmentContext(cs);
                //var mem = db.Departments.SingleOrDefault(pro => pro.DepartmentName.Equals(txtDepartmentID.SelectedItem.ToString()));
                //string id = mem.DepartmentId;

                var emp = new Employee
                {
                    EmployeeId = txtEmployeeID.Text,
                    FullName = txtFullName.Text,
                    JobTitle = txtJobTitle.Text,
                    YearOfBirth = int.Parse(txtYear.Text),
                    DepartmentId = txtDepartmentID.SelectedItem.ToString()
                };
                ValidationContext context = new ValidationContext(emp, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(emp, context, errors, true))
                {
                    foreach (ValidationResult result1 in errors)
                    {
                        MessageBox.Show(result1.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (InsertOrUpdate == false)
                    {
                        employeeRepository.InsertMember(emp);
                        MessageBox.Show("Added emp successfully", "Adding emp");
                    }
                    else
                    {
                        employeeRepository.UpdateMember(emp);
                        MessageBox.Show("Updated emp successfully", "Updating emp");
                    }
                }
                //if (emp != null)
                //{
                //    employeeRepository.InsertMember(emp);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new order detail");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();


    }
}
