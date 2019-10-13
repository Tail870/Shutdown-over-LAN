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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonShutdownAllClients = new System.Windows.Forms.Button();
            this.buttonShutdownSelected = new System.Windows.Forms.Button();
            this.ColumnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCMD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnShutdown = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSelect,
            this.ColumnName,
            this.ColumnOS,
            this.ColumnAddress,
            this.ColumnCMD,
            this.ColumnShutdown});
            this.dataGridViewClients.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewClients.ShowCellErrors = false;
            this.dataGridViewClients.ShowCellToolTips = false;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.ShowRowErrors = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(463, 144);
            this.dataGridViewClients.TabIndex = 5;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewClients_CellContentClick);
            // 
            // buttonShutdownAllClients
            // 
            this.buttonShutdownAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShutdownAllClients.Location = new System.Drawing.Point(328, 160);
            this.buttonShutdownAllClients.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShutdownAllClients.Name = "buttonShutdownAllClients";
            this.buttonShutdownAllClients.Size = new System.Drawing.Size(145, 35);
            this.buttonShutdownAllClients.TabIndex = 6;
            this.buttonShutdownAllClients.Text = "Shutdown all PC";
            this.buttonShutdownAllClients.UseVisualStyleBackColor = true;
            // 
            // buttonShutdownSelected
            // 
            this.buttonShutdownSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShutdownSelected.Location = new System.Drawing.Point(9, 160);
            this.buttonShutdownSelected.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShutdownSelected.Name = "buttonShutdownSelected";
            this.buttonShutdownSelected.Size = new System.Drawing.Size(145, 35);
            this.buttonShutdownSelected.TabIndex = 7;
            this.buttonShutdownSelected.Text = "Shutdown selected";
            this.buttonShutdownSelected.UseVisualStyleBackColor = true;
            this.buttonShutdownSelected.Click += new System.EventHandler(this.buttonShutdownSelected_Click);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnSelect.HeaderText = "✓";
            this.ColumnSelect.MinimumWidth = 2;
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Width = 21;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MaxInputLength = 32;
            this.ColumnName.MinimumWidth = 2;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnOS
            // 
            this.ColumnOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnOS.DataPropertyName = "OS";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnOS.HeaderText = "OS";
            this.ColumnOS.MinimumWidth = 2;
            this.ColumnOS.Name = "ColumnOS";
            this.ColumnOS.ReadOnly = true;
            this.ColumnOS.Width = 47;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAddress.DataPropertyName = "IP";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 2;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 70;
            // 
            // ColumnCMD
            // 
            this.ColumnCMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnCMD.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnCMD.HeaderText = "CMD command";
            this.ColumnCMD.MinimumWidth = 2;
            this.ColumnCMD.Name = "ColumnCMD";
            this.ColumnCMD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCMD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCMD.Width = 96;
            // 
            // ColumnShutdown
            // 
            this.ColumnShutdown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnShutdown.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnShutdown.HeaderText = "Shutdown";
            this.ColumnShutdown.MinimumWidth = 2;
            this.ColumnShutdown.Name = "ColumnShutdown";
            this.ColumnShutdown.Width = 61;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.buttonShutdownSelected);
            this.Controls.Add(this.buttonShutdownAllClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "FormMain";
            this.Text = "SoL manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonShutdownAllClients;
        private System.Windows.Forms.Button buttonShutdownSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCMD;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShutdown;
    }
}

