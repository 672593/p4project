
namespace ChapooUI
{
    partial class BarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogOffLink = new System.Windows.Forms.Label();
            this.Chapoo_title = new System.Windows.Forms.Label();
            this.bestelling_gereedLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingekomen_bestellingenLbl = new System.Windows.Forms.Label();
            this.ConfirmOrderBtn = new System.Windows.Forms.Button();
            this.RefreshOrdersBtn = new System.Windows.Forms.Button();
            this.RefreshImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RefreshStockBtn = new System.Windows.Forms.Button();
            this.voorraad_barmanLv = new System.Windows.Forms.ListView();
            this.BarVoorraadId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarMenuId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarItemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarItemStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarAlcoholCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voorraadLbl = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keukenbestelling_gereedLv = new System.Windows.Forms.ListView();
            this.tb_ID_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Amount_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Prijs_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Table_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Name_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Status_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.voorraad_keukenLv = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Keuken_Bestelling_Wijzig = new System.Windows.Forms.Panel();
            this.btn_Keuken_Wijzig_Cancel = new System.Windows.Forms.Button();
            this.btn_Keuken_Wijzig_Accept = new System.Windows.Forms.Button();
            this.tb_pnl_ID_keuken = new System.Windows.Forms.Label();
            this.tb_pnl_Tafel_keuken = new System.Windows.Forms.Label();
            this.tb_pnl_Status_keuken = new System.Windows.Forms.Label();
            this.tb_pnl_Amount_keuken = new System.Windows.Forms.Label();
            this.tb_pnl_Prijs_keuken = new System.Windows.Forms.Label();
            this.tb_pnl_Name_keuken = new System.Windows.Forms.Label();
            this.btn_Gereed_Bestelling_Keuken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Keuken_Bestelling_Wijzig.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOffLink
            // 
            this.LogOffLink.AutoSize = true;
            this.LogOffLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffLink.ForeColor = System.Drawing.Color.Red;
            this.LogOffLink.Location = new System.Drawing.Point(1147, 9);
            this.LogOffLink.Name = "LogOffLink";
            this.LogOffLink.Size = new System.Drawing.Size(67, 15);
            this.LogOffLink.TabIndex = 13;
            this.LogOffLink.Text = "Afmelden";
            // 
            // Chapoo_title
            // 
            this.Chapoo_title.AutoSize = true;
            this.Chapoo_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapoo_title.ForeColor = System.Drawing.Color.White;
            this.Chapoo_title.Location = new System.Drawing.Point(24, 9);
            this.Chapoo_title.Name = "Chapoo_title";
            this.Chapoo_title.Size = new System.Drawing.Size(118, 15);
            this.Chapoo_title.TabIndex = 12;
            this.Chapoo_title.Text = "Chapoo | Barman";
            // 
            // bestelling_gereedLv
            // 
            this.bestelling_gereedLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.bestelling_gereedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestelling_gereedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.bestelling_gereedLv.HideSelection = false;
            this.bestelling_gereedLv.Location = new System.Drawing.Point(27, 78);
            this.bestelling_gereedLv.Name = "bestelling_gereedLv";
            this.bestelling_gereedLv.Size = new System.Drawing.Size(399, 167);
            this.bestelling_gereedLv.TabIndex = 15;
            this.bestelling_gereedLv.UseCompatibleStateImageBehavior = false;
            this.bestelling_gereedLv.View = System.Windows.Forms.View.Details;
            // 
            // ingekomen_bestellingenLbl
            // 
            this.ingekomen_bestellingenLbl.AutoSize = true;
            this.ingekomen_bestellingenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingekomen_bestellingenLbl.ForeColor = System.Drawing.Color.White;
            this.ingekomen_bestellingenLbl.Location = new System.Drawing.Point(24, 50);
            this.ingekomen_bestellingenLbl.Name = "ingekomen_bestellingenLbl";
            this.ingekomen_bestellingenLbl.Size = new System.Drawing.Size(197, 15);
            this.ingekomen_bestellingenLbl.TabIndex = 14;
            this.ingekomen_bestellingenLbl.Text = "INGEKOMEN BESTELLINGEN";
            // 
            // ConfirmOrderBtn
            // 
            this.ConfirmOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.ConfirmOrderBtn.Enabled = false;
            this.ConfirmOrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.ConfirmOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOrderBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmOrderBtn.Location = new System.Drawing.Point(27, 269);
            this.ConfirmOrderBtn.Name = "ConfirmOrderBtn";
            this.ConfirmOrderBtn.Size = new System.Drawing.Size(179, 48);
            this.ConfirmOrderBtn.TabIndex = 18;
            this.ConfirmOrderBtn.Text = "BEVESTIGEN";
            this.ConfirmOrderBtn.UseVisualStyleBackColor = false;
            // 
            // RefreshOrdersBtn
            // 
            this.RefreshOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshOrdersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshOrdersBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshOrdersBtn.Location = new System.Drawing.Point(456, 78);
            this.RefreshOrdersBtn.Name = "RefreshOrdersBtn";
            this.RefreshOrdersBtn.Size = new System.Drawing.Size(80, 48);
            this.RefreshOrdersBtn.TabIndex = 19;
            this.RefreshOrdersBtn.UseVisualStyleBackColor = false;
            this.RefreshOrdersBtn.Click += new System.EventHandler(this.RefreshOrdersBtn_Click);
            // 
            // RefreshImg
            // 
            this.RefreshImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshImg.Location = new System.Drawing.Point(465, 171);
            this.RefreshImg.Name = "RefreshImg";
            this.RefreshImg.Size = new System.Drawing.Size(54, 36);
            this.RefreshImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshImg.TabIndex = 20;
            this.RefreshImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1054, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // RefreshStockBtn
            // 
            this.RefreshStockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshStockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshStockBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshStockBtn.Location = new System.Drawing.Point(1042, 78);
            this.RefreshStockBtn.Name = "RefreshStockBtn";
            this.RefreshStockBtn.Size = new System.Drawing.Size(80, 48);
            this.RefreshStockBtn.TabIndex = 23;
            this.RefreshStockBtn.UseVisualStyleBackColor = false;
            this.RefreshStockBtn.Click += new System.EventHandler(this.RefreshStockBtn_Click);
            // 
            // voorraad_barmanLv
            // 
            this.voorraad_barmanLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.voorraad_barmanLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voorraad_barmanLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BarVoorraadId,
            this.BarMenuId,
            this.BarItemPrice,
            this.BarItemStock,
            this.BarAlcoholCheck,
            this.BarItemName});
            this.voorraad_barmanLv.HideSelection = false;
            this.voorraad_barmanLv.Location = new System.Drawing.Point(613, 78);
            this.voorraad_barmanLv.Name = "voorraad_barmanLv";
            this.voorraad_barmanLv.Size = new System.Drawing.Size(399, 167);
            this.voorraad_barmanLv.TabIndex = 22;
            this.voorraad_barmanLv.UseCompatibleStateImageBehavior = false;
            this.voorraad_barmanLv.View = System.Windows.Forms.View.Details;
            // 
            // BarVoorraadId
            // 
            this.BarVoorraadId.Text = "Id";
            this.BarVoorraadId.Width = 26;
            // 
            // BarMenuId
            // 
            this.BarMenuId.Text = "Menu Type";
            this.BarMenuId.Width = 29;
            // 
            // BarItemPrice
            // 
            this.BarItemPrice.Text = "Price";
            // 
            // BarItemStock
            // 
            this.BarItemStock.Text = "Stock";
            this.BarItemStock.Width = 37;
            // 
            // BarAlcoholCheck
            // 
            this.BarAlcoholCheck.Text = "Alcohol";
            this.BarAlcoholCheck.Width = 36;
            // 
            // BarItemName
            // 
            this.BarItemName.Text = "Name";
            this.BarItemName.Width = 210;
            // 
            // voorraadLbl
            // 
            this.voorraadLbl.AutoSize = true;
            this.voorraadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorraadLbl.ForeColor = System.Drawing.Color.White;
            this.voorraadLbl.Location = new System.Drawing.Point(610, 50);
            this.voorraadLbl.Name = "voorraadLbl";
            this.voorraadLbl.Size = new System.Drawing.Size(81, 15);
            this.voorraadLbl.TabIndex = 21;
            this.voorraadLbl.Text = "VOORRAAD";
            // 
            // keukenbestelling_gereedLv
            // 
            this.keukenbestelling_gereedLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.keukenbestelling_gereedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keukenbestelling_gereedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tb_ID_keuken_bestelling,
            this.tb_Amount_keuken_bestelling,
            this.tb_Prijs_keuken_bestelling,
            this.tb_Table_keuken_bestelling,
            this.tb_Name_keuken_bestelling,
            this.tb_Status_keuken_bestelling});
            this.keukenbestelling_gereedLv.HideSelection = false;
            this.keukenbestelling_gereedLv.Location = new System.Drawing.Point(27, 354);
            this.keukenbestelling_gereedLv.Name = "keukenbestelling_gereedLv";
            this.keukenbestelling_gereedLv.Size = new System.Drawing.Size(399, 167);
            this.keukenbestelling_gereedLv.TabIndex = 25;
            this.keukenbestelling_gereedLv.UseCompatibleStateImageBehavior = false;
            this.keukenbestelling_gereedLv.View = System.Windows.Forms.View.Details;
            // 
            // tb_ID_keuken_bestelling
            // 
            this.tb_ID_keuken_bestelling.Text = "id";
            // 
            // tb_Amount_keuken_bestelling
            // 
            this.tb_Amount_keuken_bestelling.Text = "Amount";
            // 
            // tb_Prijs_keuken_bestelling
            // 
            this.tb_Prijs_keuken_bestelling.Text = "Prijs";
            // 
            // tb_Table_keuken_bestelling
            // 
            this.tb_Table_keuken_bestelling.Text = "Tafel Nummer";
            // 
            // tb_Name_keuken_bestelling
            // 
            this.tb_Name_keuken_bestelling.Text = "Name";
            // 
            // tb_Status_keuken_bestelling
            // 
            this.tb_Status_keuken_bestelling.Text = "Status";
            // 
            // voorraad_keukenLv
            // 
            this.voorraad_keukenLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.voorraad_keukenLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voorraad_keukenLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.voorraad_keukenLv.HideSelection = false;
            this.voorraad_keukenLv.Location = new System.Drawing.Point(613, 354);
            this.voorraad_keukenLv.Name = "voorraad_keukenLv";
            this.voorraad_keukenLv.Size = new System.Drawing.Size(399, 167);
            this.voorraad_keukenLv.TabIndex = 26;
            this.voorraad_keukenLv.UseCompatibleStateImageBehavior = false;
            this.voorraad_keukenLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Id";
            this.columnHeader13.Width = 26;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Menu Type";
            this.columnHeader14.Width = 29;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Price";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Stock";
            this.columnHeader16.Width = 37;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Alcohol";
            this.columnHeader17.Width = 36;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Name";
            this.columnHeader18.Width = 210;
            // 
            // pnl_Keuken_Bestelling_Wijzig
            // 
            this.pnl_Keuken_Bestelling_Wijzig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Name_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Prijs_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Amount_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Status_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Tafel_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.tb_pnl_ID_keuken);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.btn_Keuken_Wijzig_Cancel);
            this.pnl_Keuken_Bestelling_Wijzig.Controls.Add(this.btn_Keuken_Wijzig_Accept);
            this.pnl_Keuken_Bestelling_Wijzig.Location = new System.Drawing.Point(331, 132);
            this.pnl_Keuken_Bestelling_Wijzig.Name = "pnl_Keuken_Bestelling_Wijzig";
            this.pnl_Keuken_Bestelling_Wijzig.Size = new System.Drawing.Size(537, 334);
            this.pnl_Keuken_Bestelling_Wijzig.TabIndex = 27;
            this.pnl_Keuken_Bestelling_Wijzig.Visible = false;
            // 
            // btn_Keuken_Wijzig_Cancel
            // 
            this.btn_Keuken_Wijzig_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Keuken_Wijzig_Cancel.Location = new System.Drawing.Point(280, 262);
            this.btn_Keuken_Wijzig_Cancel.Name = "btn_Keuken_Wijzig_Cancel";
            this.btn_Keuken_Wijzig_Cancel.Size = new System.Drawing.Size(150, 32);
            this.btn_Keuken_Wijzig_Cancel.TabIndex = 5;
            this.btn_Keuken_Wijzig_Cancel.Text = "Cancel";
            this.btn_Keuken_Wijzig_Cancel.UseVisualStyleBackColor = true;
            this.btn_Keuken_Wijzig_Cancel.Click += new System.EventHandler(this.btn_Keuken_Wijzig_Cancel_Click);
            // 
            // btn_Keuken_Wijzig_Accept
            // 
            this.btn_Keuken_Wijzig_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Keuken_Wijzig_Accept.Location = new System.Drawing.Point(80, 262);
            this.btn_Keuken_Wijzig_Accept.Name = "btn_Keuken_Wijzig_Accept";
            this.btn_Keuken_Wijzig_Accept.Size = new System.Drawing.Size(150, 32);
            this.btn_Keuken_Wijzig_Accept.TabIndex = 4;
            this.btn_Keuken_Wijzig_Accept.Text = "Gereed";
            this.btn_Keuken_Wijzig_Accept.UseVisualStyleBackColor = true;
            // 
            // tb_pnl_ID_keuken
            // 
            this.tb_pnl_ID_keuken.AutoSize = true;
            this.tb_pnl_ID_keuken.Location = new System.Drawing.Point(46, 38);
            this.tb_pnl_ID_keuken.Name = "tb_pnl_ID_keuken";
            this.tb_pnl_ID_keuken.Size = new System.Drawing.Size(28, 13);
            this.tb_pnl_ID_keuken.TabIndex = 6;
            this.tb_pnl_ID_keuken.Text = "Test";
            // 
            // tb_pnl_Tafel_keuken
            // 
            this.tb_pnl_Tafel_keuken.AutoSize = true;
            this.tb_pnl_Tafel_keuken.Location = new System.Drawing.Point(49, 99);
            this.tb_pnl_Tafel_keuken.Name = "tb_pnl_Tafel_keuken";
            this.tb_pnl_Tafel_keuken.Size = new System.Drawing.Size(35, 13);
            this.tb_pnl_Tafel_keuken.TabIndex = 7;
            this.tb_pnl_Tafel_keuken.Text = "label1";
            // 
            // tb_pnl_Status_keuken
            // 
            this.tb_pnl_Status_keuken.AutoSize = true;
            this.tb_pnl_Status_keuken.Location = new System.Drawing.Point(49, 66);
            this.tb_pnl_Status_keuken.Name = "tb_pnl_Status_keuken";
            this.tb_pnl_Status_keuken.Size = new System.Drawing.Size(35, 13);
            this.tb_pnl_Status_keuken.TabIndex = 8;
            this.tb_pnl_Status_keuken.Text = "label1";
            // 
            // tb_pnl_Amount_keuken
            // 
            this.tb_pnl_Amount_keuken.AutoSize = true;
            this.tb_pnl_Amount_keuken.Location = new System.Drawing.Point(49, 136);
            this.tb_pnl_Amount_keuken.Name = "tb_pnl_Amount_keuken";
            this.tb_pnl_Amount_keuken.Size = new System.Drawing.Size(35, 13);
            this.tb_pnl_Amount_keuken.TabIndex = 9;
            this.tb_pnl_Amount_keuken.Text = "label1";
            // 
            // tb_pnl_Prijs_keuken
            // 
            this.tb_pnl_Prijs_keuken.AutoSize = true;
            this.tb_pnl_Prijs_keuken.Location = new System.Drawing.Point(49, 170);
            this.tb_pnl_Prijs_keuken.Name = "tb_pnl_Prijs_keuken";
            this.tb_pnl_Prijs_keuken.Size = new System.Drawing.Size(35, 13);
            this.tb_pnl_Prijs_keuken.TabIndex = 10;
            this.tb_pnl_Prijs_keuken.Text = "label1";
            // 
            // tb_pnl_Name_keuken
            // 
            this.tb_pnl_Name_keuken.AutoSize = true;
            this.tb_pnl_Name_keuken.Location = new System.Drawing.Point(49, 202);
            this.tb_pnl_Name_keuken.Name = "tb_pnl_Name_keuken";
            this.tb_pnl_Name_keuken.Size = new System.Drawing.Size(35, 13);
            this.tb_pnl_Name_keuken.TabIndex = 11;
            this.tb_pnl_Name_keuken.Text = "label1";
            // 
            // btn_Gereed_Bestelling_Keuken
            // 
            this.btn_Gereed_Bestelling_Keuken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btn_Gereed_Bestelling_Keuken.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btn_Gereed_Bestelling_Keuken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gereed_Bestelling_Keuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gereed_Bestelling_Keuken.ForeColor = System.Drawing.Color.White;
            this.btn_Gereed_Bestelling_Keuken.Location = new System.Drawing.Point(432, 473);
            this.btn_Gereed_Bestelling_Keuken.Name = "btn_Gereed_Bestelling_Keuken";
            this.btn_Gereed_Bestelling_Keuken.Size = new System.Drawing.Size(179, 48);
            this.btn_Gereed_Bestelling_Keuken.TabIndex = 28;
            this.btn_Gereed_Bestelling_Keuken.Text = "GEREED";
            this.btn_Gereed_Bestelling_Keuken.UseVisualStyleBackColor = false;
            this.btn_Gereed_Bestelling_Keuken.Click += new System.EventHandler(this.btn_Gereed_Bestelling_Keuken_Click);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1241, 561);
            this.Controls.Add(this.btn_Gereed_Bestelling_Keuken);
            this.Controls.Add(this.pnl_Keuken_Bestelling_Wijzig);
            this.Controls.Add(this.voorraad_keukenLv);
            this.Controls.Add(this.keukenbestelling_gereedLv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshStockBtn);
            this.Controls.Add(this.voorraad_barmanLv);
            this.Controls.Add(this.voorraadLbl);
            this.Controls.Add(this.RefreshImg);
            this.Controls.Add(this.RefreshOrdersBtn);
            this.Controls.Add(this.ConfirmOrderBtn);
            this.Controls.Add(this.bestelling_gereedLv);
            this.Controls.Add(this.ingekomen_bestellingenLbl);
            this.Controls.Add(this.LogOffLink);
            this.Controls.Add(this.Chapoo_title);
            this.Name = "BarForm";
            this.Text = "BarForm";
            ((System.ComponentModel.ISupportInitialize)(this.RefreshImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Keuken_Bestelling_Wijzig.ResumeLayout(false);
            this.pnl_Keuken_Bestelling_Wijzig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogOffLink;
        private System.Windows.Forms.Label Chapoo_title;
        private System.Windows.Forms.ListView bestelling_gereedLv;
        private System.Windows.Forms.Label ingekomen_bestellingenLbl;
        private System.Windows.Forms.Button ConfirmOrderBtn;
        private System.Windows.Forms.Button RefreshOrdersBtn;
        private System.Windows.Forms.PictureBox RefreshImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RefreshStockBtn;
        private System.Windows.Forms.ListView voorraad_barmanLv;
        private System.Windows.Forms.Label voorraadLbl;
        private System.Windows.Forms.ColumnHeader BarVoorraadId;
        private System.Windows.Forms.ColumnHeader BarMenuId;
        private System.Windows.Forms.ColumnHeader BarItemPrice;
        private System.Windows.Forms.ColumnHeader BarItemStock;
        private System.Windows.Forms.ColumnHeader BarAlcoholCheck;
        private System.Windows.Forms.ColumnHeader BarItemName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView keukenbestelling_gereedLv;
        private System.Windows.Forms.ColumnHeader tb_ID_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Amount_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Prijs_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Table_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Name_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Status_keuken_bestelling;
        private System.Windows.Forms.ListView voorraad_keukenLv;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Panel pnl_Keuken_Bestelling_Wijzig;
        private System.Windows.Forms.Label tb_pnl_Name_keuken;
        private System.Windows.Forms.Label tb_pnl_Prijs_keuken;
        private System.Windows.Forms.Label tb_pnl_Amount_keuken;
        private System.Windows.Forms.Label tb_pnl_Status_keuken;
        private System.Windows.Forms.Label tb_pnl_Tafel_keuken;
        private System.Windows.Forms.Label tb_pnl_ID_keuken;
        private System.Windows.Forms.Button btn_Keuken_Wijzig_Cancel;
        private System.Windows.Forms.Button btn_Keuken_Wijzig_Accept;
        private System.Windows.Forms.Button btn_Gereed_Bestelling_Keuken;
    }
}