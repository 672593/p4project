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
using ChapooLogic;

namespace ChapooUI
{
    public partial class BedieningForm : Form
    {
        const decimal Vat = 0.21m;
        // faruk
        Table_Service t_service = new Table_Service();
        Menu_Service m_service = new Menu_Service();
        BestellingItem_Service be_service = new BestellingItem_Service();
        Bestelling_Service besteling_service = new Bestelling_Service();
        Reservering_Service res_service = new Reservering_Service();
        public void HidePanelsRecursively(Control container)
        {
            if (container is Panel)
                container.Visible = false;

            foreach (Control ctrl in container.Controls)
                HidePanelsRecursively(ctrl);
        }

        public BedieningForm()
        {
            InitializeComponent();
            pnl_Afrekenen.Hide();
            // HidePanelsRecursively(this);
        }

        private void AllOrdersBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);
            Order_pnl.Show(); AllOrders_pnl.Show(); Table10_pnl.Show(); Table9_pnl.Show(); Table8_pnl.Show(); Table7_pnl.Show();
            Table6_pnl.Show(); Table5_pnl.Show(); Table4_pnl.Show(); Table3_pnl.Show(); Table2_pnl.Show(); Table1_pnl.Show();
            AllOrderslv.Items.Clear();
            FillOrderItemList(); FillResList();
        }
        private void FillOrderItemList()
        {
            AllOrders_pnl.Show();
            AllOrderslv.Items.Clear();
            orderslv.Items.Clear();
            foreach (BestellingItem be in be_service.GetBestellingItems())
            {
                string[] BestellingArray = new string[] {
                        be.orderId.ToString(),
                        be.orderItemId.ToString(),
                        be.itemName,
                        be.amount.ToString()
                      };
                string[] BestellingArray2 = new string[] {
                        be.itemName,
                        be.amount.ToString()
                      };

                ListViewItem item = new ListViewItem(BestellingArray);
                ListViewItem item2 = new ListViewItem(BestellingArray2);
                AllOrderslv.Items.Add(item);
                orderslv.Items.Add(item2);
            }
        }

        private void FillResList()
        {
            Reservationlv.Items.Clear();
            foreach (Reservering re in res_service.GetAllRes())
            {
                string[] ReserveringArray = new string[] {
                        re.reservationId.ToString(),
                        re.tableId.ToString(),
                        re.reservationName,
                        re.reservationTel.ToString(),
                        re.reservationEmail,
                        re.reservationComment,
                        re.reservationDate.ToString()
                      };

                ListViewItem item = new ListViewItem(ReserveringArray);
                Reservationlv.Items.Add(item);
            }
        }
        private void DeleteOrderItemBtn_Click(object sender, EventArgs e)
        {
            int selectOrderItemId;
            int selectmenuItemId;
            if (AllOrderslv.SelectedItems.Count > 0)
            {
                selectOrderItemId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);
                selectmenuItemId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[1].Text);

                if (be_service.DeleteOrderItem(selectmenuItemId, selectOrderItemId) == true)
                {
                    MessageBox.Show($"Gerecht verwijderd");
                    FillOrderItemList();
                }
            }
            else { MessageBox.Show("U heeft geen gerecht geselecteerd"); }
        }
        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            int selectOrderId;
            if (AllOrderslv.SelectedItems.Count > 0)
            {
                selectOrderId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);

                if (be_service.DeleteOrder(selectOrderId) == true)
                {
                    MessageBox.Show($"Bestelling verwijderd");
                    FillOrderItemList();
                }
            }
            else { MessageBox.Show("U heeft geen bestelling geselecteerd"); }
        }

        private void ChangeAcceptBtn_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(AllOrderslv.SelectedItems[0].SubItems[3].Text);
            int orderItemId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[1].Text);
            if (!string.IsNullOrEmpty(AmountBox.Text))
            {
                amount = int.Parse(AmountBox.Text);
            }
            else
            {
                throw new Exception("Er is iets fout gegaan!");
            }
            BestellingItem be = new BestellingItem();
            be.amount = int.Parse(AllOrderslv.SelectedItems[0].SubItems[3].Text);
            be.orderItemId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[1].Text);

            if (be_service.UpdateAmountOrderItem(orderItemId, amount) == true)
            {
                MessageBox.Show($"Aantal is gewijzigd naar {amount}");
                FillOrderItemList();
                ChangeAmount_pnl.Hide();
            }
            else { MessageBox.Show("Er is iets fout gegaan"); }
        }
        private void Add()
        {
            HidePanelsRecursively(this);
            AddOrder_pnl.Show();
            Order_pnl.Show();

            TafelDD.Items.Clear();
            foreach (Table t in t_service.GetTables())
            {
                TafelDD.Items.Add(t.tableId);
            }

            MenuDD.Items.Clear();
            foreach (Menuu m in m_service.GetMenuNames())
            {
                MenuDD.Items.Add(m.menuName);
            }

            FillMenuItem(1);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void AllOrdersBtn2_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);
            AllOrders_pnl.Show();
            Order_pnl.Show();
        }

        private void BackToTablesBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this); Table10_pnl.Show(); Table9_pnl.Show(); Table8_pnl.Show(); Table7_pnl.Show();
            Table6_pnl.Show(); Table5_pnl.Show(); Table4_pnl.Show(); Table3_pnl.Show(); Table2_pnl.Show(); Table1_pnl.Show();
        }


        private void minBtn_Click(object sender, EventArgs e)
        {
            int amount = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text);
            amount--;
            if (amount < 0)
            {
                amount = 0;
            }
            amountOrderItem.Text = amount.ToString();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            int amount2 = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text);
            amount2++;
            amountOrderItem.Text = amount2.ToString();
        }
        private void OrderAddBtn_Click(object sender, EventArgs e)
        {
            Bestelling bestelling = new Bestelling
            {
                orderId = besteling_service.GetLastOrderId(),
                orderTableId = TafelDD.SelectedIndex + 1,
                employeeId = 1, // code van jelle moet nog komen
                currentDate = DateTime.Now,
                totalPrice = 2,
                comment = opmerkingBox.Text
            };
            /*  BestellingItem bestellingItem = new BestellingItem
              {
                  orderItemId = be_service.GetLastOrderItemId(),
                  orderId = besteling_service.GetLastOrderId(),
                  menuItemId = 1,
                  orderTime = DateTime.Now,
                  amount = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text),
                  price = 1,
                  orderItemStatus = false
              };*/
            if (besteling_service.InsertBestelling(bestelling)/* && be_service.InsertBestelling(bestellingItem)*/ == true)
            {
                MessageBox.Show("Bestelling toegevoegd");
            }
            else
            {
                MessageBox.Show("Er is iets fout gegaan!");
            }
        }

        private void MenuDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menuId = MenuDD.SelectedIndex + 1;
            FillMenuItem(menuId);

        }

        private void ConsumptieDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menuId = MenuDD.SelectedIndex + 1;
            int menuItemId = ConsumptieDD.SelectedIndex + 1;
            FillMenuItem(menuId);
            consumptieLabel.Text = menuItemId.ToString();

            //  text = int.Parse(m_service.GetSelectedMenuItemId(menuId, menuItemId));

        }
        private void FillMenuItem(int menuId)
        {
            ConsumptieDD.Items.Clear();
            foreach (MenuuItem m in m_service.GetSelitemName(menuId))
            {
                ConsumptieDD.Items.Add(m.itemName);
            }
        }

        private void plusAantalBtn_Click_1(object sender, EventArgs e)
        {
            int amount = int.Parse(AmountBox.Text);
            amount++;
            AmountBox.Text = amount.ToString();
        }
        private void minAantalBtn_Click_1(object sender, EventArgs e)
        {
            int amount2 = int.Parse(AmountBox.Text);
            amount2--;
            if (amount2 < 0)
            {
                amount2 = 0;
            }
            AmountBox.Text = amount2.ToString();
        }
        private void AllResBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);

            Res_pnl.Show(); Order_pnl.Show();
            FillResList();

            Table10_pnl.Show(); Table9_pnl.Show(); Table8_pnl.Show(); Table7_pnl.Show();
            Table6_pnl.Show(); Table5_pnl.Show(); Table4_pnl.Show(); Table3_pnl.Show(); Table2_pnl.Show(); Table1_pnl.Show();
        }

        private void AllreservationsBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);

            Res_pnl.Show(); Order_pnl.Show(); AddRes_pnl.Show();
            FillResList();
        }

        private void DeleteResBtn_Click(object sender, EventArgs e)
        {
            int reservationId;
            if (Reservationlv.SelectedItems.Count > 0)
            {
                reservationId = int.Parse(Reservationlv.SelectedItems[0].SubItems[0].Text);

                if (res_service.DeleteReservation(reservationId) == true)
                {
                    MessageBox.Show($"Reservering verwijderd");
                    FillResList();
                }
            }
            else { MessageBox.Show("U heeft geen reservering geselecteerd"); }
        }

        private void ChangeResBtn_Click(object sender, EventArgs e)
        {
            if (Reservationlv.SelectedItems.Count <= 0 || Reservationlv.SelectedItems.Count == null)
            {
                MessageBox.Show("U heeft geen reservering geselecteerd");
            }
            else
            {
                ChangeRes_pnl.Show();
                TafelResDD.Text = (Reservationlv.SelectedItems[0].SubItems[1].Text);
                aamBox.Text = Reservationlv.SelectedItems[0].SubItems[2].Text;
                telBox.Text = Reservationlv.SelectedItems[0].SubItems[3].Text;
                emailBox.Text = Reservationlv.SelectedItems[0].SubItems[4].Text;
                opmerkingBox.Text = Reservationlv.SelectedItems[0].SubItems[5].Text;
                datumBox.Text = Reservationlv.SelectedItems[0].SubItems[6].Text;
            }
            
        }
        private void AddRes()
        {
            HidePanelsRecursively(this);

            Order_pnl.Show(); AddRes_pnl.Show();
            FillResList();
            AddTafelDD.Items.Clear();
            foreach (Table t in t_service.GetTables())
            {
                AddTafelDD.Items.Add(t.tableId);
            }
        }
        private void AddResBtn_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            ChangeRes_pnl.Hide(); Res_pnl.Show();
        }

        private void BevestigResBtn_Click(object sender, EventArgs e)
        {
            AddTafelDD.Items.Clear();
            foreach (Table t in t_service.GetTables())
            {
                AddTafelDD.Items.Add(t.tableId);
            }
            Reservering reservering = new Reservering
            {
                reservationId = res_service.GetLastReserveringId(),
                tableId = AddTafelDD.SelectedIndex + 1,
                reservationName = AddNaamDD.Text,
                reservationTel = Addtel.Text,
                reservationEmail = AddEmail.Text,
                reservationComment = AddOpmerking.Text,
                reservationDate = DateTime.Parse(AddDatum.Text)
            };

            if (res_service.InsertReservering(reservering) == true)
            {
                MessageBox.Show("Reservering toegevoegd");
            }
            else
            {
                MessageBox.Show("Er is iets fout gegaan!");
            }
        }
        private void ChangeResAcceptBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);

            Res_pnl.Show(); Order_pnl.Show();

            int reservationId = int.Parse(Reservationlv.SelectedItems[0].SubItems[0].Text);
            int tableId = int.Parse(Reservationlv.SelectedItems[0].SubItems[1].Text);
            string reservationName = Reservationlv.SelectedItems[0].SubItems[2].Text;
            string reservationTel = Reservationlv.SelectedItems[0].SubItems[3].Text;
            string reservationEmail = Reservationlv.SelectedItems[0].SubItems[4].Text;
            string reservationComment = Reservationlv.SelectedItems[0].SubItems[5].Text;
            DateTime reservationDate = DateTime.Parse(Reservationlv.SelectedItems[0].SubItems[6].Text);

            if (!string.IsNullOrEmpty(reservationName))
            {
                tableId = tableId;
                reservationTel = telBox.Text;
                reservationName = aamBox.Text;
                reservationEmail = emailBox.Text;
                reservationComment = opmerkingBox.Text;
                reservationDate = DateTime.Parse(datumBox.Text);
            }
            else
            {
                throw new Exception("Er is iets fout gegaan!");
            }
            Reservering re = new Reservering();
            re.reservationId = int.Parse(Reservationlv.SelectedItems[0].SubItems[0].Text);
            re.tableId = int.Parse(Reservationlv.SelectedItems[0].SubItems[1].Text);
            re.reservationName = Reservationlv.SelectedItems[0].SubItems[2].Text;
            re.reservationTel = Reservationlv.SelectedItems[0].SubItems[3].Text;
            re.reservationEmail = Reservationlv.SelectedItems[0].SubItems[4].Text;
            re.reservationComment = Reservationlv.SelectedItems[0].SubItems[5].Text;
            re.reservationDate = DateTime.Parse(Reservationlv.SelectedItems[0].SubItems[6].Text);

            if (res_service.EditReservering(reservationId, tableId, reservationName, reservationTel, reservationEmail, reservationComment, reservationDate) == true)
            {
                MessageBox.Show($"Rerservering gewijzigd!");
                FillResList();
                ChangeRes_pnl.Hide();
            }
            else { MessageBox.Show("Er is iets fout gegaan"); }
        }
    

        private void BevestigResBtn_Click_1(object sender, EventArgs e)
        {
            AddTafelDD.Items.Clear();
            foreach (Table t in t_service.GetTables())
            {
                AddTafelDD.Items.Add(t.tableId);
            }
            Reservering reservering = new Reservering
            {
                reservationId = res_service.GetLastReserveringId(),
                tableId = AddTafelDD.SelectedIndex + 1,
                reservationName = AddNaamDD.Text,
                reservationTel = Addtel.Text,
                reservationEmail = AddEmail.Text,
                reservationComment = AddOpmerking.Text,
                reservationDate = DateTime.Parse(AddDatum.Text)
            };

            if (res_service.InsertReservering(reservering) == true)
            {
                MessageBox.Show("Reservering toegevoegd");
            }
            else
            {
                MessageBox.Show("Er is iets fout gegaan!");
            }
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (AllOrderslv.SelectedItems.Count <= 0 || AllOrderslv.SelectedItems.Count == null)
            {
                MessageBox.Show("U heeft geen gerecht geselecteerd");
            }
            else
            {
                ChangeAmount_pnl.Show();
                orderIDlbl.Text = $"ORDER ID: {AllOrderslv.SelectedItems[0].SubItems[0].Text}";
                orderItemlbl.Text = AllOrderslv.SelectedItems[0].SubItems[2].Text;
                AmountBox.Text = AllOrderslv.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void OrderBtn1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn6_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn2_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn3_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn7_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn4_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn8_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn5_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn9_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void OrderBtn10_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void ReservationBtn1_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn6_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn2_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn3_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn7_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ResservationBtn4_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void Reser8vationBtn_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn5_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn9_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        private void ReservationBtn10_Click(object sender, EventArgs e)
        {
            AddRes();
        }

        // kelvin

        private void vulAfrekenenPanel(int orderTableID)
        {
            ChapooLogic.Afreken_Service t_service = new ChapooLogic.Afreken_Service();
            List<OrdersTable> TableList = t_service.GetAllOrdersFromTable(orderTableID);
            decimal price = 0;
            int orderId = 0;

            foreach (OrdersTable t in TableList)
            {
                price += t.Price * t.Amount;
                orderId = t.OrderId;

                string[] bestellingitemarray = new string[] {
                    t.MenuItemId.ToString(),
                    t.ItemName.ToString(),
                    t.Amount.ToString(),
                    t.OrderId.ToString()
                };

                ListViewItem item = new ListViewItem(bestellingitemarray);
                listview_productenAfrekenen.Items.Add(item);
            }
            lbl_overzichtBedrag.Text = price.ToString("##.00");
            lbl_btwBedrag.Text = (price * Vat).ToString("##.00");
            lbl_AfrekenTafel.Text = $"Bestelling voor tafel: {orderTableID}";
            lbl_orderIDAfrekenen.Text = orderId.ToString();

            GetAllPaymethods();
        }
        private void GetAllPaymethods()
        {
            ChapooLogic.Afreken_Service t_service = new ChapooLogic.Afreken_Service();
            List<string> payments = t_service.GetAllPaymethods();

            cmbBox_betaalmethode.Items.Clear();

            foreach (string item in payments)
            {
                cmbBox_betaalmethode.Items.Add(item);
            }
        }

        private void PayBtn1_Click_1(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(1);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
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

        private void PayBtn10_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(10);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn5_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(5);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn4_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(4);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn3_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(3);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn2_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(2);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn6_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(6);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn7_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(7);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn8_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(8);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void PayBtn9_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(9);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        private void lbl_afrekenen_Click(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(lbl_overzichtBedrag.Text);
            int paymethodID = cmbBox_betaalmethode.SelectedIndex + 1;
            decimal vatPercentage = decimal.Parse(lbl_btwBedrag.Text);
            decimal paidPrice = decimal.Parse(txtbox_betaaldBedrag.Text);
            decimal tip = decimal.Parse(txtbox_fooiBedrag.Text);
            int orderId = int.Parse(lbl_orderIDAfrekenen.Text);

            ChapooLogic.Afreken_Service t_service = new ChapooLogic.Afreken_Service();
            t_service.ReceiptCustomer(orderId, paymethodID, vatPercentage, tip, paidPrice, totalPrice);

            MessageBox.Show("U heeft afgerekend!");
        }

        private void btn_terugTafels_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bedieningForm = new BedieningForm();
            bedieningForm.Closed += (s, args) => this.Close();
            bedieningForm.Show();
        }

    }
}
