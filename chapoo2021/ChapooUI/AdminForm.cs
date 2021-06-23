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
    //Made by Anel Gusinac
    public partial class AdminForm : Form
    {
        private MenuItems_Service menuItemService = new MenuItems_Service();
        private User_Service userService = new User_Service();

        List<User> userList;
        public AdminForm()
        {
            InitializeComponent();
            HidePanelsRecursively(this);
            FillCmbMenuNames();
            this.userList = userService.GetAllUsers();

            ShowPanel("pnlAdminHome");
        }
        //Error Handling functions
        private void CallErrorPanel(string errorText)
        {
            lblAdminMessageText.Text = errorText;
            pnlAdminMessagePanel.Show();
        }
        public void HidePanelsRecursively(Control container)
        {
            if (container is Panel)
                container.Visible = false;

            foreach (Control ctrl in container.Controls)
                HidePanelsRecursively(ctrl);
        }
        private bool CheckPanelTextboxesIfEmpty(Panel panel)
        {
            foreach (TextBox s in panel.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(s.Text))
                {
                    CallErrorPanel($"Alle velden moeten ingevuld zijn.");
                    return false;
                }
            }
            return true;
        }
        private bool IfTextBoxIsEmpty(TextBox txtBox, string errorMessage)
        {
            if (txtBox.Text == "")
            {
                CallErrorPanel(errorMessage);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDouble(string text)
        {
            double num = 0;
            bool isDouble = false;

            if (string.IsNullOrEmpty(text))
                return false;

            isDouble = double.TryParse(text, out num);

            return isDouble;
        }
        //Hides all panels and displays given panel.
        private void ShowPanel(string panelName)
        {
            if (panelName == "pnlAdminStock")
            {
                HidePanelsRecursively(this);
                pnlAdminStock.Show();
            }
            else if (panelName == "pnlAdminMenuItems")
            {
                HidePanelsRecursively(this);
                pnlAdminMenuItems.Show();
            }
            else if (panelName == "pnlAdminHome")
            {
                HidePanelsRecursively(this);
                pnlAdminHome.Show();
            }
            else if (panelName == "pnlAdminMenuCards")
            {
                FillLvMenuCards();
                HidePanelsRecursively(this);
                pnlAdminMenuCards.Show();
            }
            else if (panelName == "pnlAdminUsers")
            {
                FillLVAdminUsers();
                HidePanelsRecursively(this);
                pnlAdminUsers.Show();
            }
        }
        //Cancel Buttons and linking buttons
        private void btnAdminStock_Click(object sender, EventArgs e)
        {
            ShowPanel("pnlAdminStock");
        }
        private void btnAdminStockBack_Click(object sender, EventArgs e)
        {
            pnlAdminStockEdit.Hide();
        }
        private void btnAdminMenuArticles_Click(object sender, EventArgs e)
        {
            ShowPanel("pnlAdminMenuItems");
        }
        private void pbAdminLogoSmall_Click(object sender, EventArgs e)
        {
            ShowPanel("pnlAdminHome");
        }
        private void btnAdminMenuCards_Click(object sender, EventArgs e)
        {
            ShowPanel("pnlAdminMenuCards");
        }
        private void btnAdminEmployees_Click(object sender, EventArgs e)
        {
            ShowPanel("pnlAdminUsers");
        }
        private void btnAdminMenuCardsCreate_Click(object sender, EventArgs e)
        {
            pnlAdminMenuCardsCreate.Show();
        }
        private void btnAdminMenuCardsCancel_Click(object sender, EventArgs e)
        {
            pnlAdminMenuCardsCreate.Hide();
        }
        private void btnAdminCloseDeleteMessage_Click(object sender, EventArgs e)
        {
            pnlAdminMessagePanel.Hide();
        }
        private void btnAdminMenuItemsBack2_Click(object sender, EventArgs e)
        {
            pnlAdminMenuItemsEdit.Hide();
        }
        private void btnAdminUsersCreateCancel_Click(object sender, EventArgs e)
        {
            pnlAdminUsersCreate.Hide();
        }
        private void btnAdminUsersEditCancel_Click(object sender, EventArgs e)
        {
            pnlAdminUsersEdit.Hide();
        }
        //Fills comboboxes with menu names.
        public void FillCmbMenuNames()
        {
            List<MenuItems> menuList = menuItemService.GetMenuNames();
            cmbAdminMenuNames.Items.Clear();
            cmbAdminMenuNames2.Items.Clear();

            foreach (MenuItems item in menuList)
            {
                cmbAdminMenuNames.Items.Add(item.MenuItemName);
                cmbAdminMenuNames2.Items.Add(item.MenuItemName);
            }
            cmbAdminMenuNames.SelectedIndex = 0;
            cmbAdminMenuNames2.SelectedIndex = 0;
        }
        //Fills listviews with ID from combobox. (Selects particular menu)
        private void cmbAdminMenuNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menuId = cmbAdminMenuNames.SelectedIndex + 1;
            FillLvMenuItems(menuId);
            FillLvMenuItem(menuId);
        }
        //Function fills Listview with menuItemName & Stock that are in the menu with the given ID.
        public void FillLvMenuItems(int menuId)
        {
            List<MenuItems> menuList = menuItemService.GetMenuItemStock(menuId);
            lvAdminMenuItemStock.Items.Clear();
            foreach (MenuItems menuItem in menuList)
            {
                ListViewItem item = new ListViewItem(menuItem.MenuItemId.ToString());
                item.SubItems.Add(menuItem.MenuItemName);
                item.SubItems.Add(menuItem.MenuItemStock.ToString());

                lvAdminMenuItemStock.Items.Add(item);
            }
        }
        //Fills Listview with product id, name, price, alcoholic etc. 
        public void FillLvMenuItem(int menuId)
        {
            List<MenuItems> menuList = menuItemService.GetAllMenuItemsByMenuId(menuId);
            lvAdminMenuItemList.Items.Clear();
            string alcoholBool = "";
            foreach (MenuItems menuItem in menuList)
            {
                ListViewItem item = new ListViewItem(menuItem.MenuItemId.ToString());
                item.SubItems.Add(menuItem.MenuItemName);
                item.SubItems.Add(menuItem.MenuItemPrice.ToString("0.00"));

                if (menuItem.ContainsAlcohol == true)
                    alcoholBool = "Ja";
                else
                    alcoholBool = "Nee";

                item.SubItems.Add(alcoholBool);

                lvAdminMenuItemList.Items.Add(item);
            }
        }
        //Checks if stock LV has been selected and than opens edit panel.
        private void btnAdminChangeStock_Click(object sender, EventArgs e)
        {
            if (lvAdminMenuItemStock.SelectedItems.Count > 0)
            {
                rtbStockEditProductName.Text = lvAdminMenuItemStock.SelectedItems[0].SubItems[1].Text;
                tbAdminStock.Text = lvAdminMenuItemStock.SelectedItems[0].SubItems[2].Text;

                pnlAdminStockEdit.Show();
            }
            else
                CallErrorPanel("Selecteer het product dat u wilt wijzigen!");
        }
        //Updates stock of selected product. 
        private void btnAdminStockEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvAdminMenuItemStock.SelectedItems[0].SubItems[0].Text);
            string name = lvAdminMenuItemStock.SelectedItems[0].SubItems[1].Text;


            if (!tbAdminStock.Text.All(char.IsDigit))
                CallErrorPanel("U kunt alleen getallen invoeren als voorraad.");
            else if (IfTextBoxIsEmpty(tbAdminStock, "Het voorraad mag niet leeg gelaten worden. ") == true)
                CallErrorPanel("Het veld voorraad mag niet leeg gelaten worden.");
            else
            {
                int productStock = int.Parse(tbAdminStock.Text);
                menuItemService.UpdateMenuItemStock(id, productStock);
                FillLvMenuItems(cmbAdminMenuNames.SelectedIndex + 1);

                pnlAdminStockEdit.Hide();

                CallErrorPanel($"De voorraad van het product: {name} is aangepast.");
            }
        }
        //Fills combobox on menuArticles listview
        private void cmbAdminMenuNames2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menuId = cmbAdminMenuNames2.SelectedIndex + 1;
            FillLvMenuItem(menuId);
        }
        // Open panel to create menu articles. 
        private void btnAdminCreateMenuItem_Click(object sender, EventArgs e)
        {
            cmbAdminAlcohol.Items.Clear();
            cmbAdminAlcohol.Items.Add("Nee");
            cmbAdminAlcohol.Items.Add("Ja");

            cmbAdminAlcohol.SelectedIndex = 0;
            pnlAdminMenuItemsCreate.Show();
        }
        //Close panel for editing menu articles. 
        private void btnAdminMenuItemsBack_Click(object sender, EventArgs e)
        {
            pnlAdminMenuItemsCreate.Hide();
        }
        //Create method
        private void btnAdminMenuItemsCreate_Click(object sender, EventArgs e)
        {
            if (!CheckPanelTextboxesIfEmpty(pnlAdminMenuItemsCreate))
                return;
            else if (!tbAdminMenuItemStock.Text.All(char.IsDigit))
                CallErrorPanel("U kunt alleen getallen invoeren als voorraad.");
            else if (!IsDouble(tbAdminMenuItemPrice.Text))
                CallErrorPanel("De prijs moet bestaan uit getallen en gescheiden zijn met een comma (,)");
            else
            {
                int menuId = cmbAdminMenuNames2.SelectedIndex + 1;
                double price = double.Parse(tbAdminMenuItemPrice.Text);
                int stock = int.Parse(tbAdminMenuItemStock.Text);
                int containsAlcohol = cmbAdminAlcohol.SelectedIndex;
                string itemName = tbAdminMenuItemName.Text;

                menuItemService.CreateMenuItem(menuId, price, stock, containsAlcohol, itemName);

                FillLvMenuItem(cmbAdminMenuNames2.SelectedIndex + 1);

                pnlAdminMenuItemsCreate.Hide();

                CallErrorPanel($"Het product: {itemName} is aangemaakt.");
            }
        }
        //Open editing form in panel 
        private void btnAdminEditMenuItem_Click(object sender, EventArgs e)
        {
            cmbAdminAlcohol2.Items.Clear();
            cmbAdminAlcohol2.Items.Add("Nee");
            cmbAdminAlcohol2.Items.Add("Ja");

            cmbAdminAlcohol2.SelectedIndex = 0;

            if (lvAdminMenuItemList.SelectedItems.Count > 0)
            {
                tbAdminMenuItemName2.Text = lvAdminMenuItemList.SelectedItems[0].SubItems[1].Text;
                tbAdminMenuItemPrice2.Text = lvAdminMenuItemList.SelectedItems[0].SubItems[2].Text;

                if (lvAdminMenuItemList.SelectedItems[0].SubItems[3].Text == "Ja")
                    cmbAdminAlcohol2.SelectedIndex = 1;
                else
                    cmbAdminAlcohol2.SelectedIndex = 0;

                pnlAdminMenuItemsEdit.Show();
            }
            else
                CallErrorPanel("Selecteer het product dat u wilt bewerken.");
        }
        //Delete menu item
        private void btnAdminDeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (lvAdminMenuItemList.SelectedItems.Count > 0)
            {
                int numb = int.Parse(lvAdminMenuItemList.SelectedItems[0].SubItems[0].Text);
                string name = lvAdminMenuItemList.SelectedItems[0].SubItems[1].Text;
                menuItemService.DeleteMenuItem(numb);

                lblAdminMessageText.Text = $"Het product: {name} is verwijderd uit het menu.";
                pnlAdminMessagePanel.Show();

                FillLvMenuItem(cmbAdminMenuNames2.SelectedIndex + 1);
            }
            else
                CallErrorPanel("Selecteer het product dat u wilt verwijderen!");
        }

        //Updates menuItem
        private void btnAdminMenuItemsUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckPanelTextboxesIfEmpty(pnlAdminMenuItemsEdit))
                return;
            else if (!IsDouble(tbAdminMenuItemPrice2.Text))
                CallErrorPanel("Prijs moet bestaan uit getallen gescheiden met een comma");
            else
            {
                int menuItemId = int.Parse(lvAdminMenuItemList.SelectedItems[0].SubItems[0].Text);
                string name = tbAdminMenuItemName2.Text;
                double price = double.Parse(tbAdminMenuItemPrice2.Text);
                int alcohol = cmbAdminAlcohol2.SelectedIndex;

                menuItemService.UpdateMenuItem(menuItemId, name, price, alcohol);

                FillLvMenuItem(cmbAdminMenuNames2.SelectedIndex + 1);

                pnlAdminMenuItemsEdit.Hide();

                CallErrorPanel($"Het product: {name} is aangepast.");
            }
        }

        //MenuCards Panel
        public void FillLvMenuCards()
        {
            lvAdminMenuCardsList.Items.Clear();
            List<MenuItems> menuList = menuItemService.GetMenuNames();

            foreach (MenuItems item in menuList)
            {
                ListViewItem subItem = new ListViewItem(item.MenuId.ToString());
                subItem.SubItems.Add(item.MenuItemName);
                lvAdminMenuCardsList.Items.Add(subItem);
            }
        }
        private void btnAdminMenuCardsInsert_Click(object sender, EventArgs e)
        {
            if (!IfTextBoxIsEmpty(tbAdminMenuCardName, "U bent vergeten het menu een naam te geven."))
            {
                string menuName = tbAdminMenuCardName.Text;
                menuItemService.CreateMenu(menuName);

                FillLvMenuCards();

                pnlAdminMenuCardsCreate.Hide();

                CallErrorPanel($"Het menu: {menuName} is aangemaakt.");

                FillCmbMenuNames();
            }
        }
        private void btnAdminMenuCardsUpdate_Click(object sender, EventArgs e)
        {
            int menuId = int.Parse(lvAdminMenuCardsList.SelectedItems[0].SubItems[0].Text);
            string name = tbAdminMenuCardNameUpdate.Text;

            menuItemService.UpdateMenu(menuId, name);

            FillLvMenuCards();

            pnlAdminMenuCardsUpdate.Hide();

            CallErrorPanel($"Het menu: {name} is aangepast.");
        }
        private void btnAdminMenuCardsEdit_Click(object sender, EventArgs e)
        {
            if (lvAdminMenuCardsList.SelectedItems.Count > 0)
            {
                tbAdminMenuCardNameUpdate.Text = lvAdminMenuCardsList.SelectedItems[0].SubItems[1].Text;

                pnlAdminMenuCardsUpdate.Show();
            }
            else
                CallErrorPanel("Selecteer het menu dat u wilt bewerken.");
        }
        private void btnAdminMenuCardsReturn_Click(object sender, EventArgs e)
        {
            pnlAdminMenuCardsUpdate.Hide();
        }
        private void btnAdminMenuCardsDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminMenuCardsList.SelectedItems.Count > 0)
            {
                int menuId = int.Parse(lvAdminMenuCardsList.SelectedItems[0].SubItems[0].Text);
                string menuNaam = lvAdminMenuCardsList.SelectedItems[0].SubItems[1].Text;

                menuItemService.DeleteMenu(menuId);
                FillLvMenuCards();
                FillCmbMenuNames();

                CallErrorPanel($"Het menu: {menuNaam} is verwijderd.");
            }
            else
                CallErrorPanel($"Selecteer het menu dat u wilt verwijderen.");
        }

        //Werknemers panel
        private void FillLVAdminUsers()
        {
            lvAdminUsers.Items.Clear();

            List<User> userList = userService.GetAllUsers();

            foreach (User item in userList)
            {
                ListViewItem subItem = new ListViewItem($"{item.Id}");
                subItem.SubItems.Add(item.Name);
                subItem.SubItems.Add(item.EmployeeCode);
                subItem.SubItems.Add(item.FunctionName);
                subItem.SubItems.Add(item.SecretQuestion);
                subItem.SubItems.Add(item.SecretAnswer);
                lvAdminUsers.Items.Add(subItem);
            }
        }
        private void btnAdminUsersDelete_Click(object sender, EventArgs e)
        {
            if (lvAdminUsers.SelectedItems.Count > 0)
            {
                int userId = int.Parse(lvAdminUsers.SelectedItems[0].SubItems[0].Text);
                string name = lvAdminUsers.SelectedItems[0].SubItems[1].Text;

                userService.DeleteUser(userId);
                FillLVAdminUsers();

                CallErrorPanel($"De gebruiker: {name} is verwijderd.");
            }
            else
            {
                CallErrorPanel($"Selecteer eerst een gebruiker om te verwijderen.");
            }
        }
        private void FillFunctionsCMB()
        {
            List<string> functions = userService.GetAllFunctions();

            admin_cmbEditFunction.Items.Clear();
            foreach (string function in functions)
            {
                admin_cmbEditFunction.Items.Add(function);
            }
        }
        private void FillCreateFunctionsCMB()
        {
            admin_cmbCreateFunction.Items.Clear();
            List<string> functions = userService.GetAllFunctions();
            foreach (string function in functions)
            {
                admin_cmbCreateFunction.Items.Add(function);
            }
        }
        private void btnAdminUsersEdit_Click(object sender, EventArgs e)
        {
            if (lvAdminUsers.SelectedItems.Count > 0)
            {
                FillFunctionsCMB();
                int employeeId = int.Parse(lvAdminUsers.SelectedItems[0].SubItems[0].Text);

                User user = userService.GetUserById(employeeId);

                admin_tbEditUsername.Text = user.Name;
                admin_tbEditCode.Text = user.EmployeeCode;
                admin_cmbEditFunction.SelectedIndex = user.FunctionId - 1;
                admin_tbEditQuestion.Text = user.SecretQuestion;
                admin_tbEditAnswer.Text = user.SecretAnswer;

                pnlAdminUsersEdit.Show();
            }
            else
            {
                CallErrorPanel($"Selecteer de gebruiker die u wilt bewerken.");
            }
        }
        private void btnAdminUsersCreate_Click(object sender, EventArgs e)
        {
            pnlAdminUsersCreate.Show();

            FillCreateFunctionsCMB();
            admin_cmbCreateFunction.SelectedIndex = 0;
        }
        //Inserts user after error checking/handling
        private void btnAdminUsersInsert_Click(object sender, EventArgs e)
        {
            if (!CheckPanelTextboxesIfEmpty(pnlAdminUsersCreate))
                return;
            if (!userService.PasswordIsEqual(admin_tbCreatePassword.Text, admin_tbCreatePassword2.Text))
            {
                CallErrorPanel($"Wachtwoorden moeten gelijk zijn!");
                return;
            }
            if (!userService.CheckPasswordPattern(admin_tbCreatePassword.Text))
            {
                CallErrorPanel($"Wachtwoord moet minstens een hoofdletter, kleine letter en één speciaal teken bevatten.");
                return;
            }
            int newValue;

            if (!int.TryParse(admin_tbCreateCode.Text, out newValue))
            {
                CallErrorPanel($"Het personeelsnummer mag geen letters bevatten!");
                return;
            }
            else if (newValue.ToString().Length < 4 || newValue.ToString().Length > 4)
            {
                CallErrorPanel($"Personeelsnummer moet een 4 cijferig getal zijn tussen 1000 en 9999.");
                return;
            }
            else
            {
                User user = new User()
                {
                    Name = admin_tbCreateUsername.Text,
                    EmployeeCode = newValue.ToString(),
                    FunctionId = admin_cmbCreateFunction.SelectedIndex + 1,
                    SecretQuestion = admin_tbCreateQuestion.Text,
                    SecretAnswer = admin_tbCreateAnswer.Text,
                    HashWithSalt = userService.PasswordToSHA256(admin_tbCreatePassword.Text)
                };
                userService.InsertUser(user);

                CallErrorPanel($"De gebruiker {user.Name} is aangemaakt!");

                FillLVAdminUsers();
                pnlAdminUsersCreate.Hide();
            }
        }
        //Updates users after some error checking/handling
        private void btnAdminUsersUpdate_Click(object sender, EventArgs e)
        {
            pnlAdminUsersEdit.Hide();
            int newValue;
            if (!CheckPanelTextboxesIfEmpty(pnlAdminUsersEdit))
                return;
            else if (!int.TryParse(admin_tbEditCode.Text, out newValue))
            {
                CallErrorPanel($"Het personeelsnummer mag geen letters bevatten!");
            }
            else if (newValue.ToString().Length < 4 || newValue.ToString().Length > 4)
            {
                CallErrorPanel($"Personeelsnummer moet een 4 cijferig getal zijn tussen 1000 en 9999.");
            }
            else
            {
                User user = new User()
                {
                    Id = int.Parse(lvAdminUsers.SelectedItems[0].SubItems[0].Text),
                    Name = admin_tbEditUsername.Text,
                    EmployeeCode = admin_tbEditCode.Text,
                    FunctionId = admin_cmbEditFunction.SelectedIndex + 1,
                    SecretQuestion = admin_tbEditQuestion.Text,
                    SecretAnswer = admin_tbEditAnswer.Text
                };
                userService.UpdateUser(user);
                CallErrorPanel($"De gebruiker: {user.Name} is bijgewerkt!");

                FillLVAdminUsers();

            }
        }

        //Logout gemaakt door Jelle De Vries
        private void lblAdminLogOut_Click(object sender, EventArgs e)
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