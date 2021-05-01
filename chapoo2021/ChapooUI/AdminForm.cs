using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class AdminForm : Form
    {
        TestLogic logic = new TestLogic();
        public AdminForm()
        {
            InitializeComponent();
            GetNames();
        }
        public void GetNames()
        {
            List<TestModel> list = logic.GetAllTest();

            foreach (TestModel item in list)
            {
                lblNames.Text += $"{item.Id}. - {item.Name}\n";
            }
        }
    }
}