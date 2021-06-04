using System;
using ChapooModel;
using ChapooLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class LoginForm : Form
    {
        private Employee_Service employee_service = new Employee_Service();
        public LoginForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(OnClosed);
        }

        private void CheckCredentials()
        {
            if (string.IsNullOrEmpty(txt_User.Text) || string.IsNullOrEmpty(txt_Pass.Text) || !int.TryParse(txt_User.Text, out int id))
            {
                lbl_Error.Text = "Incorrect Username/Password";
            }

            string password = txt_Pass.Text;
            Employee employee = employee_service.GetCredentials(id, password);
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        private void lbl_WachtVer_Click(object sender, EventArgs e)
        {

        }

        

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        // textbox behavior on entering focus and leaving focus
        
        private void txt_User_Enter(object sender, EventArgs e)
        {
            if (txt_User.Text == "Username")
            {
                txt_User.Text = "";
            }
        }

        private void txt_User_Leave(object sender, EventArgs e)
        {
            if (txt_User.Text.Length == 0)
            {
                txt_User.Text = "Username";
            }
        }

        private void txt_Pass_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "Password")
            {
                txt_Pass.Text = "";
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_Pass_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text.Length == 0)
            {
                txt_Pass.Text = "Password";
                txt_Pass.UseSystemPasswordChar = false;
            }
        }

        // behavior on closing of application
        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
