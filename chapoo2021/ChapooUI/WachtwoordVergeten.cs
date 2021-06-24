using System;
using ChapooModel;
using ChapooLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class WachtwoordVergeten : Form
    {
        public WachtwoordVergeten()
        {
            InitializeComponent();
        }

        private void btn_Ucheck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_User.Text))
            {

                ChapooLogic.Employee_Service service = new Employee_Service();
                Employee employee = new Employee();

                employee.username = txt_User.Text;
                lbl_question.Text = service.forgotpassquestion(employee);

                if (lbl_question.Text == "")
                {
                    MessageBox.Show("Wrong Username");
                }

            }
        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            // check is entered string is valid
            if (!string.IsNullOrWhiteSpace(txt_answer.Text))
            {
                ChapooLogic.Employee_Service service = new Employee_Service();
                Employee employee = new Employee();

                employee.username = txt_User.Text;
                string answer;

                //get answer
                answer = service.forgotpass(employee);

                // check if answer matches
                if (txt_answer.Text.ToLower() == answer.ToLower())
                {
                    // if passwords match
                    if (txt_newpass == txt_repeatpass)
                    {
                        //call hashing function
                        HashwithSalt hash = new HashwithSalt();
                        // create salt and create hash
                        string salt = hash.CreateSalt(64);
                        string hashed = hash.GenerateHash(txt_newpass.Text, salt);
                        //grab and parse username
                        int username = int.Parse(txt_User.Text);

                        // change password
                        service.Alterpass(username, hashed, salt);
                        // show success
                        MessageBox.Show("Je wachtwoord is succesvol veranderd");


                        // open login form again
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Close();

                    }
                }
                else //display fail if answer is wrong
                {
                    MessageBox.Show("Foutief antwoord op de vraag");
                }

            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            // open login form again
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
