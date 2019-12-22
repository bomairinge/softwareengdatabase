namespace Software_Engin_Project
{
    partial class Pager
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
            this.PagerID = new System.Windows.Forms.TextBox();
            this.Okay = new System.Windows.Forms.Button();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PagerID
            // 
            this.PagerID.Location = new System.Drawing.Point(100, 41);
            this.PagerID.Name = "PagerID";
            this.PagerID.Size = new System.Drawing.Size(100, 20);
            this.PagerID.TabIndex = 0;
            this.PagerID.TextChanged += new System.EventHandler(this.PagerID_TextChanged);
            // 
            // Okay
            // 
            this.Okay.Location = new System.Drawing.Point(100, 123);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(75, 23);
            this.Okay.TabIndex = 1;
            this.Okay.Text = "Okay";
            this.Okay.UseVisualStyleBackColor = true;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(100, 89);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(100, 20);
            this.phoneNum.TabIndex = 2;
            this.phoneNum.TextChanged += new System.EventHandler(this.PhoneNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a Pager Number or Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number:";
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.Okay);
            this.Controls.Add(this.PagerID);
            this.Name = "Pager";
            this.Text = "Pager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PagerID;
        private System.Windows.Forms.Button Okay;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}