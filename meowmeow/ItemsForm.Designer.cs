namespace meow11
{
    partial class ItemsForm
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
            this.textBoxEstimatedValue = new System.Windows.Forms.TextBox();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.textBoxItemType = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonDeleteOperation = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.comboBoxSearchItemDescription = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEstimatedValue
            // 
            this.textBoxEstimatedValue.Location = new System.Drawing.Point(488, 65);
            this.textBoxEstimatedValue.Name = "textBoxEstimatedValue";
            this.textBoxEstimatedValue.Size = new System.Drawing.Size(121, 20);
            this.textBoxEstimatedValue.TabIndex = 77;
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Location = new System.Drawing.Point(488, 41);
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(121, 20);
            this.textBoxItemDescription.TabIndex = 76;
            // 
            // textBoxItemType
            // 
            this.textBoxItemType.Location = new System.Drawing.Point(488, 17);
            this.textBoxItemType.Name = "textBoxItemType";
            this.textBoxItemType.Size = new System.Drawing.Size(121, 20);
            this.textBoxItemType.TabIndex = 75;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepPink;
            this.buttonSearch.Location = new System.Drawing.Point(554, 267);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 23);
            this.buttonSearch.TabIndex = 74;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(579, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "Поиск";
            // 
            // comboBoxSearchItemType
            // 
            this.comboBoxSearchItemType.FormattingEnabled = true;
            this.comboBoxSearchItemType.Location = new System.Drawing.Point(488, 203);
            this.comboBoxSearchItemType.Name = "comboBoxSearchItemType";
            this.comboBoxSearchItemType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchItemType.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Фамилия";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(718, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 66;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(7, 2);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(475, 447);
            this.dataGridViewItems.TabIndex = 65;
            // 
            // buttonDeleteOperation
            // 
            this.buttonDeleteOperation.BackColor = System.Drawing.Color.DeepPink;
            this.buttonDeleteOperation.Location = new System.Drawing.Point(653, 387);
            this.buttonDeleteOperation.Name = "buttonDeleteOperation";
            this.buttonDeleteOperation.Size = new System.Drawing.Size(140, 40);
            this.buttonDeleteOperation.TabIndex = 64;
            this.buttonDeleteOperation.Text = "Удалить";
            this.buttonDeleteOperation.UseVisualStyleBackColor = false;
            this.buttonDeleteOperation.Click += new System.EventHandler(this.buttonDeleteOperation_Click);
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.BackColor = System.Drawing.Color.DeepPink;
            this.buttonAddOperation.Location = new System.Drawing.Point(488, 101);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOperation.TabIndex = 63;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = false;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // comboBoxSearchItemDescription
            // 
            this.comboBoxSearchItemDescription.FormattingEnabled = true;
            this.comboBoxSearchItemDescription.Location = new System.Drawing.Point(632, 203);
            this.comboBoxSearchItemDescription.Name = "comboBoxSearchItemDescription";
            this.comboBoxSearchItemDescription.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchItemDescription.TabIndex = 78;
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSearchItemDescription);
            this.Controls.Add(this.textBoxEstimatedValue);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.textBoxItemType);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSearchItemType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.buttonDeleteOperation);
            this.Controls.Add(this.buttonAddOperation);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEstimatedValue;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.TextBox textBoxItemType;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchItemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonDeleteOperation;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.ComboBox comboBoxSearchItemDescription;
    }
}