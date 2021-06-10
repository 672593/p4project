
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.RefreshImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.columnHeader5});
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
            this.RefreshImg.Location = new System.Drawing.Point(468, 84);
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
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1241, 561);
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
    }
}