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
            ChapooLogic.KeukenLogic barLogic = new ChapooLogic.KeukenLogic();
            List<KeukenModel> barList = barLogic.GetKeuken();

            voorraad_barmanLv.Items.Clear();

            foreach (ChapooModel.KeukenModel b in barList)
            {
                ListViewItem item = new ListViewItem(b.ItemID.ToString());
                item.SubItems.Add(b.Type.ToString());
                item.SubItems.Add(b.Price.ToString("F"));
                item.SubItems.Add(b.Stock.ToString());
                //item.SubItems.Add(b.Alcohol.ToString());
                item.SubItems.Add(b.Name);

                voorraad_barmanLv.Items.Add(item);
            }
        }

        private void RefreshStockBtn_Click(object sender, EventArgs e)
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

        private void RefreshOrdersBtn_Click(object sender, EventArgs e)
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
    }
}
