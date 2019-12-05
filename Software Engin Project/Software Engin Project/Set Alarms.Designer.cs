namespace Software_Engin_Project
{
    partial class Set_Alarms
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
            this.UpperLimit = new System.Windows.Forms.TextBox();
            this.ModuleName = new System.Windows.Forms.Label();
            this.LowerLimit = new System.Windows.Forms.TextBox();
            this.ReturnToPatient = new System.Windows.Forms.Button();
            this.UpperLimitLabel = new System.Windows.Forms.Label();
            this.LowerLimitLabel = new System.Windows.Forms.Label();
            this.DeleteModule = new System.Windows.Forms.Button();
            this.SetLimits = new System.Windows.Forms.Button();
            this.CurrentUpper = new System.Windows.Forms.Label();
            this.CurrentLower = new System.Windows.Forms.Label();
            this.SetCurrentLower = new System.Windows.Forms.Label();
            this.SetCurrentUpper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpperLimit
            // 
            this.UpperLimit.Location = new System.Drawing.Point(307, 163);
            this.UpperLimit.Name = "UpperLimit";
            this.UpperLimit.Size = new System.Drawing.Size(165, 20);
            this.UpperLimit.TabIndex = 0;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSize = true;
            this.ModuleName.Location = new System.Drawing.Point(348, 61);
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Size = new System.Drawing.Size(76, 13);
            this.ModuleName.TabIndex = 1;
            this.ModuleName.Text = "Module Name:";
            // 
            // LowerLimit
            // 
            this.LowerLimit.Location = new System.Drawing.Point(307, 221);
            this.LowerLimit.Name = "LowerLimit";
            this.LowerLimit.Size = new System.Drawing.Size(165, 20);
            this.LowerLimit.TabIndex = 2;
            // 
            // ReturnToPatient
            // 
            this.ReturnToPatient.Location = new System.Drawing.Point(201, 315);
            this.ReturnToPatient.Name = "ReturnToPatient";
            this.ReturnToPatient.Size = new System.Drawing.Size(165, 64);
            this.ReturnToPatient.TabIndex = 3;
            this.ReturnToPatient.Text = "Return To Patient";
            this.ReturnToPatient.UseVisualStyleBackColor = true;
            this.ReturnToPatient.Click += new System.EventHandler(this.ReturnToPatient_Click);
            // 
            // UpperLimitLabel
            // 
            this.UpperLimitLabel.AutoSize = true;
            this.UpperLimitLabel.Location = new System.Drawing.Point(223, 163);
            this.UpperLimitLabel.Name = "UpperLimitLabel";
            this.UpperLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.UpperLimitLabel.TabIndex = 4;
            this.UpperLimitLabel.Text = "Upper Limit";
            // 
            // LowerLimitLabel
            // 
            this.LowerLimitLabel.AutoSize = true;
            this.LowerLimitLabel.Location = new System.Drawing.Point(223, 224);
            this.LowerLimitLabel.Name = "LowerLimitLabel";
            this.LowerLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.LowerLimitLabel.TabIndex = 5;
            this.LowerLimitLabel.Text = "Lower Limit";
            // 
            // DeleteModule
            // 
            this.DeleteModule.Location = new System.Drawing.Point(404, 315);
            this.DeleteModule.Name = "DeleteModule";
            this.DeleteModule.Size = new System.Drawing.Size(165, 64);
            this.DeleteModule.TabIndex = 6;
            this.DeleteModule.Text = "Delete Module";
            this.DeleteModule.UseVisualStyleBackColor = true;
            this.DeleteModule.Click += new System.EventHandler(this.DeleteModule_Click);
            // 
            // SetLimits
            // 
            this.SetLimits.Location = new System.Drawing.Point(497, 173);
            this.SetLimits.Name = "SetLimits";
            this.SetLimits.Size = new System.Drawing.Size(165, 64);
            this.SetLimits.TabIndex = 7;
            this.SetLimits.Text = "Set Limits";
            this.SetLimits.UseVisualStyleBackColor = true;
            this.SetLimits.Click += new System.EventHandler(this.SetLimits_Click);
            // 
            // CurrentUpper
            // 
            this.CurrentUpper.AutoSize = true;
            this.CurrentUpper.Location = new System.Drawing.Point(269, 133);
            this.CurrentUpper.Name = "CurrentUpper";
            this.CurrentUpper.Size = new System.Drawing.Size(100, 13);
            this.CurrentUpper.TabIndex = 8;
            this.CurrentUpper.Text = "Current Upper Limit:";
            // 
            // CurrentLower
            // 
            this.CurrentLower.AutoSize = true;
            this.CurrentLower.Location = new System.Drawing.Point(269, 199);
            this.CurrentLower.Name = "CurrentLower";
            this.CurrentLower.Size = new System.Drawing.Size(100, 13);
            this.CurrentLower.TabIndex = 9;
            this.CurrentLower.Text = "Current Lower Limit:";
            // 
            // SetCurrentLower
            // 
            this.SetCurrentLower.AutoSize = true;
            this.SetCurrentLower.Location = new System.Drawing.Point(375, 199);
            this.SetCurrentLower.Name = "SetCurrentLower";
            this.SetCurrentLower.Size = new System.Drawing.Size(35, 13);
            this.SetCurrentLower.TabIndex = 10;
            this.SetCurrentLower.Text = "label3";
            // 
            // SetCurrentUpper
            // 
            this.SetCurrentUpper.AutoSize = true;
            this.SetCurrentUpper.Location = new System.Drawing.Point(375, 133);
            this.SetCurrentUpper.Name = "SetCurrentUpper";
            this.SetCurrentUpper.Size = new System.Drawing.Size(35, 13);
            this.SetCurrentUpper.TabIndex = 11;
            this.SetCurrentUpper.Text = "label4";
            this.SetCurrentUpper.Click += new System.EventHandler(this.SetCurrentUpper_Click);
            // 
            // Set_Alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetCurrentUpper);
            this.Controls.Add(this.SetCurrentLower);
            this.Controls.Add(this.CurrentLower);
            this.Controls.Add(this.CurrentUpper);
            this.Controls.Add(this.SetLimits);
            this.Controls.Add(this.DeleteModule);
            this.Controls.Add(this.LowerLimitLabel);
            this.Controls.Add(this.UpperLimitLabel);
            this.Controls.Add(this.ReturnToPatient);
            this.Controls.Add(this.LowerLimit);
            this.Controls.Add(this.ModuleName);
            this.Controls.Add(this.UpperLimit);
            this.Name = "Set_Alarms";
            this.Text = "Set_Alarms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UpperLimit;
        private System.Windows.Forms.Label ModuleName;
        private System.Windows.Forms.TextBox LowerLimit;
        private System.Windows.Forms.Button ReturnToPatient;
        private System.Windows.Forms.Label UpperLimitLabel;
        private System.Windows.Forms.Label LowerLimitLabel;
        private System.Windows.Forms.Button DeleteModule;
        private System.Windows.Forms.Button SetLimits;
        private System.Windows.Forms.Label CurrentUpper;
        private System.Windows.Forms.Label CurrentLower;
        private System.Windows.Forms.Label SetCurrentLower;
        private System.Windows.Forms.Label SetCurrentUpper;
    }
}