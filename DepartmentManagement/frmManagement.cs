using DataAccess.DataAccess;
using DataAccess.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DepartmentManagement
{
    public partial class frmManagement : Form
    {
        public bool isAdmin { get; set; }

        BindingSource source;
        public static int m = 0;
        public string currentID { get; set; }
        public frmLogin frm { get; set; }
        public AccountDb loginMember { get; set; }
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        public frmManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDetail frmDetail = new frmDetail
            {
                Text = "Add Employee",
                InsertOrUpdate = false,
            };
            LoadEmployeeList();
            if (frmDetail.ShowDialog() == DialogResult.OK)
            {
                //Set focus order inserted
                source.Position = source.Count - 1;
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetEmployeeObject();
                employeeRepository.DeleteMember(order.EmployeeId);
                LoadEmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a employee");
            }


        }
        private Employee GetEmployeeObject()
        {
            Employee order = null;
            try
            {
                order = new Employee
                {
                    EmployeeId = txtEmployeeID.Text,
                    FullName = txtFullName.Text,
                    JobTitle = txtJobTitle.Text,
                    YearOfBirth = int.Parse(txtYear.Text),
                    DepartmentId = txtDepartmentID.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        public void LoadEmployeeList()
        {
            var members = employeeRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.EmployeeId);
                txtEmployeeID.DataBindings.Clear();
                txtFullName.DataBindings.Clear();
                txtJobTitle.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtDepartmentID.DataBindings.Clear();


                txtEmployeeID.DataBindings.Add("Text", source, "EmployeeId");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                txtJobTitle.DataBindings.Add("Text", source, "JobTitle");
                txtYear.DataBindings.Add("Text", source, "YearOfBirth");
                txtDepartmentID.DataBindings.Add("Text", source, "DepartmentId");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetail frmDetail = new frmDetail
            {
                Text = "Update employee",
                InsertOrUpdate = true,
                EmployeeInfor = GetEmployeeObject(),
                EmployeeRepository = employeeRepository
            };
            if (frmDetail.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeeList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }

            LoadEmployeeList();
        }

    }
}
//------------------------------------------------------
