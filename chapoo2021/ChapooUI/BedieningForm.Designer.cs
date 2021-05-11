
namespace ChapooUI
{
    partial class BedieningForm
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
            this.Chapoo_title = new System.Windows.Forms.Label();
            this.Table_pnl = new System.Windows.Forms.Panel();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.OrderEditBtn = new System.Windows.Forms.Button();
            this.OrderDeleteBtn = new System.Windows.Forms.Button();
            this.ReservationBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.bestelling_gereedLbl = new System.Windows.Forms.Label();
            this.bestelling_gereedLv = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bestelling_in_behandelingLbl = new System.Windows.Forms.Label();
            this.LogOffLink = new System.Windows.Forms.Label();
            this.bestelling_pnl = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.tafels_lv = new System.Windows.Forms.ListView();
            this.Tafelnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bestelling2_pnl = new System.Windows.Forms.Panel();
            this.comment = new System.Windows.Forms.TextBox();
            this.orderItem_lv = new System.Windows.Forms.ListView();
            this.gerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.menu_lv = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alcohol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drankBtn = new System.Windows.Forms.Button();
            this.dinerBtn = new System.Windows.Forms.Button();
            this.lunchBtn = new System.Windows.Forms.Button();
            this.close2Btn = new System.Windows.Forms.Button();
            this.keuzeMenuLbl = new System.Windows.Forms.Label();
            this.Tafel1Btn = new System.Windows.Forms.Button();
            this.Tafel2Btn = new System.Windows.Forms.Button();
            this.Tafel3Btn = new System.Windows.Forms.Button();
            this.Tafel4Btn = new System.Windows.Forms.Button();
            this.Tafel5Btn = new System.Windows.Forms.Button();
            this.Tafel10Btn = new System.Windows.Forms.Button();
            this.Tafel9Btn = new System.Windows.Forms.Button();
            this.Tafel8Btn = new System.Windows.Forms.Button();
            this.Tafel7Btn = new System.Windows.Forms.Button();
            this.Tafel6Btn = new System.Windows.Forms.Button();
            this.Table_pnl.SuspendLayout();
            this.bestelling_pnl.SuspendLayout();
            this.bestelling2_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chapoo_title
            // 
            this.Chapoo_title.AutoSize = true;
            this.Chapoo_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapoo_title.ForeColor = System.Drawing.Color.White;
            this.Chapoo_title.Location = new System.Drawing.Point(21, 9);
            this.Chapoo_title.Name = "Chapoo_title";
            this.Chapoo_title.Size = new System.Drawing.Size(133, 15);
            this.Chapoo_title.TabIndex = 0;
            this.Chapoo_title.Text = "Chapoo | Bediening";
            // 
            // Table_pnl
            // 
            this.Table_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Table_pnl.Controls.Add(this.Tafel10Btn);
            this.Table_pnl.Controls.Add(this.Tafel9Btn);
            this.Table_pnl.Controls.Add(this.Tafel8Btn);
            this.Table_pnl.Controls.Add(this.Tafel7Btn);
            this.Table_pnl.Controls.Add(this.Tafel6Btn);
            this.Table_pnl.Controls.Add(this.Tafel5Btn);
            this.Table_pnl.Controls.Add(this.Tafel4Btn);
            this.Table_pnl.Controls.Add(this.Tafel3Btn);
            this.Table_pnl.Controls.Add(this.Tafel2Btn);
            this.Table_pnl.Controls.Add(this.Tafel1Btn);
            this.Table_pnl.Location = new System.Drawing.Point(24, 39);
            this.Table_pnl.Name = "Table_pnl";
            this.Table_pnl.Size = new System.Drawing.Size(529, 510);
            this.Table_pnl.TabIndex = 1;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.ForeColor = System.Drawing.Color.White;
            this.OrderBtn.Location = new System.Drawing.Point(595, 39);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(179, 48);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "BESTELLING OPNEMEN";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // OrderEditBtn
            // 
            this.OrderEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderEditBtn.Enabled = false;
            this.OrderEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderEditBtn.ForeColor = System.Drawing.Color.White;
            this.OrderEditBtn.Location = new System.Drawing.Point(595, 106);
            this.OrderEditBtn.Name = "OrderEditBtn";
            this.OrderEditBtn.Size = new System.Drawing.Size(179, 48);
            this.OrderEditBtn.TabIndex = 3;
            this.OrderEditBtn.Text = "BESTELLING AANPASSEN";
            this.OrderEditBtn.UseVisualStyleBackColor = false;
            // 
            // OrderDeleteBtn
            // 
            this.OrderDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderDeleteBtn.Enabled = false;
            this.OrderDeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.OrderDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.OrderDeleteBtn.Location = new System.Drawing.Point(595, 173);
            this.OrderDeleteBtn.Name = "OrderDeleteBtn";
            this.OrderDeleteBtn.Size = new System.Drawing.Size(179, 48);
            this.OrderDeleteBtn.TabIndex = 4;
            this.OrderDeleteBtn.Text = "BESTELLING VERWIJDEREN";
            this.OrderDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // ReservationBtn
            // 
            this.ReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.ReservationBtn.Enabled = false;
            this.ReservationBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.ReservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationBtn.ForeColor = System.Drawing.Color.White;
            this.ReservationBtn.Location = new System.Drawing.Point(595, 240);
            this.ReservationBtn.Name = "ReservationBtn";
            this.ReservationBtn.Size = new System.Drawing.Size(179, 48);
            this.ReservationBtn.TabIndex = 5;
            this.ReservationBtn.Text = "RESERVEREN";
            this.ReservationBtn.UseVisualStyleBackColor = false;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.PayBtn.Enabled = false;
            this.PayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(595, 309);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(179, 48);
            this.PayBtn.TabIndex = 6;
            this.PayBtn.Text = "AFREKENEN";
            this.PayBtn.UseVisualStyleBackColor = false;
            // 
            // bestelling_gereedLbl
            // 
            this.bestelling_gereedLbl.AutoSize = true;
            this.bestelling_gereedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestelling_gereedLbl.ForeColor = System.Drawing.Color.White;
            this.bestelling_gereedLbl.Location = new System.Drawing.Point(809, 37);
            this.bestelling_gereedLbl.Name = "bestelling_gereedLbl";
            this.bestelling_gereedLbl.Size = new System.Drawing.Size(152, 15);
            this.bestelling_gereedLbl.TabIndex = 7;
            this.bestelling_gereedLbl.Text = "BESTELLING GEREED";
            // 
            // bestelling_gereedLv
            // 
            this.bestelling_gereedLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.bestelling_gereedLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestelling_gereedLv.HideSelection = false;
            this.bestelling_gereedLv.Location = new System.Drawing.Point(812, 65);
            this.bestelling_gereedLv.Name = "bestelling_gereedLv";
            this.bestelling_gereedLv.Size = new System.Drawing.Size(399, 167);
            this.bestelling_gereedLv.TabIndex = 8;
            this.bestelling_gereedLv.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(812, 292);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 167);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bestelling_in_behandelingLbl
            // 
            this.bestelling_in_behandelingLbl.AutoSize = true;
            this.bestelling_in_behandelingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestelling_in_behandelingLbl.ForeColor = System.Drawing.Color.White;
            this.bestelling_in_behandelingLbl.Location = new System.Drawing.Point(809, 262);
            this.bestelling_in_behandelingLbl.Name = "bestelling_in_behandelingLbl";
            this.bestelling_in_behandelingLbl.Size = new System.Drawing.Size(210, 15);
            this.bestelling_in_behandelingLbl.TabIndex = 9;
            this.bestelling_in_behandelingLbl.Text = "BESTELLING IN BEHANDELING";
            // 
            // LogOffLink
            // 
            this.LogOffLink.AutoSize = true;
            this.LogOffLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffLink.ForeColor = System.Drawing.Color.Red;
            this.LogOffLink.Location = new System.Drawing.Point(1144, 9);
            this.LogOffLink.Name = "LogOffLink";
            this.LogOffLink.Size = new System.Drawing.Size(67, 15);
            this.LogOffLink.TabIndex = 11;
            this.LogOffLink.Text = "Afmelden";
            // 
            // bestelling_pnl
            // 
            this.bestelling_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.bestelling_pnl.Controls.Add(this.closeBtn);
            this.bestelling_pnl.Controls.Add(this.continueBtn);
            this.bestelling_pnl.Controls.Add(this.tafels_lv);
            this.bestelling_pnl.Location = new System.Drawing.Point(581, 106);
            this.bestelling_pnl.Name = "bestelling_pnl";
            this.bestelling_pnl.Size = new System.Drawing.Size(391, 422);
            this.bestelling_pnl.TabIndex = 15;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(3, 352);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(171, 48);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "AFSLUITEN";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.continueBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(180, 352);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(204, 48);
            this.continueBtn.TabIndex = 14;
            this.continueBtn.Text = "VERDER";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // tafels_lv
            // 
            this.tafels_lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.tafels_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tafels_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tafelnummer});
            this.tafels_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tafels_lv.ForeColor = System.Drawing.Color.White;
            this.tafels_lv.HideSelection = false;
            this.tafels_lv.Location = new System.Drawing.Point(3, 3);
            this.tafels_lv.Name = "tafels_lv";
            this.tafels_lv.Size = new System.Drawing.Size(381, 330);
            this.tafels_lv.TabIndex = 0;
            this.tafels_lv.UseCompatibleStateImageBehavior = false;
            this.tafels_lv.View = System.Windows.Forms.View.Details;
            // 
            // Tafelnummer
            // 
            this.Tafelnummer.Text = "Tafelnummer";
            this.Tafelnummer.Width = 158;
            // 
            // bestelling2_pnl
            // 
            this.bestelling2_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.bestelling2_pnl.Controls.Add(this.comment);
            this.bestelling2_pnl.Controls.Add(this.orderItem_lv);
            this.bestelling2_pnl.Controls.Add(this.SaveBtn);
            this.bestelling2_pnl.Controls.Add(this.amount);
            this.bestelling2_pnl.Controls.Add(this.menu_lv);
            this.bestelling2_pnl.Controls.Add(this.drankBtn);
            this.bestelling2_pnl.Controls.Add(this.dinerBtn);
            this.bestelling2_pnl.Controls.Add(this.lunchBtn);
            this.bestelling2_pnl.Controls.Add(this.close2Btn);
            this.bestelling2_pnl.Controls.Add(this.keuzeMenuLbl);
            this.bestelling2_pnl.Location = new System.Drawing.Point(24, 39);
            this.bestelling2_pnl.Name = "bestelling2_pnl";
            this.bestelling2_pnl.Size = new System.Drawing.Size(1187, 510);
            this.bestelling2_pnl.TabIndex = 16;
            // 
            // comment
            // 
            this.comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comment.ForeColor = System.Drawing.SystemColors.Window;
            this.comment.Location = new System.Drawing.Point(756, 295);
            this.comment.Margin = new System.Windows.Forms.Padding(6);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(422, 209);
            this.comment.TabIndex = 25;
            // 
            // orderItem_lv
            // 
            this.orderItem_lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.orderItem_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderItem_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gerecht,
            this.aantal});
            this.orderItem_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItem_lv.ForeColor = System.Drawing.Color.White;
            this.orderItem_lv.FullRowSelect = true;
            this.orderItem_lv.HideSelection = false;
            this.orderItem_lv.Location = new System.Drawing.Point(756, 54);
            this.orderItem_lv.Name = "orderItem_lv";
            this.orderItem_lv.Size = new System.Drawing.Size(422, 232);
            this.orderItem_lv.TabIndex = 24;
            this.orderItem_lv.UseCompatibleStateImageBehavior = false;
            this.orderItem_lv.View = System.Windows.Forms.View.Details;
            this.orderItem_lv.Visible = false;
            // 
            // gerecht
            // 
            this.gerecht.Text = "Gerecht";
            this.gerecht.Width = 333;
            // 
            // aantal
            // 
            this.aantal.Text = "Aantal";
            this.aantal.Width = 82;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(560, 102);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(190, 48);
            this.SaveBtn.TabIndex = 23;
            this.SaveBtn.Text = "BEVESTIG";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount.ForeColor = System.Drawing.SystemColors.Window;
            this.amount.Location = new System.Drawing.Point(560, 54);
            this.amount.Margin = new System.Windows.Forms.Padding(6);
            this.amount.Multiline = true;
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(187, 39);
            this.amount.TabIndex = 21;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // menu_lv
            // 
            this.menu_lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.menu_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menu_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.Price,
            this.Alcohol});
            this.menu_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_lv.ForeColor = System.Drawing.Color.White;
            this.menu_lv.FullRowSelect = true;
            this.menu_lv.HideSelection = false;
            this.menu_lv.Location = new System.Drawing.Point(3, 54);
            this.menu_lv.Name = "menu_lv";
            this.menu_lv.Size = new System.Drawing.Size(548, 453);
            this.menu_lv.TabIndex = 20;
            this.menu_lv.UseCompatibleStateImageBehavior = false;
            this.menu_lv.View = System.Windows.Forms.View.Details;
            this.menu_lv.Visible = false;
            // 
            // itemName
            // 
            this.itemName.Text = "Gerecht";
            this.itemName.Width = 400;
            // 
            // Price
            // 
            this.Price.Text = "Prijs";
            this.Price.Width = 68;
            // 
            // Alcohol
            // 
            this.Alcohol.Text = "Alcohol";
            this.Alcohol.Width = 76;
            // 
            // drankBtn
            // 
            this.drankBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.drankBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.drankBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drankBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drankBtn.ForeColor = System.Drawing.Color.White;
            this.drankBtn.Location = new System.Drawing.Point(382, 3);
            this.drankBtn.Name = "drankBtn";
            this.drankBtn.Size = new System.Drawing.Size(171, 48);
            this.drankBtn.TabIndex = 19;
            this.drankBtn.Text = "DRANKJES";
            this.drankBtn.UseVisualStyleBackColor = false;
            this.drankBtn.Click += new System.EventHandler(this.drankBtn_Click);
            // 
            // dinerBtn
            // 
            this.dinerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.dinerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.dinerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinerBtn.ForeColor = System.Drawing.Color.White;
            this.dinerBtn.Location = new System.Drawing.Point(192, 3);
            this.dinerBtn.Name = "dinerBtn";
            this.dinerBtn.Size = new System.Drawing.Size(171, 48);
            this.dinerBtn.TabIndex = 18;
            this.dinerBtn.Text = "DINER";
            this.dinerBtn.UseVisualStyleBackColor = false;
            this.dinerBtn.Click += new System.EventHandler(this.dinerBtn_Click);
            // 
            // lunchBtn
            // 
            this.lunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.lunchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.lunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunchBtn.ForeColor = System.Drawing.Color.White;
            this.lunchBtn.Location = new System.Drawing.Point(3, 3);
            this.lunchBtn.Name = "lunchBtn";
            this.lunchBtn.Size = new System.Drawing.Size(171, 48);
            this.lunchBtn.TabIndex = 17;
            this.lunchBtn.Text = "LUNCH";
            this.lunchBtn.UseVisualStyleBackColor = false;
            this.lunchBtn.Click += new System.EventHandler(this.lunchBtn_Click);
            // 
            // close2Btn
            // 
            this.close2Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close2Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.close2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2Btn.ForeColor = System.Drawing.Color.White;
            this.close2Btn.Location = new System.Drawing.Point(1013, 3);
            this.close2Btn.Name = "close2Btn";
            this.close2Btn.Size = new System.Drawing.Size(171, 48);
            this.close2Btn.TabIndex = 16;
            this.close2Btn.Text = "AFSLUITEN";
            this.close2Btn.UseVisualStyleBackColor = false;
            this.close2Btn.Click += new System.EventHandler(this.close2Btn_Click);
            // 
            // keuzeMenuLbl
            // 
            this.keuzeMenuLbl.AutoSize = true;
            this.keuzeMenuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keuzeMenuLbl.ForeColor = System.Drawing.Color.White;
            this.keuzeMenuLbl.Location = new System.Drawing.Point(4, 58);
            this.keuzeMenuLbl.Name = "keuzeMenuLbl";
            this.keuzeMenuLbl.Size = new System.Drawing.Size(138, 24);
            this.keuzeMenuLbl.TabIndex = 22;
            this.keuzeMenuLbl.Text = "Kies een menu";
            // 
            // Tafel1Btn
            // 
            this.Tafel1Btn.BackColor = System.Drawing.Color.White;
            this.Tafel1Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel1Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel1Btn.Location = new System.Drawing.Point(41, 26);
            this.Tafel1Btn.Name = "Tafel1Btn";
            this.Tafel1Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel1Btn.TabIndex = 17;
            this.Tafel1Btn.Text = "1";
            this.Tafel1Btn.UseVisualStyleBackColor = false;
            this.Tafel1Btn.Click += new System.EventHandler(this.Tafel1Btn_Click);
            // 
            // Tafel2Btn
            // 
            this.Tafel2Btn.BackColor = System.Drawing.Color.White;
            this.Tafel2Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel2Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel2Btn.Location = new System.Drawing.Point(41, 124);
            this.Tafel2Btn.Name = "Tafel2Btn";
            this.Tafel2Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel2Btn.TabIndex = 18;
            this.Tafel2Btn.Text = "2";
            this.Tafel2Btn.UseVisualStyleBackColor = false;
            this.Tafel2Btn.Click += new System.EventHandler(this.Tafel2Btn_Click);
            // 
            // Tafel3Btn
            // 
            this.Tafel3Btn.BackColor = System.Drawing.Color.White;
            this.Tafel3Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel3Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel3Btn.Location = new System.Drawing.Point(41, 223);
            this.Tafel3Btn.Name = "Tafel3Btn";
            this.Tafel3Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel3Btn.TabIndex = 19;
            this.Tafel3Btn.Text = "3";
            this.Tafel3Btn.UseVisualStyleBackColor = false;
            this.Tafel3Btn.Click += new System.EventHandler(this.Tafel3Btn_Click);
            // 
            // Tafel4Btn
            // 
            this.Tafel4Btn.BackColor = System.Drawing.Color.White;
            this.Tafel4Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel4Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel4Btn.Location = new System.Drawing.Point(41, 320);
            this.Tafel4Btn.Name = "Tafel4Btn";
            this.Tafel4Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel4Btn.TabIndex = 20;
            this.Tafel4Btn.Text = "4";
            this.Tafel4Btn.UseVisualStyleBackColor = false;
            this.Tafel4Btn.Click += new System.EventHandler(this.Tafel4Btn_Click);
            // 
            // Tafel5Btn
            // 
            this.Tafel5Btn.BackColor = System.Drawing.Color.White;
            this.Tafel5Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel5Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel5Btn.Location = new System.Drawing.Point(41, 419);
            this.Tafel5Btn.Name = "Tafel5Btn";
            this.Tafel5Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel5Btn.TabIndex = 21;
            this.Tafel5Btn.Text = "5";
            this.Tafel5Btn.UseVisualStyleBackColor = false;
            this.Tafel5Btn.Click += new System.EventHandler(this.Tafel5Btn_Click);
            // 
            // Tafel10Btn
            // 
            this.Tafel10Btn.BackColor = System.Drawing.Color.White;
            this.Tafel10Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel10Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel10Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel10Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel10Btn.Location = new System.Drawing.Point(305, 419);
            this.Tafel10Btn.Name = "Tafel10Btn";
            this.Tafel10Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel10Btn.TabIndex = 26;
            this.Tafel10Btn.Text = "10";
            this.Tafel10Btn.UseVisualStyleBackColor = false;
            this.Tafel10Btn.Click += new System.EventHandler(this.Tafel10Btn_Click);
            // 
            // Tafel9Btn
            // 
            this.Tafel9Btn.BackColor = System.Drawing.Color.White;
            this.Tafel9Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel9Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel9Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel9Btn.Location = new System.Drawing.Point(305, 320);
            this.Tafel9Btn.Name = "Tafel9Btn";
            this.Tafel9Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel9Btn.TabIndex = 25;
            this.Tafel9Btn.Text = "9";
            this.Tafel9Btn.UseVisualStyleBackColor = false;
            this.Tafel9Btn.Click += new System.EventHandler(this.Tafel9Btn_Click);
            // 
            // Tafel8Btn
            // 
            this.Tafel8Btn.BackColor = System.Drawing.Color.White;
            this.Tafel8Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel8Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel8Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel8Btn.Location = new System.Drawing.Point(305, 223);
            this.Tafel8Btn.Name = "Tafel8Btn";
            this.Tafel8Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel8Btn.TabIndex = 24;
            this.Tafel8Btn.Text = "8";
            this.Tafel8Btn.UseVisualStyleBackColor = false;
            this.Tafel8Btn.Click += new System.EventHandler(this.Tafel8Btn_Click);
            // 
            // Tafel7Btn
            // 
            this.Tafel7Btn.BackColor = System.Drawing.Color.White;
            this.Tafel7Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel7Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel7Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel7Btn.Location = new System.Drawing.Point(305, 124);
            this.Tafel7Btn.Name = "Tafel7Btn";
            this.Tafel7Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel7Btn.TabIndex = 23;
            this.Tafel7Btn.Text = "7";
            this.Tafel7Btn.UseVisualStyleBackColor = false;
            this.Tafel7Btn.Click += new System.EventHandler(this.Tafel7Btn_Click);
            // 
            // Tafel6Btn
            // 
            this.Tafel6Btn.BackColor = System.Drawing.Color.White;
            this.Tafel6Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.Tafel6Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tafel6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tafel6Btn.ForeColor = System.Drawing.Color.Black;
            this.Tafel6Btn.Location = new System.Drawing.Point(305, 26);
            this.Tafel6Btn.Name = "Tafel6Btn";
            this.Tafel6Btn.Size = new System.Drawing.Size(89, 69);
            this.Tafel6Btn.TabIndex = 22;
            this.Tafel6Btn.Text = "6";
            this.Tafel6Btn.UseVisualStyleBackColor = false;
            this.Tafel6Btn.Click += new System.EventHandler(this.Tafel6Btn_Click);
            // 
            // BedieningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1241, 561);
            this.Controls.Add(this.bestelling2_pnl);
            this.Controls.Add(this.bestelling_pnl);
            this.Controls.Add(this.LogOffLink);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bestelling_in_behandelingLbl);
            this.Controls.Add(this.bestelling_gereedLv);
            this.Controls.Add(this.bestelling_gereedLbl);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.ReservationBtn);
            this.Controls.Add(this.OrderDeleteBtn);
            this.Controls.Add(this.OrderEditBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.Table_pnl);
            this.Controls.Add(this.Chapoo_title);
            this.Name = "BedieningForm";
            this.Text = "BedieningForm";
            this.Table_pnl.ResumeLayout(false);
            this.bestelling_pnl.ResumeLayout(false);
            this.bestelling2_pnl.ResumeLayout(false);
            this.bestelling2_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chapoo_title;
        private System.Windows.Forms.Panel Table_pnl;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button OrderEditBtn;
        private System.Windows.Forms.Button OrderDeleteBtn;
        private System.Windows.Forms.Button ReservationBtn;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Label bestelling_gereedLbl;
        private System.Windows.Forms.ListView bestelling_gereedLv;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label bestelling_in_behandelingLbl;
        private System.Windows.Forms.Label LogOffLink;
        private System.Windows.Forms.Panel bestelling_pnl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.ListView tafels_lv;
        private System.Windows.Forms.ColumnHeader Tafelnummer;
        private System.Windows.Forms.Panel bestelling2_pnl;
        private System.Windows.Forms.Button close2Btn;
        private System.Windows.Forms.ListView menu_lv;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button drankBtn;
        private System.Windows.Forms.Button dinerBtn;
        private System.Windows.Forms.Button lunchBtn;
        private System.Windows.Forms.ColumnHeader Alcohol;
        public System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label keuzeMenuLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListView orderItem_lv;
        private System.Windows.Forms.ColumnHeader gerecht;
        private System.Windows.Forms.ColumnHeader aantal;
        public System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button Tafel10Btn;
        private System.Windows.Forms.Button Tafel9Btn;
        private System.Windows.Forms.Button Tafel8Btn;
        private System.Windows.Forms.Button Tafel7Btn;
        private System.Windows.Forms.Button Tafel6Btn;
        private System.Windows.Forms.Button Tafel5Btn;
        private System.Windows.Forms.Button Tafel4Btn;
        private System.Windows.Forms.Button Tafel3Btn;
        private System.Windows.Forms.Button Tafel2Btn;
        private System.Windows.Forms.Button Tafel1Btn;
    }
}