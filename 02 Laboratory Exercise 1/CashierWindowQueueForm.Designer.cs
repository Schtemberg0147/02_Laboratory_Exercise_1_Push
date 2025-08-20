namespace _02_Laboratory_Exercise_1
{
    partial class CashierWindowQueueForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.listCashierQueue = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.announcementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gold;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(36, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(209, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gold;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(539, 357);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(209, 47);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listCashierQueue
            // 
            this.listCashierQueue.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listCashierQueue.AllowColumnReorder = true;
            this.listCashierQueue.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCashierQueue.HideSelection = false;
            this.listCashierQueue.LabelWrap = false;
            this.listCashierQueue.Location = new System.Drawing.Point(36, 68);
            this.listCashierQueue.Name = "listCashierQueue";
            this.listCashierQueue.Size = new System.Drawing.Size(712, 267);
            this.listCashierQueue.TabIndex = 1;
            this.listCashierQueue.TileSize = new System.Drawing.Size(10, 10);
            this.listCashierQueue.UseCompatibleStateImageBehavior = false;
            this.listCashierQueue.View = System.Windows.Forms.View.List;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // announcementLabel
            // 
            this.announcementLabel.AutoSize = true;
            this.announcementLabel.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementLabel.Location = new System.Drawing.Point(30, 20);
            this.announcementLabel.Name = "announcementLabel";
            this.announcementLabel.Size = new System.Drawing.Size(180, 35);
            this.announcementLabel.TabIndex = 2;
            this.announcementLabel.Text = "Now Serving";
            // 
            // CashierWindowQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.announcementLabel);
            this.Controls.Add(this.listCashierQueue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRefresh);
            this.Location = new System.Drawing.Point(100, 300);
            this.Name = "CashierWindowQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CashierWindowQueueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label announcementLabel;
    }
}