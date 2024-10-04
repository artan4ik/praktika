namespace meow11
{
    partial class ClientsForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchPhoneNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchLastName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchFirstName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonDeleteOperation = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DeepPink;
            this.buttonSearch.Location = new System.Drawing.Point(554, 267);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 23);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxSearchPhoneNumber
            // 
            this.comboBoxSearchPhoneNumber.FormattingEnabled = true;
            this.comboBoxSearchPhoneNumber.Location = new System.Drawing.Point(618, 203);
            this.comboBoxSearchPhoneNumber.Name = "comboBoxSearchPhoneNumber";
            this.comboBoxSearchPhoneNumber.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchPhoneNumber.TabIndex = 42;
            // 
            // comboBoxSearchLastName
            // 
            this.comboBoxSearchLastName.FormattingEnabled = true;
            this.comboBoxSearchLastName.Location = new System.Drawing.Point(488, 240);
            this.comboBoxSearchLastName.Name = "comboBoxSearchLastName";
            this.comboBoxSearchLastName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchLastName.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(579, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Поиск";
            // 
            // comboBoxSearchFirstName
            // 
            this.comboBoxSearchFirstName.FormattingEnabled = true;
            this.comboBoxSearchFirstName.Location = new System.Drawing.Point(488, 203);
            this.comboBoxSearchFirstName.Name = "comboBoxSearchFirstName";
            this.comboBoxSearchFirstName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchFirstName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Фамилия";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(718, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(7, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(475, 447);
            this.dataGridViewClients.TabIndex = 29;
            // 
            // buttonDeleteOperation
            // 
            this.buttonDeleteOperation.BackColor = System.Drawing.Color.DeepPink;
            this.buttonDeleteOperation.Location = new System.Drawing.Point(653, 387);
            this.buttonDeleteOperation.Name = "buttonDeleteOperation";
            this.buttonDeleteOperation.Size = new System.Drawing.Size(140, 40);
            this.buttonDeleteOperation.TabIndex = 28;
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
            this.buttonAddOperation.TabIndex = 26;
            this.buttonAddOperation.Text = "Добавить";
            this.buttonAddOperation.UseVisualStyleBackColor = false;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(488, 17);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFirstName.TabIndex = 45;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(488, 41);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastName.TabIndex = 46;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(488, 65);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.textBoxPhoneNumber.TabIndex = 47;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSearchPhoneNumber);
            this.Controls.Add(this.comboBoxSearchLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSearchFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.buttonDeleteOperation);
            this.Controls.Add(this.buttonAddOperation);
            this.Name = "ClientsForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxSearchLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonDeleteOperation;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
    }
}