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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
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
            this.dataGridViewClients.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewClients.ShowCellErrors = false;
            this.dataGridViewClients.ShowCellToolTips = false;
            this.dataGridViewClients.ShowEditingIcon = false;
            this.dataGridViewClients.ShowRowErrors = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(451, 161);
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
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnOS.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnOS.HeaderText = "OS";
            this.ColumnOS.MinimumWidth = 2;
            this.ColumnOS.Name = "ColumnOS";
            this.ColumnOS.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.DataPropertyName = "IP";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.MinimumWidth = 2;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnCMD
            // 
            this.ColumnCMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnCMD.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnCMD.HeaderText = "CMD command";
            this.ColumnCMD.MinimumWidth = 2;
            this.ColumnCMD.Name = "ColumnCMD";
            this.ColumnCMD.Width = 86;
            // 
            // ColumnShutdown
            // 
            this.ColumnShutdown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnShutdown.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnShutdown.HeaderText = "Shutdown";
            this.ColumnShutdown.MinimumWidth = 2;
            this.ColumnShutdown.Name = "ColumnShutdown";
            this.ColumnShutdown.Width = 61;
            // 
            // buttonShutdownAllClients
            // 
            this.buttonShutdownAllClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShutdownAllClients.Location = new System.Drawing.Point(316, 177);
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
            this.buttonShutdownSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShutdownSelected.Location = new System.Drawing.Point(10, 177);
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
            this.richTextBox1.Location = new System.Drawing.Point(467, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 189);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 211);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCMD;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShutdown;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

