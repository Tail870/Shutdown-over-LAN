﻿namespace SoL_server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ColumnIsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCMD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnShutdown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonShutdownAllClients = new System.Windows.Forms.Button();
            this.buttonShutdownSelected = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restartServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            resources.ApplyResources(this.dataGridViewClients, "dataGridViewClients");
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIsSelected,
            this.ColumnName,
            this.ColumnOS,
            this.ColumnAddress,
            this.ColumnCMD,
            this.ColumnShutdown});
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewClients.ShowCellErrors = false;
            this.dataGridViewClients.ShowCellToolTips = false;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.ShowRowErrors = false;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClients_CellContentClick);
            // 
            // ColumnIsSelected
            // 
            this.ColumnIsSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIsSelected.DataPropertyName = "IsSelected";
            resources.ApplyResources(this.ColumnIsSelected, "ColumnIsSelected");
            this.ColumnIsSelected.Name = "ColumnIsSelected";
            this.ColumnIsSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.ColumnName, "ColumnName");
            this.ColumnName.MaxInputLength = 32;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnOS
            // 
            this.ColumnOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOS.DataPropertyName = "OS";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnOS.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.ColumnOS, "ColumnOS");
            this.ColumnOS.Name = "ColumnOS";
            this.ColumnOS.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.DataPropertyName = "IP";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.ColumnAddress, "ColumnAddress");
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnCMD
            // 
            this.ColumnCMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnCMD.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.ColumnCMD, "ColumnCMD");
            this.ColumnCMD.Name = "ColumnCMD";
            // 
            // ColumnShutdown
            // 
            this.ColumnShutdown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnShutdown.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.ColumnShutdown, "ColumnShutdown");
            this.ColumnShutdown.Name = "ColumnShutdown";
            // 
            // buttonShutdownAllClients
            // 
            resources.ApplyResources(this.buttonShutdownAllClients, "buttonShutdownAllClients");
            this.buttonShutdownAllClients.Name = "buttonShutdownAllClients";
            this.buttonShutdownAllClients.UseVisualStyleBackColor = true;
            this.buttonShutdownAllClients.Click += new System.EventHandler(this.ButtonShutdownAllClients_Click);
            // 
            // buttonShutdownSelected
            // 
            resources.ApplyResources(this.buttonShutdownSelected, "buttonShutdownSelected");
            this.buttonShutdownSelected.Name = "buttonShutdownSelected";
            this.buttonShutdownSelected.UseVisualStyleBackColor = true;
            this.buttonShutdownSelected.Click += new System.EventHandler(this.ButtonShutdownSelected_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMainMenu,
            this.serverToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItemMainMenu
            // 
            resources.ApplyResources(this.toolStripMenuItemMainMenu, "toolStripMenuItemMainMenu");
            this.toolStripMenuItemMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartServerToolStripMenuItem,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemMainMenu.Name = "toolStripMenuItemMainMenu";
            // 
            // restartServerToolStripMenuItem
            // 
            resources.ApplyResources(this.restartServerToolStripMenuItem, "restartServerToolStripMenuItem");
            this.restartServerToolStripMenuItem.Name = "restartServerToolStripMenuItem";
            this.restartServerToolStripMenuItem.Click += new System.EventHandler(this.restartServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItemExit
            // 
            resources.ApplyResources(this.toolStripMenuItemExit, "toolStripMenuItemExit");
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // serverToolStripMenuItem
            // 
            resources.ApplyResources(this.serverToolStripMenuItem, "serverToolStripMenuItem");
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.toolStripSeparator1});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            // 
            // enableToolStripMenuItem
            // 
            resources.ApplyResources(this.enableToolStripMenuItem, "enableToolStripMenuItem");
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            resources.ApplyResources(this.disableToolStripMenuItem, "disableToolStripMenuItem");
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // buttonSettings
            // 
            resources.ApplyResources(this.buttonSettings, "buttonSettings");
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // groupBoxSettings
            // 
            resources.ApplyResources(this.groupBoxSettings, "groupBoxSettings");
            this.groupBoxSettings.Controls.Add(this.buttonApply);
            this.groupBoxSettings.Controls.Add(this.numericUpDownPort);
            this.groupBoxSettings.Controls.Add(this.labelPort);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.TabStop = false;
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // numericUpDownPort
            // 
            resources.ApplyResources(this.numericUpDownPort, "numericUpDownPort");
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            // 
            // labelPort
            // 
            resources.ApplyResources(this.labelPort, "labelPort");
            this.labelPort.Name = "labelPort";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonShutdownSelected);
            this.Controls.Add(this.buttonShutdownAllClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonShutdownAllClients;
        private System.Windows.Forms.Button buttonShutdownSelected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem restartServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCMD;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShutdown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelPort;
    }
}

