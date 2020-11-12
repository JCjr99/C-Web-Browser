namespace Web_Browser
{
    partial class WebBrowser
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
            this.components = new System.ComponentModel.Container();
            this.HTMLDisplay = new System.Windows.Forms.TextBox();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.NewURLAccepter = new System.Windows.Forms.Button();
            this.HistoryTree = new System.Windows.Forms.TreeView();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeChangeText = new System.Windows.Forms.ToolStripTextBox();
            this.confirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteName = new System.Windows.Forms.ToolStripTextBox();
            this.uRLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouriteURL = new System.Windows.Forms.ToolStripTextBox();
            this.confirmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFavourites = new System.Windows.Forms.ToolStripMenuItem();
            this.FavouriteLabel = new System.Windows.Forms.TextBox();
            this.favouritesDataGrid = new System.Windows.Forms.DataGridView();
            this.FavouritesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavouritesURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favouritesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HTMLDisplay
            // 
            this.HTMLDisplay.Location = new System.Drawing.Point(12, 107);
            this.HTMLDisplay.Multiline = true;
            this.HTMLDisplay.Name = "HTMLDisplay";
            this.HTMLDisplay.ReadOnly = true;
            this.HTMLDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HTMLDisplay.Size = new System.Drawing.Size(1320, 851);
            this.HTMLDisplay.TabIndex = 9;
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(195, 4);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(259, 20);
            this.URLTextBox.TabIndex = 12;
            // 
            // NewURLAccepter
            // 
            this.NewURLAccepter.Location = new System.Drawing.Point(460, 3);
            this.NewURLAccepter.Name = "NewURLAccepter";
            this.NewURLAccepter.Size = new System.Drawing.Size(38, 21);
            this.NewURLAccepter.TabIndex = 13;
            this.NewURLAccepter.Text = "GO";
            this.NewURLAccepter.UseVisualStyleBackColor = true;
            this.NewURLAccepter.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryTree
            // 
            this.HistoryTree.Location = new System.Drawing.Point(133, 27);
            this.HistoryTree.Name = "HistoryTree";
            this.HistoryTree.Size = new System.Drawing.Size(205, 252);
            this.HistoryTree.TabIndex = 24;
            this.HistoryTree.Visible = false;
            this.HistoryTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HistoryTree_MouseDoubleClick_1);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(52, 27);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(55, 23);
            this.ForwardButton.TabIndex = 26;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(0, 27);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 23);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.FavouritesToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1809, 24);
            this.MenuBar.TabIndex = 30;
            this.MenuBar.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeHomeToolStripMenuItem,
            this.goHomeToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // changeHomeToolStripMenuItem
            // 
            this.changeHomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeChangeText,
            this.confirmToolStripMenuItem});
            this.changeHomeToolStripMenuItem.Name = "changeHomeToolStripMenuItem";
            this.changeHomeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changeHomeToolStripMenuItem.Text = "Change Home";
            this.changeHomeToolStripMenuItem.Click += new System.EventHandler(this.changeHomeToolStripMenuItem_Click);
            // 
            // HomeChangeText
            // 
            this.HomeChangeText.Name = "HomeChangeText";
            this.HomeChangeText.Size = new System.Drawing.Size(100, 23);
            // 
            // confirmToolStripMenuItem
            // 
            this.confirmToolStripMenuItem.Name = "confirmToolStripMenuItem";
            this.confirmToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.confirmToolStripMenuItem.Text = "Confirm";
            this.confirmToolStripMenuItem.Click += new System.EventHandler(this.confirmToolStripMenuItem_Click);
            // 
            // goHomeToolStripMenuItem
            // 
            this.goHomeToolStripMenuItem.Name = "goHomeToolStripMenuItem";
            this.goHomeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.goHomeToolStripMenuItem.Text = "Go Home";
            this.goHomeToolStripMenuItem.Click += new System.EventHandler(this.goHomeToolStripMenuItem_Click);
            // 
            // FavouritesToolStripMenuItem
            // 
            this.FavouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.FavouritesToolStripMenuItem.Name = "FavouritesToolStripMenuItem";
            this.FavouritesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.FavouritesToolStripMenuItem.Text = "Favourites";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.favouriteName,
            this.uRLToolStripMenuItem,
            this.favouriteURL,
            this.confirmToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // favouriteName
            // 
            this.favouriteName.Name = "favouriteName";
            this.favouriteName.Size = new System.Drawing.Size(100, 23);
            // 
            // uRLToolStripMenuItem
            // 
            this.uRLToolStripMenuItem.Name = "uRLToolStripMenuItem";
            this.uRLToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.uRLToolStripMenuItem.Text = "URL";
            // 
            // favouriteURL
            // 
            this.favouriteURL.Name = "favouriteURL";
            this.favouriteURL.Size = new System.Drawing.Size(100, 23);
            // 
            // confirmToolStripMenuItem1
            // 
            this.confirmToolStripMenuItem1.Name = "confirmToolStripMenuItem1";
            this.confirmToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.confirmToolStripMenuItem1.Text = "Confirm";
            this.confirmToolStripMenuItem1.Click += new System.EventHandler(this.confirmToolStripMenuItem1_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.Location = new System.Drawing.Point(12, 81);
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.Size = new System.Drawing.Size(115, 20);
            this.StatusDisplay.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFavourites});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteFavourites
            // 
            this.deleteFavourites.Name = "deleteFavourites";
            this.deleteFavourites.Size = new System.Drawing.Size(107, 22);
            this.deleteFavourites.Text = "Delete";
            this.deleteFavourites.Click += new System.EventHandler(this.deleteFavourites_Click);
            // 
            // FavouriteLabel
            // 
            this.FavouriteLabel.Location = new System.Drawing.Point(1338, 81);
            this.FavouriteLabel.Name = "FavouriteLabel";
            this.FavouriteLabel.ReadOnly = true;
            this.FavouriteLabel.Size = new System.Drawing.Size(100, 20);
            this.FavouriteLabel.TabIndex = 35;
            this.FavouriteLabel.Text = "Favourites";
            // 
            // favouritesDataGrid
            // 
            this.favouritesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favouritesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FavouritesName,
            this.FavouritesURL});
            this.favouritesDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.favouritesDataGrid.Location = new System.Drawing.Point(1338, 107);
            this.favouritesDataGrid.Name = "favouritesDataGrid";
            this.favouritesDataGrid.Size = new System.Drawing.Size(297, 773);
            this.favouritesDataGrid.TabIndex = 37;
            this.favouritesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.favouritesDataGrid_CellContentClick);
            // 
            // FavouritesName
            // 
            this.FavouritesName.HeaderText = "Name";
            this.FavouritesName.Name = "FavouritesName";
            // 
            // FavouritesURL
            // 
            this.FavouritesURL.HeaderText = "URL";
            this.FavouritesURL.Name = "FavouritesURL";
            this.FavouritesURL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FavouritesURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(460, 57);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(380, 20);
            this.TitleText.TabIndex = 39;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(504, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 40;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1809, 970);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.HistoryTree);
            this.Controls.Add(this.favouritesDataGrid);
            this.Controls.Add(this.NewURLAccepter);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.HTMLDisplay);
            this.Controls.Add(this.FavouriteLabel);
            this.Controls.Add(this.StatusDisplay);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TitleText);
            this.Name = "WebBrowser";
            this.Text = "Web browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favouritesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox HTMLDisplay;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button NewURLAccepter;
        private System.Windows.Forms.TreeView HistoryTree;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox HomeChangeText;
        private System.Windows.Forms.ToolStripMenuItem confirmToolStripMenuItem;
        private System.Windows.Forms.TextBox StatusDisplay;
        private System.Windows.Forms.ToolStripMenuItem goHomeToolStripMenuItem;
        private System.Windows.Forms.TextBox FavouriteLabel;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox favouriteName;
        private System.Windows.Forms.ToolStripMenuItem uRLToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox favouriteURL;
        private System.Windows.Forms.ToolStripMenuItem confirmToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteFavourites;
        private System.Windows.Forms.DataGridView favouritesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FavouritesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FavouritesURL;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Button RefreshButton;
    }
}

