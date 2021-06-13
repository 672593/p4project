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
    public partial class BedieningForm : Form
    {
        public void HidePanelsRecursively(Control container)             // Made by Faruk Bikmaz
        {
            if (container is Panel)
                container.Visible = false;

            foreach (Control ctrl in container.Controls)
                HidePanelsRecursively(ctrl);
        }

        public BedieningForm()
        {
            InitializeComponent();
            HidePanelsRecursively(this);
            Table_pnl.Show();
        }

        private void OrderBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            // Made by Faruk Bikmaz
            HidePanelsRecursively(this);
            bestelling_pnl.Show();

            ChapooLogic.Tafels_Service tafel_service = new ChapooLogic.Tafels_Service();
            List<Tafels> tafelList = tafel_service.GetAllFreeTables();

            // clear the listview before filling it again
            tafels_lv.Items.Clear();

            foreach (ChapooModel.Tafels t in tafelList)
            {
                string[] tafelArray = new string[] {
                        t.tableId.ToString()
                    };

                ListViewItem item = new ListViewItem(tafelArray);

                tafels_lv.Items.Add(item);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            HidePanelsRecursively(this);
            Table_pnl.Show();
        }

        private void continueBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            if (tafels_lv.SelectedItems.Count > 0)
            {
                HidePanelsRecursively(this);
                bestelling2_pnl.Show();
            } else
            {
                MessageBox.Show("Selecteer een tafel");
            }
        }

        private void close2Btn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            HidePanelsRecursively(this);
            Table_pnl.Show();
        }

        private void lunchBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            menu_lv.Show();
            menu_lv.Items.Clear();
            ChapooLogic.Menu_Service menu_service = new ChapooLogic.Menu_Service();
            List<Lunch> lunchList = menu_service.GetLunch();

            foreach (ChapooModel.Lunch l in lunchList)
            {
                string[] menuArray = new string[] {
                        l.itemName,
                        l.price.ToString("F")
            };

            ListViewItem item = new ListViewItem(menuArray);
            menu_lv.Items.Add(item);
            }
        }

        private void dinerBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
        {
            menu_lv.Show();
            menu_lv.Items.Clear();

            ChapooLogic.Menu_Service menu_service = new ChapooLogic.Menu_Service();
            List<Diner> dinerList = menu_service.GetDiner();

            foreach (ChapooModel.Diner d in dinerList)
            {
                string[] menuArray = new string[] {
                        d.itemName,
                        d.price.ToString("F")
            };

            ListViewItem item = new ListViewItem(menuArray);
            menu_lv.Items.Add(item);
            }
        }

        private void drankBtn_Click(object sender, EventArgs e)              // Made by Faruk Bikmaz
        {
            menu_lv.Show();
            menu_lv.Items.Clear();

            ChapooLogic.Menu_Service menu_service = new ChapooLogic.Menu_Service();
            List<Drankjes> drankList = menu_service.GetDrankjes();

            foreach (ChapooModel.Drankjes dra in drankList)
            {
                string[] menuArray = new string[] {
                        dra.itemName,
                        dra.price.ToString("F"),
                        dra.alcohol.ToString()     
            };
            
            ListViewItem item = new ListViewItem(menuArray);
            menu_lv.Items.Add(item);
            }
        }

        private void amount_TextChanged(object sender, EventArgs e)              // Made by Faruk Bikmaz
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(amount.Text, "[^0-9]"))
            {
                MessageBox.Show("Alleen cijfers mogelijk");
                amount.Text = amount.Text.Remove(amount.Text.Length - 1);
            }
        }
        // TAFELS
        private void Tafel1Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel2Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel3Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel4Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel5Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel6Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel7Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel8Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel9Btn_Click(object sender, EventArgs e)
        {

        }

        private void Tafel10Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
