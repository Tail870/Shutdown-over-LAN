namespace SoL_server
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ColumnIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCMD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnShutdown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonShutdownAllClients = new System.Windows.Forms.Button();
            this.buttonShutdownSelected = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.restartServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIsSelected,
            this.ColumnName,
            this.ColumnOS,
            this.ColumnAddress,
            this.ColumnCMD,
            this.ColumnShutdown});
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewClients.ShowCellErrors = false;
            this.dataGridViewClients.ShowCellToolTips = false;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.ShowRowErrors = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(435, 173);
            this.dataGridViewClients.TabIndex = 5;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClients_CellContentClick);
            // 
            // ColumnIsSelected
            // 
            this.ColumnIsSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIsSelected.DataPropertyName = "IsSelected";
            this.ColumnIsSelected.HeaderText = "✓";
            this.ColumnIsSelected.MinimumWidth = 2;
            this.ColumnIsSelected.Name = "ColumnIsSelected";
            this.ColumnIsSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIsSelected.Width = 21;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle30;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MaxInputLength = 32;
            this.ColumnName.MinimumWidth = 2;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 60;
            // 
            // ColumnOS
            // 
            this.ColumnOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOS.DataPropertyName = "OS";
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnOS.DefaultCellStyle = dataGridViewCellStyle31;
            this.ColumnOS.HeaderText = "OS";
            this.ColumnOS.MinimumWidth = 2;
            this.ColumnOS.Name = "ColumnOS";
            this.ColumnOS.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.DataPropertyName = "IP";
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle32;
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 2;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnCMD
            // 
            this.ColumnCMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnCMD.DefaultCellStyle = dataGridViewCellStyle33;
            this.ColumnCMD.HeaderText = "CMD command";
            this.ColumnCMD.MinimumWidth = 2;
            this.ColumnCMD.Name = "ColumnCMD";
            this.ColumnCMD.Width = 86;
            // 
            // ColumnShutdown
            // 
            this.ColumnShutdown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnShutdown.DefaultCellStyle = dataGridViewCellStyle34;
            this.ColumnShutdown.HeaderText = "Shutdown";
            this.ColumnShutdown.MinimumWidth = 2;
            this.ColumnShutdown.Name = "ColumnShutdown";
            this.ColumnShutdown.Width = 61;
            // 
            // buttonShutdownAllClients
            // 
            this.buttonShutdownAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShutdownAllClients.Location = new System.Drawing.Point(439, 53);
            this.buttonShutdownAllClients.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShutdownAllClients.Name = "buttonShutdownAllClients";
            this.buttonShutdownAllClients.Size = new System.Drawing.Size(145, 23);
            this.buttonShutdownAllClients.TabIndex = 6;
            this.buttonShutdownAllClients.Text = "Shutdown all PC";
            this.buttonShutdownAllClients.UseVisualStyleBackColor = true;
            this.buttonShutdownAllClients.Click += new System.EventHandler(this.ButtonShutdownAllClients_Click);
            // 
            // buttonShutdownSelected
            // 
            this.buttonShutdownSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShutdownSelected.Location = new System.Drawing.Point(439, 26);
            this.buttonShutdownSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShutdownSelected.Name = "buttonShutdownSelected";
            this.buttonShutdownSelected.Size = new System.Drawing.Size(145, 23);
            this.buttonShutdownSelected.TabIndex = 7;
            this.buttonShutdownSelected.Text = "Shutdown selected";
            this.buttonShutdownSelected.UseVisualStyleBackColor = true;
            this.buttonShutdownSelected.Click += new System.EventHandler(this.ButtonShutdownSelected_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(441, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 118);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMainMenu,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemMainMenu
            // 
            this.toolStripMenuItemMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartServerToolStripMenuItem,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemMainMenu.Name = "toolStripMenuItemMainMenu";
            this.toolStripMenuItemMainMenu.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItemMainMenu.Text = "Main menu";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // restartServerToolStripMenuItem
            // 
            this.restartServerToolStripMenuItem.Name = "restartServerToolStripMenuItem";
            this.restartServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartServerToolStripMenuItem.Text = "Restart server";
            this.restartServerToolStripMenuItem.Click += new System.EventHandler(this.restartServerToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Enabled = false;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonShutdownSelected);
            this.Controls.Add(this.buttonShutdownAllClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "FormMain";
            this.Text = "SoL manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonShutdownAllClients;
        private System.Windows.Forms.Button buttonShutdownSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCMD;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShutdown;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem restartServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
    }
}

