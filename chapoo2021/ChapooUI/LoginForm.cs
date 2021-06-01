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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ChapooLogic.Employee_Service service = new ChapooLogic.Employee_Service();

            Employee currentemployee = new Employee();
            currentemployee.employeeId = int.Parse(txt_User.Text);
            string salt = service.GetSalt(currentemployee);

            HashwithSalt retrieve = new HashwithSalt();
            string hash = retrieve.GenerateHash(txt_Pass.Text, salt);

            DataTable dt = new DataTable();

            

        }

        private void lbl_WachtVer_Click(object sender, EventArgs e)
        {

        }
    }
}
