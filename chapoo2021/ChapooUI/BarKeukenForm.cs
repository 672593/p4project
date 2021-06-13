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
    public partial class BarKeukenForm : Form
    {

        //Hier moet code staan voor het controller op login//
        //Boolean checkKeuken = false;//
        public BarKeukenForm(Boolean checkKeuken)
        {

            InitializeComponent();
            if (checkKeuken == true)
            {
                RefreshItemsKeuken();
                RefreshOrdersKeuken();
                barbestelling_gereedLv.Hide();
                voorraad_barmanLv.Hide();
                RefreshOrdersBtn.Hide();
                btn_Gereed_Bestelling_Bar.Hide();
                Chapoo_title.Text = "Chapoo | Keuken";
            }
            else
            {
                RefreshItemsBar();
                RefreshOrdersBar();
                keukenbestelling_gereedLv.Hide();
                voorraad_keukenLv.Hide();
                RefreshStockBtn.Hide();
                btn_Gereed_Bestelling_Keuken.Hide();
                Chapoo_title.Text = "Chapoo | Barman";
            }
        }

        private void RefreshStockBtn_Click(object sender, EventArgs e)
        {
            RefreshItemsKeuken();
            RefreshOrdersKeuken();
        }

        public void RefreshOrdersBtn_Click(object sender, EventArgs e)
        {
            RefreshItemsBar();
            RefreshOrdersBar();
        }

        private void RefreshItemsBar()
        {
            ChapooLogic.BarLogic barLogic = new ChapooLogic.BarLogic();
            List<BarModel> barList = barLogic.GetBar();

            voorraad_barmanLv.Items.Clear();

            foreach (ChapooModel.BarModel b in barList)
            {
                ListViewItem item = new ListViewItem(b.ItemID.ToString());
                item.SubItems.Add(b.Type.ToString());
                item.SubItems.Add(b.Price.ToString("F"));
                item.SubItems.Add(b.Stock.ToString());
                item.SubItems.Add(b.Alcohol.ToString());
                item.SubItems.Add(b.Name);

                voorraad_barmanLv.Items.Add(item);
            }
        }

        private void RefreshItemsKeuken()
        {
            ChapooLogic.KeukenLogic barLogic = new ChapooLogic.KeukenLogic();
            List<KeukenModel> barList = barLogic.GetKeuken();

            voorraad_keukenLv.Items.Clear();

            foreach (ChapooModel.KeukenModel b in barList)
            {
                ListViewItem item = new ListViewItem(b.ItemID.ToString());
                item.SubItems.Add(b.Type.ToString());
                item.SubItems.Add(b.Price.ToString("F"));
                item.SubItems.Add(b.Stock.ToString());
                //item.SubItems.Add(b.Alcohol.ToString());
                item.SubItems.Add(b.Name);

                voorraad_keukenLv.Items.Add(item);
            }
        }

        private void RefreshOrdersBar()
        {
            ChapooLogic.BarBestellingLogic bbarLogic = new ChapooLogic.BarBestellingLogic();
            List<BarBestellingModel> bbarList = bbarLogic.GetBar();

            barbestelling_gereedLv.Items.Clear();

            foreach (ChapooModel.BarBestellingModel b in bbarList)
            {
                ListViewItem item = new ListViewItem(b.OrderItemID.ToString());
                item.SubItems.Add(b.Amount.ToString());
                item.SubItems.Add(b.Price.ToString("F"));
                item.SubItems.Add(b.orderTableId.ToString());
                item.SubItems.Add(b.Name);
                item.SubItems.Add(b.OrderItemStatus.ToString());
                item.SubItems.Add(b.Alcohol.ToString());

                barbestelling_gereedLv.Items.Add(item);
            }
        }

        private void RefreshOrdersKeuken()
        {
            ChapooLogic.KeukenBestellingLogic KeukenBestelLogic = new ChapooLogic.KeukenBestellingLogic();
            List<KeukenBestellingModel> KeukenBestelList = KeukenBestelLogic.GetKeuken();

            keukenbestelling_gereedLv.Items.Clear();

            foreach (ChapooModel.KeukenBestellingModel k in KeukenBestelList)
            {
                ListViewItem item = new ListViewItem(k.OrderItemID.ToString());
                item.SubItems.Add(k.Amount.ToString());
                item.SubItems.Add(k.Price.ToString("F"));
                item.SubItems.Add(k.orderTableId.ToString());
                item.SubItems.Add(k.Name);
                item.SubItems.Add(k.OrderItemStatus.ToString());

                keukenbestelling_gereedLv.Items.Add(item);
            }
        }

        private void EditOrderKeuken()
        {
            if (keukenbestelling_gereedLv.SelectedItems.Count > 0 && keukenbestelling_gereedLv.SelectedItems.Count != null)
            {
                pnl_Keuken_Bestelling_Wijzig.Show();
                tb_pnl_ID_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[0].Text;
                tb_pnl_Amount_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[1].Text;
                tb_pnl_Prijs_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[2].Text;
                tb_pnl_Tafel_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[3].Text;
                tb_pnl_Name_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[4].Text;
                tb_pnl_Status_keuken.Text = keukenbestelling_gereedLv.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                MessageBox.Show("Please select an Order first.");
                    RefreshItemsKeuken();
                    RefreshOrdersKeuken();
            }
        }
        private void EditOrderBar()
        {
            if (barbestelling_gereedLv.SelectedItems.Count > 0 && barbestelling_gereedLv.SelectedItems.Count != null)
            {
                pnl_Bar_Bestelling_Wijzig.Show();
                tb_pnl_ID_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[0].Text;
                tb_pnl_Amount_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[1].Text;
                tb_pnl_Prijs_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[2].Text;
                tb_pnl_Tafel_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[3].Text;
                tb_pnl_Name_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[4].Text;
                tb_pnl_Status_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[5].Text;
                tb_pnl_Alcohol_bar.Text = barbestelling_gereedLv.SelectedItems[0].SubItems[6].Text;
            }
            else
            {
                MessageBox.Show("Please select an Order first.");
                    RefreshItemsBar();
                    RefreshOrdersBar();
            }
        }

        private void btn_Gereed_Bestelling_Keuken_Click(object sender, EventArgs e)
        {
            EditOrderKeuken();
        }

        private void btn_Keuken_Wijzig_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Keuken_Bestelling_Wijzig.Hide();
        }

        private void btn_Keuken_Wijzig_Accept_Click(object sender, EventArgs e)
        {
            pnl_Keuken_Bestelling_Wijzig.Hide();

            try
            {
                KeukenBestellingLogic keukenService = new KeukenBestellingLogic();
                int id = int.Parse(tb_pnl_ID_keuken.Text);
                Boolean status = Convert.ToBoolean(1); 

                KeukenBestellingModel keuken = new KeukenBestellingModel();
                keuken.OrderItemID = id;
                keuken.OrderItemStatus = status;

                keukenService.WijzigBestellingKeuken(keuken);
                MessageBox.Show("Succes!");

                RefreshItemsKeuken();
                RefreshOrdersKeuken();
            }
            catch
            {
                MessageBox.Show("Failed.");
                RefreshItemsKeuken();
                RefreshOrdersKeuken();
            }
        }

        private void btn_Gereed_Bestelling_Bar_Click(object sender, EventArgs e)
        {
            EditOrderBar();
        }

        private void btn_Bar_Wijzig_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Bar_Bestelling_Wijzig.Hide();
        }

        private void btn_Bar_Wijzig_Accept_Click(object sender, EventArgs e)
        {
            pnl_Bar_Bestelling_Wijzig.Hide();

            try
            {
                BarBestellingLogic barService = new BarBestellingLogic();
                int id = int.Parse(tb_pnl_ID_bar.Text);
                Boolean status = Convert.ToBoolean(1);

                BarBestellingModel bar = new BarBestellingModel();
                bar.OrderItemID = id;
                bar.OrderItemStatus = status;

                barService.WijzigBestellingBar(bar);
                MessageBox.Show("Succes!");

                RefreshItemsBar();
                RefreshOrdersBar();
            }
            catch
            {
                MessageBox.Show("Failed.");
                RefreshItemsBar();
                RefreshOrdersBar();
            }
        }
    }
}
