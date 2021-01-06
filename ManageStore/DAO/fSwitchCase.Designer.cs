namespace ManageStore
{
    partial class fSwitchCase
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
            this.btnDemoDatabase = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompletedDatabase = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comCompleted = new System.Windows.Forms.ComboBox();
            this.comDemo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDemoDatabase
            // 
            this.btnDemoDatabase.Location = new System.Drawing.Point(3, 28);
            this.btnDemoDatabase.Name = "btnDemoDatabase";
            this.btnDemoDatabase.Size = new System.Drawing.Size(86, 35);
            this.btnDemoDatabase.TabIndex = 0;
            this.btnDemoDatabase.Text = "Demo";
            this.btnDemoDatabase.UseVisualStyleBackColor = true;
            this.btnDemoDatabase.Click += new System.EventHandler(this.btnDemoDatabase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCompletedDatabase);
            this.panel1.Controls.Add(this.btnDemoDatabase);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // btnCompletedDatabase
            // 
            this.btnCompletedDatabase.Location = new System.Drawing.Point(3, 69);
            this.btnCompletedDatabase.Name = "btnCompletedDatabase";
            this.btnCompletedDatabase.Size = new System.Drawing.Size(86, 33);
            this.btnCompletedDatabase.TabIndex = 1;
            this.btnCompletedDatabase.Text = "Completed";
            this.btnCompletedDatabase.UseVisualStyleBackColor = true;
            this.btnCompletedDatabase.Click += new System.EventHandler(this.btnCompletedDatabase_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comDemo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(146, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 105);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Demo Transaction";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comCompleted);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(325, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 105);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Completed";
            // 
            // comCompleted
            // 
            this.comCompleted.FormattingEnabled = true;
            this.comCompleted.Items.AddRange(new object[] {
            "T1",
            "T2"});
            this.comCompleted.Location = new System.Drawing.Point(3, 29);
            this.comCompleted.Name = "comCompleted";
            this.comCompleted.Size = new System.Drawing.Size(86, 24);
            this.comCompleted.TabIndex = 3;
            // 
            // comDemo
            // 
            this.comDemo.FormattingEnabled = true;
            this.comDemo.Items.AddRange(new object[] {
            "T1",
            "T2"});
            this.comDemo.Location = new System.Drawing.Point(3, 29);
            this.comDemo.Name = "comDemo";
            this.comDemo.Size = new System.Drawing.Size(86, 24);
            this.comDemo.TabIndex = 3;
            // 
            // fSwitchCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 130);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fSwitchCase";
            this.Text = "fSwitchCase";
            this.Load += new System.EventHandler(this.fSwitchCase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemoDatabase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompletedDatabase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comDemo;
        private System.Windows.Forms.ComboBox comCompleted;
    }
}