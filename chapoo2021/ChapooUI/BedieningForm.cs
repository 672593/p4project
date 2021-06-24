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
        // -- 
        // jelle --
        private List<Label> labels;
        private List<Label> wlabels;
        private List<Table> tafels;

        private Table_Service tafelService;
        // -- 
        public void HidePanelsRecursively(Control container) // verberg panels
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

            // all waiting labels added to a list Made by Jelle de Vries
            wlabels = new List<Label>();
            wlabels.Add(lbl_w_1);
            wlabels.Add(lbl_w_2);
            wlabels.Add(lbl_w_3);
            wlabels.Add(lbl_w_4);
            wlabels.Add(lbl_w_5);
            wlabels.Add(lbl_w_6);
            wlabels.Add(lbl_w_7);
            wlabels.Add(lbl_w_8);
            wlabels.Add(lbl_w_9);
            wlabels.Add(lbl_w_10);


            TafelStatus();
            OrderStatus();
        }
        // --
        // bestelling // faruk
        // -- 
        private void AllOrdersBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);
            Order_pnl.Show(); AllOrders_pnl.Show(); Table10_pnl.Show(); Table9_pnl.Show(); Table8_pnl.Show(); Table7_pnl.Show();
            Table6_pnl.Show(); Table5_pnl.Show(); Table4_pnl.Show(); Table3_pnl.Show(); Table2_pnl.Show(); Table1_pnl.Show();
            AllOrderslv.Items.Clear();
            FillOrderItemList(); FillResList();
        }


        // bestelling items in het lijst zetten
        private void FillOrderItemList()
        {
            AllOrders_pnl.Show();
            AllOrderslv.Items.Clear();
            ChooseTableDD.Items.Clear();
           
            foreach (Table t in t_service.GetTables())
            {
                ChooseTableDD.Items.Add(t.tableId);
            }
            if (ChooseTableDD.SelectedIndex > 0)
            {
                FillMenuItemSpec(0); // kies tafel uit dropdown om alleen bestelingen van die tafel te zien
            } else
            {
                foreach (BestellingItem be in be_service.GetBestellingItems())
                {
                    ListViewItem item = new ListViewItem(be.orderId.ToString());
                    item.SubItems.Add(be.orderTableId.ToString());
                    item.SubItems.Add(be.itemName);
                    item.SubItems.Add(be.amount.ToString());

                    if (be.orderItemStatus == false)
                    {
                        item.SubItems[0].BackColor = Color.IndianRed;
                        item.SubItems.Add("Niet geserveerd");
                    }
                    else
                    {
                        item.SubItems[0].BackColor = Color.LightGreen;
                        item.SubItems.Add("Geserveerd");
                    }

                    AllOrderslv.Items.Add(item);
                }
          
            }
        }

        // bestelling item verwijderen
        private void DeleteOrderItemBtn_Click(object sender, EventArgs e)
        {
            if (AllOrderslv.SelectedItems.Count > 0)
            {
                int selectOrderId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);
                int selectmenuItemId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[1].Text);

                if (be_service.DeleteOrderItem(selectOrderId, selectmenuItemId) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Weet je het zeker?", "Verwijder gerecht", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Gerecht verwijderd");
                        FillOrderItemList();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        AllOrders_pnl.Show();
                    }
                }
            }
            else { MessageBox.Show("U heeft geen gerecht geselecteerd"); }
        }
        // Bestelling helemaal verwijderen
        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            int selectOrderId;
            if (AllOrderslv.SelectedItems.Count > 0)
            {
                selectOrderId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);

                if (be_service.DeleteOrder(selectOrderId) == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Weet je het zeker?", "Verwijder bestelling", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Bestelling verwijderd");
                        FillOrderItemList();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        AllOrders_pnl.Show();
                    }
                }
            }
            else { MessageBox.Show("U heeft geen bestelling geselecteerd"); }
        }
        // Aantal aanpassen van de bestelling
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            AllOrders_pnl.Hide(); ChangeAmount_pnl.Show();
            if (AllOrderslv.SelectedItems.Count <= 0)
            {
                MessageBox.Show("U heeft geen gerecht geselecteerd");
            }
            else
            {
                orderIDlbl.Text = $"TAFEL: {AllOrderslv.SelectedItems[0].SubItems[1].Text}";
                orderItemlbl.Text = AllOrderslv.SelectedItems[0].SubItems[2].Text;
                AmountBox.Text = AllOrderslv.SelectedItems[0].SubItems[3].Text;
            }
        }
        private void minBtn_Click(object sender, EventArgs e) // Aantal van orderitem verhogen bij besteling toevoegen
        {
            int amount = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text);
            amount--;
            if (amount < 0)
            {
                amount = 0;
            }
            amountOrderItem.Text = amount.ToString();
        }

        private void plusBtn_Click(object sender, EventArgs e) // Aantal van orderitem verlagen bij besteling toevoegen
        {
            int amount2 = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text);
            amount2++;
            if (amount2 == 100) // als aantal 100 bereikt krijgt de bediening een melding
            {
                DialogResult dialogResult = MessageBox.Show("U heeft de 100 gehaald. Wilt u verder gaan?", "Aantal is 100", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddOrder_pnl.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    amount2 = 1;
                }
            }
            amountOrderItem.Text = amount2.ToString();
        }


        private void Add() // dropdown vullen met data
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

            ConsumptieDD.Items.Clear();
            FillMenuItem(0); // menu items vullen op basis van menu
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void AllOrdersBtn2_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this);
            FillOrderItemList();
            AllOrders_pnl.Show();
            Order_pnl.Show();
        }

        private void BackToTablesBtn_Click(object sender, EventArgs e)
        {
            HidePanelsRecursively(this); Table10_pnl.Show(); Table9_pnl.Show(); Table8_pnl.Show(); Table7_pnl.Show();
            Table6_pnl.Show(); Table5_pnl.Show(); Table4_pnl.Show(); Table3_pnl.Show(); Table2_pnl.Show(); Table1_pnl.Show();
        }
        void ClearAllText(Control con) // veeg de textboxes schoon
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void OrderAddBtn_Click(object sender, EventArgs e)
        {
            int menuItemId = 0;
            int amount = 0;
            int totalprice = 0;
            int price = 0;
            Bestelling bestelling = new Bestelling
            {
                orderTableId = TafelDD.SelectedIndex + 1,
                employeeId = 1, // code van jelle moet nog komen
                currentDate = DateTime.Now,
                totalPrice = totalprice + price,
                comment = opmerkingBox.Text
            };
            BestellingItem bestellingItem = new BestellingItem
            {
                orderId = besteling_service.GetLastOrderId(),
                menuItemId = ConsumptieDD.SelectedIndex + 1,
                orderTime = DateTime.Now,
                amount = string.IsNullOrEmpty(amountOrderItem.Text) ? 0 : int.Parse(amountOrderItem.Text),
                price = 0 /*m_service.GetPriceForOrderItem(menuItemId) * amount*/,
                orderItemStatus = false
            };
            if (besteling_service.InsertBestelling(bestelling) && be_service.InsertBestellingItem(bestellingItem))
            {
                MessageBox.Show("Bestelling toegevoegd");
                totalprice = totalprice + price;
                ClearAllText(this);
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
            int menuItemId = ConsumptieDD.SelectedIndex + 1;
            FillMenuItem(menuItemId);
        }
        private void FillMenuItem(int menuId)
        {
            //ConsumptieDD.Items.Clear();
            foreach (MenuuItem m in m_service.GetSelitemName(menuId))
            {
                ConsumptieDD.Items.Add(m.itemName);
            }
        }
        private void ChooseTableDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderTableId = ChooseTableDD.SelectedIndex + 1;
            FillMenuItemSpec(orderTableId);
        }
        private void FillMenuItemSpec(int orderTableId) // order items ophalen van een gekozen tafel
        {
            AllOrderslv.Items.Clear();  
            foreach (BestellingItem be in be_service.GetOrderItemSpec(orderTableId))
            {
                
                ListViewItem item = new ListViewItem(be.orderId.ToString());
                item.SubItems.Add(be.orderTableId.ToString());
                item.SubItems.Add(be.itemName);
                item.SubItems.Add(be.amount.ToString());
                
                if (be.orderItemStatus == false)
                {
                    item.SubItems[0].BackColor = Color.IndianRed;
                    item.SubItems.Add("Niet geserveerd");
                }
                else
                {
                    item.SubItems[0].BackColor = Color.LightGreen;
                    item.SubItems.Add("Geserveerd");
                }

                AllOrderslv.Items.Add(item);
            }
        }

        private void plusAantalBtn_Click(object sender, EventArgs e) // aantal verhogen van order item
        {
            int amount = int.Parse(AmountBox.Text);
            amount++;
            if (amount == 100)
            {
                DialogResult dialogResult = MessageBox.Show("U heeft de 100 gehaald. Wilt u verder gaan?", "Aantal is 100", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChangeAmount_pnl.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    amount = 1;
                }
            }
            AmountBox.Text = amount.ToString();
        }

        private void minAantalBtn_Click(object sender, EventArgs e) // aantal verminderen van order item
        {
            int amount2 = int.Parse(AmountBox.Text);
            amount2--;
            if (amount2 < 0)
            {
                amount2 = 0;
            }
            AmountBox.Text = amount2.ToString();
        }
        private void ChangeAcceptBtn_Click(object sender, EventArgs e) // Bevestiging van aantal veranderen
        {
            int orderId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);
            int amount = int.Parse(AllOrderslv.SelectedItems[0].SubItems[3].Text);
            if (!string.IsNullOrEmpty(AmountBox.Text))
            {
                amount = int.Parse(AmountBox.Text);
            }
            else
            {
                throw new Exception("Er is iets fout gegaan!");
            }
            BestellingItem be = new BestellingItem();
            be.orderId = int.Parse(AllOrderslv.SelectedItems[0].SubItems[0].Text);
            be.amount = int.Parse(AllOrderslv.SelectedItems[0].SubItems[3].Text);

            if (be_service.UpdateAmountOrderItem(orderId, amount) == true)
            {
                MessageBox.Show($"Aantal is gewijzigd naar {amount}");
                FillOrderItemList();
                ChangeAmount_pnl.Hide();
            }
            else { MessageBox.Show("Er is iets fout gegaan"); }
        }

        // --
        // reservering  // faruk
        // --

        private void FillResList() // laat alle reserveringen zien
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

        private void DeleteResBtn_Click(object sender, EventArgs e) // verwijder reservering
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

        private void ChangeResBtn_Click(object sender, EventArgs e) // verander reservering (naar pagina)
        {
            if (Reservationlv.SelectedItems.Count <= 0)
            {
                MessageBox.Show("U heeft geen reservering geselecteerd");
            }
            else
            {
                ChangeRes_pnl.Show(); Res_pnl.Hide();
                TafelResDD.Text = (Reservationlv.SelectedItems[0].SubItems[1].Text);
                aamBox.Text = Reservationlv.SelectedItems[0].SubItems[2].Text;
                telBox.Text = Reservationlv.SelectedItems[0].SubItems[3].Text;
                emailBox.Text = Reservationlv.SelectedItems[0].SubItems[4].Text;
                opmerkingBox.Text = Reservationlv.SelectedItems[0].SubItems[5].Text;
                datumBox.Text = Reservationlv.SelectedItems[0].SubItems[6].Text;
            }
        }
        private void ChangeResAcceptBtn_Click(object sender, EventArgs e) // aanpassing bevestigen
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

            if (!string.IsNullOrEmpty(reservationId.ToString()))
            {
                tableId = int.Parse(TafelResDD.Text.ToString());
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
            Reservering r = new Reservering();

            r.reservationId = int.Parse(Reservationlv.SelectedItems[0].SubItems[0].Text);
            r.tableId = int.Parse(Reservationlv.SelectedItems[0].SubItems[1].Text);
            r.reservationName = Reservationlv.SelectedItems[0].SubItems[2].Text;
            r.reservationTel = Reservationlv.SelectedItems[0].SubItems[3].Text;
            r.reservationEmail = Reservationlv.SelectedItems[0].SubItems[4].Text;
            r.reservationComment = Reservationlv.SelectedItems[0].SubItems[5].Text;
            r.reservationDate = DateTime.Parse(Reservationlv.SelectedItems[0].SubItems[6].Text);
            

            if (res_service.EditReservering(r) == true)
            {
                MessageBox.Show($"Rerservering gewijzigd!");
                FillResList();
                ChangeRes_pnl.Hide();
            }
            else { MessageBox.Show("Er is iets fout gegaan"); }
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

        private void BevestigResBtn_Click_1(object sender, EventArgs e)
        {
            AddTafelDD.Items.Clear();
            foreach (Table t in t_service.GetTables())
            {
                AddTafelDD.Items.Add(t.tableId);
            }
            Reservering r = new Reservering();

            r.reservationId = res_service.GetLastReserveringId();
            r.tableId = AddTafelDD.SelectedIndex + 1;
            r.reservationName = AddNaamDD.Text;
            r.reservationTel = Addtel.Text;
            r.reservationEmail = AddEmail.Text;
            r.reservationComment = AddOpmerking.Text;
            r.reservationDate = DateTime.Parse(AddDatum.Text);
            

            if (res_service.InsertReservering(r.reservationId, r.tableId, r.reservationName, r.reservationTel, r.reservationEmail, r.reservationComment, r.reservationDate) == true)
            {
                MessageBox.Show("Reservering toegevoegd");
            }
            else
            {
                MessageBox.Show("Er is iets fout gegaan!");
            }
        }
     
        private void OrderBtn1_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 0;
        }

        private void OrderBtn6_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 5;
        }

        private void OrderBtn2_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 1;
        }

        private void OrderBtn3_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 2;
        }

        private void OrderBtn7_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 6;
        }

        private void OrderBtn4_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 3;
        }

        private void OrderBtn8_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 7;
        }

        private void OrderBtn5_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 4;
        }

        private void OrderBtn9_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 8;
        }

        private void OrderBtn10_Click(object sender, EventArgs e)
        {
            Add();
            TafelDD.SelectedIndex = 9;
        }

        private void ReservationBtn1_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 0;
        }

        private void ReservationBtn6_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 5;
        }

        private void ReservationBtn2_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 1;
        }

        private void ReservationBtn3_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 2;
        }

        private void ReservationBtn7_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 6;
        }

        private void ResservationBtn4_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 3;
        }

        private void Reser8vationBtn_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 7;
        }

        private void ReservationBtn5_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 4;
        }

        private void ReservationBtn9_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 8;
        }

        private void ReservationBtn10_Click(object sender, EventArgs e)
        {
            AddRes();
            AddTafelDD.SelectedIndex = 9;
        }

        // kelvin

        private void vulAfrekenenPanel(int orderTableID)
        {
            ChapooLogic.Afreken_Service t_service = new ChapooLogic.Afreken_Service();
            if (!t_service.CheckBetaald(orderTableID))
            {
                List<BestellingItem> TableList = t_service.GetAllOrdersFromTable(orderTableID);
                decimal price = 0;
                int orderId = 0;
                foreach (BestellingItem t in TableList)
                {
                    price += t.price * t.amount;
                    orderId = t.orderId;

                    string[] bestellingitemarray = new string[] {
                    t.menuItemId.ToString(),
                    t.itemName.ToString(),
                    t.amount.ToString(),
                    t.orderId.ToString()
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
            else
            {
                MessageBox.Show("Tafel heeft geen orders.");
            }
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

        private void LogOffLink_Click(object sender, EventArgs e)
        {
            uitlogBtn();
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

            this.Refresh();
        }

        private void btn_terugTafels_Click(object sender, EventArgs e)
        {
            terugTafelOverzicht();
        }
        private void uitlogBtn()
        {
            DialogResult dialog = MessageBox.Show("Weet u zeker dat u wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                this.Close();
                login.ShowDialog();
            }
        }
        private void terugTafelOverzicht()
        {
            this.Hide();
            var bedieningForm = new BedieningForm();
            bedieningForm.Closed += (s, args) => this.Close();
            bedieningForm.Show();
        }
        private void PayBtn1_Click_1(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(1);
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
        private void PayBtn3_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(3);
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
        private void PayBtn5_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(5);
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
        private void PayBtn10_Click(object sender, EventArgs e)
        {
            listview_productenAfrekenen.Items.Clear();
            vulAfrekenenPanel(10);
            HidePanelsRecursively(this);
            pnl_Afrekenen.Show();
        }

        // jelle
        private void TafelStatus()
        {
            // start get the tafel status
            tafels = t_service.GetTafelData();

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

        private void OrderStatus()
        {
            tafels = t_service.GetOrderStatus();

            for (int i = 0; i < tafels.Count; i++)
            {

                if (tafels[i].LopendeOrder == false)
                {
                    TimeSpan wachttijd = DateTime.Now - tafels[i].currentDate;

                    wlabels[i].Text = $"Wachttijd is {wachttijd.Minutes} minuten.";
                }


            }


        }
    }
}
