namespace ZorkBuilderForm
{
    partial class ZorkBuilderForm
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
            this.zorkMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkTabControl = new System.Windows.Forms.TabControl();
            this.Rooms = new System.Windows.Forms.TabPage();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eastRoomLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.westRoomLabel = new System.Windows.Forms.Label();
            this.southRoomTextBox = new System.Windows.Forms.TextBox();
            this.southRoomLabel = new System.Windows.Forms.Label();
            this.northRoomTextBox = new System.Windows.Forms.TextBox();
            this.northRoomLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.zorkMenuStrip.SuspendLayout();
            this.zorkTabControl.SuspendLayout();
            this.Rooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // zorkMenuStrip
            // 
            this.zorkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.zorkMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.zorkMenuStrip.Name = "zorkMenuStrip";
            this.zorkMenuStrip.Size = new System.Drawing.Size(627, 24);
            this.zorkMenuStrip.TabIndex = 0;
            this.zorkMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openWorldToolStripMenuItem.Text = "&Open World...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // zorkTabControl
            // 
            this.zorkTabControl.Controls.Add(this.Rooms);
            this.zorkTabControl.Location = new System.Drawing.Point(12, 27);
            this.zorkTabControl.Name = "zorkTabControl";
            this.zorkTabControl.SelectedIndex = 0;
            this.zorkTabControl.Size = new System.Drawing.Size(603, 392);
            this.zorkTabControl.TabIndex = 1;
            // 
            // Rooms
            // 
            this.Rooms.Controls.Add(this.descriptionTextBox);
            this.Rooms.Controls.Add(this.descriptionLabel);
            this.Rooms.Controls.Add(this.textBox2);
            this.Rooms.Controls.Add(this.eastRoomLabel);
            this.Rooms.Controls.Add(this.textBox1);
            this.Rooms.Controls.Add(this.westRoomLabel);
            this.Rooms.Controls.Add(this.southRoomTextBox);
            this.Rooms.Controls.Add(this.southRoomLabel);
            this.Rooms.Controls.Add(this.northRoomTextBox);
            this.Rooms.Controls.Add(this.northRoomLabel);
            this.Rooms.Controls.Add(this.roomNameTextBox);
            this.Rooms.Controls.Add(this.roomNameLabel);
            this.Rooms.Controls.Add(this.deleteRoomButton);
            this.Rooms.Controls.Add(this.addRoomButton);
            this.Rooms.Controls.Add(this.roomsListBox);
            this.Rooms.Controls.Add(this.listView1);
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Padding = new System.Windows.Forms.Padding(3);
            this.Rooms.Size = new System.Drawing.Size(595, 366);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "tabPage1";
            this.Rooms.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(201, 75);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(343, 90);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(198, 58);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 13;
            // 
            // eastRoomLabel
            // 
            this.eastRoomLabel.AutoSize = true;
            this.eastRoomLabel.Location = new System.Drawing.Point(196, 318);
            this.eastRoomLabel.Name = "eastRoomLabel";
            this.eastRoomLabel.Size = new System.Drawing.Size(31, 13);
            this.eastRoomLabel.TabIndex = 12;
            this.eastRoomLabel.Text = "East:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 11;
            // 
            // westRoomLabel
            // 
            this.westRoomLabel.AutoSize = true;
            this.westRoomLabel.Location = new System.Drawing.Point(196, 271);
            this.westRoomLabel.Name = "westRoomLabel";
            this.westRoomLabel.Size = new System.Drawing.Size(35, 13);
            this.westRoomLabel.TabIndex = 10;
            this.westRoomLabel.Text = "West:";
            // 
            // southRoomTextBox
            // 
            this.southRoomTextBox.Location = new System.Drawing.Point(199, 243);
            this.southRoomTextBox.Name = "southRoomTextBox";
            this.southRoomTextBox.Size = new System.Drawing.Size(167, 20);
            this.southRoomTextBox.TabIndex = 9;
            // 
            // southRoomLabel
            // 
            this.southRoomLabel.AutoSize = true;
            this.southRoomLabel.Location = new System.Drawing.Point(196, 226);
            this.southRoomLabel.Name = "southRoomLabel";
            this.southRoomLabel.Size = new System.Drawing.Size(38, 13);
            this.southRoomLabel.TabIndex = 8;
            this.southRoomLabel.Text = "South:";
            // 
            // northRoomTextBox
            // 
            this.northRoomTextBox.Location = new System.Drawing.Point(199, 197);
            this.northRoomTextBox.Name = "northRoomTextBox";
            this.northRoomTextBox.Size = new System.Drawing.Size(167, 20);
            this.northRoomTextBox.TabIndex = 7;
            // 
            // northRoomLabel
            // 
            this.northRoomLabel.AutoSize = true;
            this.northRoomLabel.Location = new System.Drawing.Point(196, 180);
            this.northRoomLabel.Name = "northRoomLabel";
            this.northRoomLabel.Size = new System.Drawing.Size(36, 13);
            this.northRoomLabel.TabIndex = 6;
            this.northRoomLabel.Text = "North:";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(199, 24);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.roomNameTextBox.TabIndex = 5;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(196, 7);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.roomNameLabel.TabIndex = 4;
            this.roomNameLabel.Text = "Name:";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(104, 343);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(6, 343);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(0, 0);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(189, 342);
            this.roomsListBox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(189, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 431);
            this.Controls.Add(this.zorkTabControl);
            this.Controls.Add(this.zorkMenuStrip);
            this.MainMenuStrip = this.zorkMenuStrip;
            this.Name = "ZorkBuilderForm";
            this.Text = "Zork Builder";
            this.zorkMenuStrip.ResumeLayout(false);
            this.zorkMenuStrip.PerformLayout();
            this.zorkTabControl.ResumeLayout(false);
            this.Rooms.ResumeLayout(false);
            this.Rooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip zorkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl zorkTabControl;
        private System.Windows.Forms.TabPage Rooms;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label eastRoomLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label westRoomLabel;
        private System.Windows.Forms.TextBox southRoomTextBox;
        private System.Windows.Forms.Label southRoomLabel;
        private System.Windows.Forms.TextBox northRoomTextBox;
        private System.Windows.Forms.Label northRoomLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ListView listView1;
    }
}

