using ChapooModel;
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
    public partial class BedieningForm : Form
    {
        private List<Tafels> tafels;
        private Tafels_Service tafelService;
        private List<Label> labels;
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
            // HidePanelsRecursively(this);
            
            // all status labels added to a list Made by Jelle de Vries
            labels = new List<Label>();
            labels.Add(lbl_tf_1);
            labels.Add(lbl_tf_2);
            labels.Add(lbl_tf_3);
            labels.Add(lbl_tf_4);
            labels.Add(lbl_tf_5);
            labels.Add(lbl_tf_6);
            labels.Add(lbl_tf_7);
            labels.Add(lbl_tf_8);
            labels.Add(lbl_tf_9);
            labels.Add(lbl_tf_10);

            TafelStatus();

        }

        private void TafelStatus()
        {
            // start get the tafel status
            tafels = tafelService.GetTafelData();

            // checking and assigning values according to status id
            for (int i = 0; i < tafels.Count; i++)
            {
                if (tafels[i].TafelStatusId == 1)
                {
                    labels[i].ForeColor = Color.LawnGreen;
                    labels[i].Text = "Vrij";
                }
                else if (tafels[i].TafelStatusId == 2)
                {
                    labels[i].ForeColor = Color.Red;
                    labels[i].Text = "Bezet";
                }
                else
                {
                    labels[i].ForeColor = Color.Gold;
                    labels[i].Text = "Gereserveerd";
                }
            }
        }


        /*        private void OrderBtn_Click(object sender, EventArgs e)             // Made by Faruk Bikmaz
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
                }*/
        // ORDER PANEL

        // OVERZCIH VAN ORDERS

        private void AllOrdersBtn_Click(object sender, EventArgs e)
        {
            Order_pnl.Show(); AllOrders_pnl.Show();

            ChapooLogic.BestellingItem_Service BI_Service = new ChapooLogic.BestellingItem_Service();
            List<BestellingItem> BestellingItemList = BI_Service.GetBestellingItems();

            // clear the listview before filling it again
            AllOrderslv.Items.Clear();

            foreach (ChapooModel.BestellingItem bi in BestellingItemList)
            {
                string[] BestellingItemArray = new string[] {
                        bi.orderItemId.ToString(),
                        bi.orderId.ToString(),
                      //   bi.orderItemStatus.ToString(),
                        bi.menuItemId.ToString(),
                        bi.orderTime.ToString(),
                        bi.amount.ToString(),
                        bi.price.ToString()
                    };

                ListViewItem item = new ListViewItem(BestellingItemArray);

                AllOrderslv.Items.Add(item);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrder_pnl.Show();
        }

        private void AllOrdersBtn2_Click(object sender, EventArgs e)
        {
            AllOrders_pnl.Show(); AddOrder_pnl.Hide();
        }

        private void TableDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChapooLogic.Tablle_Service t_service = new ChapooLogic.Tablle_Service();
            List<Table> TableList = t_service.GetTable();

            foreach (ChapooModel.Table t in TableList)
            {
                t.tableId.ToString();
                TableDropdown.Items.Add(t);
            }

        }

        private void LogOffLink_Click(object sender, EventArgs e) // Made by Jelle de Vries
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
    }
}
