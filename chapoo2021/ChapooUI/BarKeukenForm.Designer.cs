
namespace ChapooUI
{
    partial class BarKeukenForm
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
            this.ingekomen_bestellingenLbl = new System.Windows.Forms.Label();
            this.btn_Gereed_Bestelling_Bestelling = new System.Windows.Forms.Button();
            this.RefreshStockBtn = new System.Windows.Forms.Button();
            this.opmerkingLbl = new System.Windows.Forms.Label();
            this.bestelling_gereedLv = new System.Windows.Forms.ListView();
            this.tb_ID_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Tafell_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Naam_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Aantal_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Tijd_keuken_bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Bestelling_Wijzig = new System.Windows.Forms.Panel();
            this.label_tijd_bestelling = new System.Windows.Forms.Label();
            this.label_aantal_bestelling = new System.Windows.Forms.Label();
            this.label_tafelnummer_bestelling = new System.Windows.Forms.Label();
            this.label_id_bestelling = new System.Windows.Forms.Label();
            this.label_naam_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_Vraag_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_Name_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_Aantal_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_Tijd_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_Tafel_bestelling = new System.Windows.Forms.Label();
            this.tb_pnl_ID_bestelling = new System.Windows.Forms.Label();
            this.btn_Bestelling_Wijzig_Cancel = new System.Windows.Forms.Button();
            this.btn_Bestelling_Wijzig_Accept = new System.Windows.Forms.Button();
            this.pbAdminLogoSmall = new System.Windows.Forms.PictureBox();
            this.tb_opmerking_keukenBar = new System.Windows.Forms.TextBox();
            this.ms_filter_KeukenBar = new System.Windows.Forms.MenuStrip();
            this.ts_menuItem_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_MenuItem_Openstaand = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menuItem_Gereed = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_filter_text = new System.Windows.Forms.Label();
            this.pnl_Bestelling_Wijzig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminLogoSmall)).BeginInit();
            this.ms_filter_KeukenBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOffLink
            // 
            this.LogOffLink.AutoSize = true;
            this.LogOffLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffLink.ForeColor = System.Drawing.Color.Red;
            this.LogOffLink.Location = new System.Drawing.Point(905, 9);
            this.LogOffLink.Name = "LogOffLink";
            this.LogOffLink.Size = new System.Drawing.Size(69, 15);
            this.LogOffLink.TabIndex = 13;
            this.LogOffLink.Text = "Uitloggen";
            this.LogOffLink.Click += new System.EventHandler(this.LogOffLink_Click);
            // 
            // Chapoo_title
            // 
            this.Chapoo_title.AutoSize = true;
            this.Chapoo_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chapoo_title.ForeColor = System.Drawing.Color.White;
            this.Chapoo_title.Location = new System.Drawing.Point(98, 21);
            this.Chapoo_title.Name = "Chapoo_title";
            this.Chapoo_title.Size = new System.Drawing.Size(65, 15);
            this.Chapoo_title.TabIndex = 12;
            this.Chapoo_title.Text = "| Barman";
            // 
            // ingekomen_bestellingenLbl
            // 
            this.ingekomen_bestellingenLbl.AutoSize = true;
            this.ingekomen_bestellingenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ingekomen_bestellingenLbl.ForeColor = System.Drawing.Color.White;
            this.ingekomen_bestellingenLbl.Location = new System.Drawing.Point(12, 57);
            this.ingekomen_bestellingenLbl.Name = "ingekomen_bestellingenLbl";
            this.ingekomen_bestellingenLbl.Size = new System.Drawing.Size(254, 20);
            this.ingekomen_bestellingenLbl.TabIndex = 14;
            this.ingekomen_bestellingenLbl.Text = "INGEKOMEN BESTELLINGEN";
            // 
            // btn_Gereed_Bestelling_Bestelling
            // 
            this.btn_Gereed_Bestelling_Bestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btn_Gereed_Bestelling_Bestelling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.btn_Gereed_Bestelling_Bestelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gereed_Bestelling_Bestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gereed_Bestelling_Bestelling.ForeColor = System.Drawing.Color.White;
            this.btn_Gereed_Bestelling_Bestelling.Location = new System.Drawing.Point(756, 476);
            this.btn_Gereed_Bestelling_Bestelling.Name = "btn_Gereed_Bestelling_Bestelling";
            this.btn_Gereed_Bestelling_Bestelling.Size = new System.Drawing.Size(179, 48);
            this.btn_Gereed_Bestelling_Bestelling.TabIndex = 18;
            this.btn_Gereed_Bestelling_Bestelling.Text = "GEREED BESTELLING";
            this.btn_Gereed_Bestelling_Bestelling.UseVisualStyleBackColor = false;
            this.btn_Gereed_Bestelling_Bestelling.Click += new System.EventHandler(this.btn_Gereed_Bestelling_Bar_Click);
            // 
            // RefreshStockBtn
            // 
            this.RefreshStockBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshStockBtn.BackgroundImage = global::ChapooUI.Properties.Resources.refresh2;
            this.RefreshStockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshStockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.RefreshStockBtn.FlatAppearance.BorderSize = 3;
            this.RefreshStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshStockBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshStockBtn.Location = new System.Drawing.Point(272, 64);
            this.RefreshStockBtn.Name = "RefreshStockBtn";
            this.RefreshStockBtn.Size = new System.Drawing.Size(68, 60);
            this.RefreshStockBtn.TabIndex = 23;
            this.RefreshStockBtn.UseVisualStyleBackColor = false;
            this.RefreshStockBtn.Click += new System.EventHandler(this.RefreshStockBtn_Click);
            // 
            // opmerkingLbl
            // 
            this.opmerkingLbl.AutoSize = true;
            this.opmerkingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.opmerkingLbl.ForeColor = System.Drawing.Color.White;
            this.opmerkingLbl.Location = new System.Drawing.Point(708, 88);
            this.opmerkingLbl.Name = "opmerkingLbl";
            this.opmerkingLbl.Size = new System.Drawing.Size(109, 18);
            this.opmerkingLbl.TabIndex = 21;
            this.opmerkingLbl.Text = "OPMERKING";
            // 
            // bestelling_gereedLv
            // 
            this.bestelling_gereedLv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.bestelling_gereedLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.bestelling_gereedLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tb_ID_keuken_bestelling,
            this.tb_Tafell_keuken_bestelling,
            this.tb_Naam_keuken_bestelling,
            this.tb_Aantal_keuken_bestelling,
            this.tb_Tijd_keuken_bestelling});
            this.bestelling_gereedLv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bestelling_gereedLv.ForeColor = System.Drawing.Color.GhostWhite;
            this.bestelling_gereedLv.FullRowSelect = true;
            this.bestelling_gereedLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bestelling_gereedLv.HideSelection = false;
            this.bestelling_gereedLv.HoverSelection = true;
            this.bestelling_gereedLv.Location = new System.Drawing.Point(16, 129);
            this.bestelling_gereedLv.Name = "bestelling_gereedLv";
            this.bestelling_gereedLv.Size = new System.Drawing.Size(689, 404);
            this.bestelling_gereedLv.TabIndex = 25;
            this.bestelling_gereedLv.UseCompatibleStateImageBehavior = false;
            this.bestelling_gereedLv.View = System.Windows.Forms.View.Details;
            // 
            // tb_ID_keuken_bestelling
            // 
            this.tb_ID_keuken_bestelling.Text = "ID";
            this.tb_ID_keuken_bestelling.Width = 45;
            // 
            // tb_Tafell_keuken_bestelling
            // 
            this.tb_Tafell_keuken_bestelling.Text = "Tafelnummer";
            this.tb_Tafell_keuken_bestelling.Width = 99;
            // 
            // tb_Naam_keuken_bestelling
            // 
            this.tb_Naam_keuken_bestelling.Text = "Bestelling";
            this.tb_Naam_keuken_bestelling.Width = 316;
            // 
            // tb_Aantal_keuken_bestelling
            // 
            this.tb_Aantal_keuken_bestelling.Text = "Aantal";
            this.tb_Aantal_keuken_bestelling.Width = 71;
            // 
            // tb_Tijd_keuken_bestelling
            // 
            this.tb_Tijd_keuken_bestelling.Text = "Tijd";
            this.tb_Tijd_keuken_bestelling.Width = 151;
            // 
            // pnl_Bestelling_Wijzig
            // 
            this.pnl_Bestelling_Wijzig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Bestelling_Wijzig.Controls.Add(this.label_tijd_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.label_aantal_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.label_tafelnummer_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.label_id_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.label_naam_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Vraag_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Name_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Aantal_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Tijd_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_Tafel_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.tb_pnl_ID_bestelling);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.btn_Bestelling_Wijzig_Cancel);
            this.pnl_Bestelling_Wijzig.Controls.Add(this.btn_Bestelling_Wijzig_Accept);
            this.pnl_Bestelling_Wijzig.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnl_Bestelling_Wijzig.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.pnl_Bestelling_Wijzig.Location = new System.Drawing.Point(182, 109);
            this.pnl_Bestelling_Wijzig.Name = "pnl_Bestelling_Wijzig";
            this.pnl_Bestelling_Wijzig.Size = new System.Drawing.Size(780, 334);
            this.pnl_Bestelling_Wijzig.TabIndex = 28;
            this.pnl_Bestelling_Wijzig.Visible = false;
            // 
            // label_tijd_bestelling
            // 
            this.label_tijd_bestelling.AutoSize = true;
            this.label_tijd_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_tijd_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_tijd_bestelling.Location = new System.Drawing.Point(558, 42);
            this.label_tijd_bestelling.Name = "label_tijd_bestelling";
            this.label_tijd_bestelling.Size = new System.Drawing.Size(46, 21);
            this.label_tijd_bestelling.TabIndex = 18;
            this.label_tijd_bestelling.Text = "Tijd : ";
            // 
            // label_aantal_bestelling
            // 
            this.label_aantal_bestelling.AutoSize = true;
            this.label_aantal_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_aantal_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_aantal_bestelling.Location = new System.Drawing.Point(569, 95);
            this.label_aantal_bestelling.Name = "label_aantal_bestelling";
            this.label_aantal_bestelling.Size = new System.Drawing.Size(65, 21);
            this.label_aantal_bestelling.TabIndex = 17;
            this.label_aantal_bestelling.Text = "Aantal : ";
            // 
            // label_tafelnummer_bestelling
            // 
            this.label_tafelnummer_bestelling.AutoSize = true;
            this.label_tafelnummer_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_tafelnummer_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_tafelnummer_bestelling.Location = new System.Drawing.Point(262, 42);
            this.label_tafelnummer_bestelling.Name = "label_tafelnummer_bestelling";
            this.label_tafelnummer_bestelling.Size = new System.Drawing.Size(112, 21);
            this.label_tafelnummer_bestelling.TabIndex = 16;
            this.label_tafelnummer_bestelling.Text = "Tafelnummer : ";
            // 
            // label_id_bestelling
            // 
            this.label_id_bestelling.AutoSize = true;
            this.label_id_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_id_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_id_bestelling.Location = new System.Drawing.Point(129, 42);
            this.label_id_bestelling.Name = "label_id_bestelling";
            this.label_id_bestelling.Size = new System.Drawing.Size(36, 21);
            this.label_id_bestelling.TabIndex = 15;
            this.label_id_bestelling.Text = "ID : ";
            // 
            // label_naam_bestelling
            // 
            this.label_naam_bestelling.AutoSize = true;
            this.label_naam_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_naam_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_naam_bestelling.Location = new System.Drawing.Point(24, 130);
            this.label_naam_bestelling.Name = "label_naam_bestelling";
            this.label_naam_bestelling.Size = new System.Drawing.Size(130, 21);
            this.label_naam_bestelling.TabIndex = 14;
            this.label_naam_bestelling.Text = "Bestelling Naam :";
            // 
            // tb_pnl_Vraag_bestelling
            // 
            this.tb_pnl_Vraag_bestelling.AutoSize = true;
            this.tb_pnl_Vraag_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_Vraag_bestelling.Location = new System.Drawing.Point(16, 10);
            this.tb_pnl_Vraag_bestelling.Name = "tb_pnl_Vraag_bestelling";
            this.tb_pnl_Vraag_bestelling.Size = new System.Drawing.Size(268, 21);
            this.tb_pnl_Vraag_bestelling.TabIndex = 13;
            this.tb_pnl_Vraag_bestelling.Text = "Wilt u deze bestelling gereed maken?";
            // 
            // tb_pnl_Name_bestelling
            // 
            this.tb_pnl_Name_bestelling.AutoSize = true;
            this.tb_pnl_Name_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_Name_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_pnl_Name_bestelling.Location = new System.Drawing.Point(161, 130);
            this.tb_pnl_Name_bestelling.Name = "tb_pnl_Name_bestelling";
            this.tb_pnl_Name_bestelling.Size = new System.Drawing.Size(123, 21);
            this.tb_pnl_Name_bestelling.TabIndex = 11;
            this.tb_pnl_Name_bestelling.Text = "Bestelling Naam";
            // 
            // tb_pnl_Aantal_bestelling
            // 
            this.tb_pnl_Aantal_bestelling.AutoSize = true;
            this.tb_pnl_Aantal_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_Aantal_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_pnl_Aantal_bestelling.Location = new System.Drawing.Point(640, 95);
            this.tb_pnl_Aantal_bestelling.Name = "tb_pnl_Aantal_bestelling";
            this.tb_pnl_Aantal_bestelling.Size = new System.Drawing.Size(54, 21);
            this.tb_pnl_Aantal_bestelling.TabIndex = 9;
            this.tb_pnl_Aantal_bestelling.Text = "Aantal";
            // 
            // tb_pnl_Tijd_bestelling
            // 
            this.tb_pnl_Tijd_bestelling.AutoSize = true;
            this.tb_pnl_Tijd_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_Tijd_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_pnl_Tijd_bestelling.Location = new System.Drawing.Point(603, 42);
            this.tb_pnl_Tijd_bestelling.Name = "tb_pnl_Tijd_bestelling";
            this.tb_pnl_Tijd_bestelling.Size = new System.Drawing.Size(35, 21);
            this.tb_pnl_Tijd_bestelling.TabIndex = 8;
            this.tb_pnl_Tijd_bestelling.Text = "Tijd";
            // 
            // tb_pnl_Tafel_bestelling
            // 
            this.tb_pnl_Tafel_bestelling.AutoSize = true;
            this.tb_pnl_Tafel_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_Tafel_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_pnl_Tafel_bestelling.Location = new System.Drawing.Point(378, 42);
            this.tb_pnl_Tafel_bestelling.Name = "tb_pnl_Tafel_bestelling";
            this.tb_pnl_Tafel_bestelling.Size = new System.Drawing.Size(101, 21);
            this.tb_pnl_Tafel_bestelling.TabIndex = 7;
            this.tb_pnl_Tafel_bestelling.Text = "Tafelnummer";
            // 
            // tb_pnl_ID_bestelling
            // 
            this.tb_pnl_ID_bestelling.AutoSize = true;
            this.tb_pnl_ID_bestelling.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_pnl_ID_bestelling.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tb_pnl_ID_bestelling.Location = new System.Drawing.Point(176, 42);
            this.tb_pnl_ID_bestelling.Name = "tb_pnl_ID_bestelling";
            this.tb_pnl_ID_bestelling.Size = new System.Drawing.Size(25, 21);
            this.tb_pnl_ID_bestelling.TabIndex = 6;
            this.tb_pnl_ID_bestelling.Text = "ID";
            // 
            // btn_Bestelling_Wijzig_Cancel
            // 
            this.btn_Bestelling_Wijzig_Cancel.BackColor = System.Drawing.Color.Brown;
            this.btn_Bestelling_Wijzig_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bestelling_Wijzig_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Bestelling_Wijzig_Cancel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Bestelling_Wijzig_Cancel.Location = new System.Drawing.Point(421, 262);
            this.btn_Bestelling_Wijzig_Cancel.Name = "btn_Bestelling_Wijzig_Cancel";
            this.btn_Bestelling_Wijzig_Cancel.Size = new System.Drawing.Size(150, 32);
            this.btn_Bestelling_Wijzig_Cancel.TabIndex = 5;
            this.btn_Bestelling_Wijzig_Cancel.Text = "Cancel";
            this.btn_Bestelling_Wijzig_Cancel.UseVisualStyleBackColor = false;
            this.btn_Bestelling_Wijzig_Cancel.Click += new System.EventHandler(this.btn_Bar_Wijzig_Cancel_Click);
            // 
            // btn_Bestelling_Wijzig_Accept
            // 
            this.btn_Bestelling_Wijzig_Accept.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Bestelling_Wijzig_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bestelling_Wijzig_Accept.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Bestelling_Wijzig_Accept.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Bestelling_Wijzig_Accept.Location = new System.Drawing.Point(197, 262);
            this.btn_Bestelling_Wijzig_Accept.Name = "btn_Bestelling_Wijzig_Accept";
            this.btn_Bestelling_Wijzig_Accept.Size = new System.Drawing.Size(150, 32);
            this.btn_Bestelling_Wijzig_Accept.TabIndex = 4;
            this.btn_Bestelling_Wijzig_Accept.Text = "Gereed";
            this.btn_Bestelling_Wijzig_Accept.UseVisualStyleBackColor = false;
            this.btn_Bestelling_Wijzig_Accept.Click += new System.EventHandler(this.btn_Bar_Wijzig_Accept_Click);
            // 
            // pbAdminLogoSmall
            // 
            this.pbAdminLogoSmall.BackgroundImage = global::ChapooUI.Properties.Resources.png_logo_white;
            this.pbAdminLogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdminLogoSmall.Location = new System.Drawing.Point(12, 9);
            this.pbAdminLogoSmall.Margin = new System.Windows.Forms.Padding(2);
            this.pbAdminLogoSmall.Name = "pbAdminLogoSmall";
            this.pbAdminLogoSmall.Size = new System.Drawing.Size(81, 39);
            this.pbAdminLogoSmall.TabIndex = 29;
            this.pbAdminLogoSmall.TabStop = false;
            // 
            // tb_opmerking_keukenBar
            // 
            this.tb_opmerking_keukenBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.tb_opmerking_keukenBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_opmerking_keukenBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_opmerking_keukenBar.Enabled = false;
            this.tb_opmerking_keukenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tb_opmerking_keukenBar.ForeColor = System.Drawing.Color.Snow;
            this.tb_opmerking_keukenBar.Location = new System.Drawing.Point(711, 129);
            this.tb_opmerking_keukenBar.Multiline = true;
            this.tb_opmerking_keukenBar.Name = "tb_opmerking_keukenBar";
            this.tb_opmerking_keukenBar.Size = new System.Drawing.Size(285, 331);
            this.tb_opmerking_keukenBar.TabIndex = 31;
            this.tb_opmerking_keukenBar.Text = "Opmerking";
            // 
            // ms_filter_KeukenBar
            // 
            this.ms_filter_KeukenBar.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_filter_KeukenBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ms_filter_KeukenBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ms_filter_KeukenBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menuItem_Filter});
            this.ms_filter_KeukenBar.Location = new System.Drawing.Point(89, 96);
            this.ms_filter_KeukenBar.Name = "ms_filter_KeukenBar";
            this.ms_filter_KeukenBar.Size = new System.Drawing.Size(62, 28);
            this.ms_filter_KeukenBar.TabIndex = 32;
            this.ms_filter_KeukenBar.Text = "Filter";
            // 
            // ts_menuItem_Filter
            // 
            this.ts_menuItem_Filter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_MenuItem_Openstaand,
            this.ts_menuItem_Gereed});
            this.ts_menuItem_Filter.Name = "ts_menuItem_Filter";
            this.ts_menuItem_Filter.Size = new System.Drawing.Size(54, 24);
            this.ts_menuItem_Filter.Text = "Filter";
            // 
            // ts_MenuItem_Openstaand
            // 
            this.ts_MenuItem_Openstaand.Name = "ts_MenuItem_Openstaand";
            this.ts_MenuItem_Openstaand.Size = new System.Drawing.Size(180, 24);
            this.ts_MenuItem_Openstaand.Text = "Openstaand";
            this.ts_MenuItem_Openstaand.Click += new System.EventHandler(this.openstaandToolStripMenuItem_Click);
            // 
            // ts_menuItem_Gereed
            // 
            this.ts_menuItem_Gereed.Name = "ts_menuItem_Gereed";
            this.ts_menuItem_Gereed.Size = new System.Drawing.Size(180, 24);
            this.ts_menuItem_Gereed.Text = "Gereed";
            this.ts_menuItem_Gereed.Click += new System.EventHandler(this.gereedToolStripMenuItem_Click);
            // 
            // lbl_filter_text
            // 
            this.lbl_filter_text.AutoSize = true;
            this.lbl_filter_text.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_filter_text.Location = new System.Drawing.Point(12, 99);
            this.lbl_filter_text.Name = "lbl_filter_text";
            this.lbl_filter_text.Size = new System.Drawing.Size(66, 21);
            this.lbl_filter_text.TabIndex = 33;
            this.lbl_filter_text.Text = "FILTER : ";
            // 
            // BarKeukenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.lbl_filter_text);
            this.Controls.Add(this.pbAdminLogoSmall);
            this.Controls.Add(this.pnl_Bestelling_Wijzig);
            this.Controls.Add(this.bestelling_gereedLv);
            this.Controls.Add(this.opmerkingLbl);
            this.Controls.Add(this.tb_opmerking_keukenBar);
            this.Controls.Add(this.RefreshStockBtn);
            this.Controls.Add(this.btn_Gereed_Bestelling_Bestelling);
            this.Controls.Add(this.ingekomen_bestellingenLbl);
            this.Controls.Add(this.LogOffLink);
            this.Controls.Add(this.Chapoo_title);
            this.Controls.Add(this.ms_filter_KeukenBar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.ms_filter_KeukenBar;
            this.Name = "BarKeukenForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarForm";
            this.pnl_Bestelling_Wijzig.ResumeLayout(false);
            this.pnl_Bestelling_Wijzig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminLogoSmall)).EndInit();
            this.ms_filter_KeukenBar.ResumeLayout(false);
            this.ms_filter_KeukenBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogOffLink;
        private System.Windows.Forms.Label Chapoo_title;
        private System.Windows.Forms.Label ingekomen_bestellingenLbl;
        private System.Windows.Forms.Button btn_Gereed_Bestelling_Bestelling;
        private System.Windows.Forms.Button RefreshStockBtn;
        private System.Windows.Forms.Label opmerkingLbl;
        private System.Windows.Forms.ListView bestelling_gereedLv;
        private System.Windows.Forms.ColumnHeader tb_ID_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Tafell_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Naam_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Aantal_keuken_bestelling;
        private System.Windows.Forms.ColumnHeader tb_Tijd_keuken_bestelling;
        private System.Windows.Forms.Panel pnl_Bestelling_Wijzig;
        private System.Windows.Forms.Label tb_pnl_Name_bestelling;
        private System.Windows.Forms.Label tb_pnl_Aantal_bestelling;
        private System.Windows.Forms.Label tb_pnl_Tijd_bestelling;
        private System.Windows.Forms.Label tb_pnl_Tafel_bestelling;
        private System.Windows.Forms.Label tb_pnl_ID_bestelling;
        private System.Windows.Forms.Button btn_Bestelling_Wijzig_Cancel;
        private System.Windows.Forms.Button btn_Bestelling_Wijzig_Accept;
        private System.Windows.Forms.PictureBox pbAdminLogoSmall;
        private System.Windows.Forms.Label tb_pnl_Vraag_bestelling;
        private System.Windows.Forms.Label label_tijd_bestelling;
        private System.Windows.Forms.Label label_aantal_bestelling;
        private System.Windows.Forms.Label label_tafelnummer_bestelling;
        private System.Windows.Forms.Label label_id_bestelling;
        private System.Windows.Forms.Label label_naam_bestelling;
        private System.Windows.Forms.TextBox tb_opmerking_keukenBar;
        private System.Windows.Forms.MenuStrip ms_filter_KeukenBar;
        private System.Windows.Forms.ToolStripMenuItem ts_menuItem_Filter;
        private System.Windows.Forms.ToolStripMenuItem ts_MenuItem_Openstaand;
        private System.Windows.Forms.ToolStripMenuItem ts_menuItem_Gereed;
        private System.Windows.Forms.Label lbl_filter_text;
    }
}