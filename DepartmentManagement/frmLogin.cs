
using DataAccess.Repository;
using System;
using System.Windows.Forms;
namespace DepartmentManagement
{
    public partial class frmLogin : Form
    {
        //IAccountRepository accountRepository = new AccountRepository();
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        BindingSource source;
        public static int m = 0;
        private AccountRepository accountRepository = new AccountRepository();
        public static bool canLog = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            bool isMem = false;
            var user = accountRepository.GetUsers();
            foreach (var i in user)
            {
                if (i.UserId.Equals(txtUserName.Text) && i.AccountPassword.Equals(txtPassword.Text) && i.AccountRole == 2)
                {
                    canLog = true;

                    frmManagement frm = new frmManagement();
                    this.Hide();
                    isMem = true;

                    frm.Show();

                }
            }


            if (isMem == false)
            {
                var mss = MessageBox.Show("You are not allowed to access this function!", "Wrong user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mss == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.None;
                    this.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Application.Exit();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}