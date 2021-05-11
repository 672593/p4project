using System;
using ChapooDAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;



namespace ChapooUI
{
    public partial class LoginForm : Form
    {
        Employee_Service employeeService = new Employee_Service();
        Employee employee = new Employee();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                employee = employeeService.GetWorkerLogin(txtUser.Text, txtPass.Text);

                if (employee.FunctionId == null)
                {
                    lblerror.Text = "Incorrect Username and/or Password has been entered.";
                }
                else
                {
                    OpenForm();
                }



            }
            else
            {
                lblerror.Text = "No Username or Password has been entered.";
            }


        }

        private void OpenForm()
        {
            this.Hide();
            switch(employee.FunctionId)
            {
                case 
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
