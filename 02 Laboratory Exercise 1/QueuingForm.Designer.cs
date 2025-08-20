namespace _02_Laboratory_Exercise_1
{
    partial class QueuingForm
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
            this.positionLabel = new System.Windows.Forms.Label();
            this.lblQueue = new System.Windows.Forms.Label();
            this.btnCashier = new System.Windows.Forms.Button();
            this.reminderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(466, 175);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(90, 13);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(466, 225);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(69, 13);
            this.lblQueue.TabIndex = 0;
            this.lblQueue.Text = "Your Position";
            this.lblQueue.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Location = new System.Drawing.Point(172, 170);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(75, 23);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // reminderLabel
            // 
            this.reminderLabel.AutoSize = true;
            this.reminderLabel.Location = new System.Drawing.Point(169, 225);
            this.reminderLabel.Name = "reminderLabel";
            this.reminderLabel.Size = new System.Drawing.Size(125, 13);
            this.reminderLabel.TabIndex = 0;
            this.reminderLabel.Text = "*Click to get your number";
            this.reminderLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.reminderLabel);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.positionLabel);
            this.Name = "QueuingForm";
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label reminderLabel;
    }
}

