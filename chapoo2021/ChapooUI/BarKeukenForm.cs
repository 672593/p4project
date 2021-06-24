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
using System.Timers;


namespace ChapooUI
{
    public partial class BarKeukenForm : Form
    {

        private static System.Timers.Timer aTimer = new System.Timers.Timer(10000);
        public Boolean checkKeukenBar;
        public Boolean checkOpenstaand = true;

        public BarKeukenForm(Boolean checkKeukenBar)
        {

            this.checkKeukenBar = checkKeukenBar;

            InitializeComponent();

            if (checkKeukenBar == true)
            {
                Chapoo_title.Text = "| Keuken";
            }
            else
            {
                Chapoo_title.Text = "| Barman";
            }


            RefreshOrders();
            ts_menuItem_Filter.Text = "Openstaand";
            System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Interval = 10000;
            aTimer.Enabled = true;

        }
        private void OnTimedEvent(object source, EventArgs e)
        {
            RefreshOrders();
        }

        private void RefreshStockBtn_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }


        private void RefreshOrders()
        {
            ChapooLogic.KeukenBarBestelling_Service KeukenBarBestelLogic = new ChapooLogic.KeukenBarBestelling_Service();
            List<KeukenBarBestelling> KeukenBarBestelList = KeukenBarBestelLogic.GetKeuken(checkKeukenBar, checkOpenstaand);

            bestelling_gereedLv.Items.Clear();

            foreach (ChapooModel.KeukenBarBestelling k in KeukenBarBestelList)
            {
                ListViewItem item = new ListViewItem(k.OrderItemID.ToString());
                item.SubItems.Add(k.orderTableId.ToString());
                item.SubItems.Add(k.Name);
                item.SubItems.Add(k.Amount.ToString());
                item.SubItems.Add(k.Datum.ToString());
                tb_opmerking_keukenBar.Text = "Comment in bestelling " + k.orderTableId.ToString() + " : '" + k.Comment.ToString() + "'\n";
                bestelling_gereedLv.Items.Add(item);
            }
        }

        private void EditOrderKeukenBar()
        {
            if (bestelling_gereedLv.SelectedItems.Count > 0)
            {
                pnl_Bestelling_Wijzig.Show();
                tb_pnl_ID_bestelling.Text = bestelling_gereedLv.SelectedItems[0].SubItems[0].Text;
                tb_pnl_Tafel_bestelling.Text = bestelling_gereedLv.SelectedItems[0].SubItems[1].Text;
                tb_pnl_Name_bestelling.Text = bestelling_gereedLv.SelectedItems[0].SubItems[2].Text;
                tb_pnl_Aantal_bestelling.Text = bestelling_gereedLv.SelectedItems[0].SubItems[3].Text;
                tb_pnl_Tijd_bestelling.Text = bestelling_gereedLv.SelectedItems[0].SubItems[4].Text;
            }
            else
            {
                MessageBox.Show("Please select an Order first.");
                RefreshOrders();
            }
        }

        private void btn_Gereed_Bestelling_Bar_Click(object sender, EventArgs e)
        {
            EditOrderKeukenBar();
        }

        private void btn_Bar_Wijzig_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Bestelling_Wijzig.Hide();
        }

        private void btn_Bar_Wijzig_Accept_Click(object sender, EventArgs e)
        {
            pnl_Bestelling_Wijzig.Hide();

            try
            {
                KeukenBarBestelling_Service keukenService = new KeukenBarBestelling_Service();
                int id = int.Parse(tb_pnl_ID_bestelling.Text);
                Boolean status = Convert.ToBoolean(1);

                KeukenBarBestelling keukenBar = new KeukenBarBestelling();
                keukenBar.OrderItemID = id;
                keukenBar.OrderItemStatus = status;

                keukenService.WijzigBestelling(keukenBar);
                MessageBox.Show("Bestelling Gereed!");
                RefreshOrders();
            }
            catch
            {
                MessageBox.Show("Failed, Probeer Opnieuw.");
                RefreshOrders();
            }
        }

        private void LogOffLink_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Weet u zeker dat u wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                this.Close();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void gereedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkOpenstaand = false;
            ts_menuItem_Filter.Text = "Gereed";
            pnl_Bestelling_Wijzig.Hide();
            btn_Gereed_Bestelling_Bestelling.Hide();
            RefreshOrders();
        }

        private void openstaandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkOpenstaand = true;
            ts_menuItem_Filter.Text = "Openstaand";
            btn_Gereed_Bestelling_Bestelling.Show();
            RefreshOrders();
        }
    }
}
