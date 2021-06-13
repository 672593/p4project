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
            int number = 0;

            InitializeComponent();
            if (number == 0)
            {
                RefreshItemsKeuken();
                RefreshOrdersKeuken();
            }
            else
            {
                RefreshItemsBar();
                RefreshOrdersBar();
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
                item.SubItems.Add(b.Name);
                item.SubItems.Add(b.Alcohol.ToString());

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

            bestelling_gereedLv.Items.Clear();

            foreach (ChapooModel.BarBestellingModel b in bbarList)
            {
                ListViewItem item = new ListViewItem(b.OrderItemID.ToString());
                item.SubItems.Add(b.Amount.ToString());
                item.SubItems.Add(b.Price.ToString("F"));
                item.SubItems.Add(b.orderTableId.ToString());
                item.SubItems.Add(b.Name);
                item.SubItems.Add(b.OrderItemStatus.ToString());

                bestelling_gereedLv.Items.Add(item);
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
            { MessageBox.Show("Please select a row. Click on an ID."); }
        }

        private void btn_Gereed_Bestelling_Keuken_Click(object sender, EventArgs e)
        {
            EditOrderKeuken();
        }

        private void btn_Keuken_Wijzig_Cancel_Click(object sender, EventArgs e)
        {
            pnl_Keuken_Bestelling_Wijzig.Hide();
        }
    }
}
