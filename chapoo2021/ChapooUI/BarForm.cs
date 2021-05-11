using ChapooLogic;
using ChapooModel;
using System;
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
    public partial class BarForm : Form
    {
        public BarForm()
        {
            InitializeComponent();
        }

        private void RefreshStockBtn_Click(object sender, EventArgs e)
        {
            voorraad_barmanLv.Items.Clear();

            ChapooLogic.BarLogic barLogic = new ChapooLogic.BarLogic();
            List<BarModel> barList = barLogic.GetBar();


        }
    }
}
