namespace meow11
{
    partial class StatisticsForm
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
            this.labelCountOperations = new System.Windows.Forms.Label();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.labelAverageTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountOperations
            // 
            this.labelCountOperations.AutoSize = true;
            this.labelCountOperations.Location = new System.Drawing.Point(487, 43);
            this.labelCountOperations.Name = "labelCountOperations";
            this.labelCountOperations.Size = new System.Drawing.Size(35, 13);
            this.labelCountOperations.TabIndex = 0;
            this.labelCountOperations.Text = "label1";
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(1, 5);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.Size = new System.Drawing.Size(468, 433);
            this.dataGridViewStatistics.TabIndex = 1;
            // 
            // labelAverageTime
            // 
            this.labelAverageTime.AutoSize = true;
            this.labelAverageTime.Location = new System.Drawing.Point(490, 78);
            this.labelAverageTime.Name = "labelAverageTime";
            this.labelAverageTime.Size = new System.Drawing.Size(35, 13);
            this.labelAverageTime.TabIndex = 2;
            this.labelAverageTime.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(713, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "⬅";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAverageTime);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.labelCountOperations);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountOperations;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.Label labelAverageTime;
        private System.Windows.Forms.Button button1;
    }
}