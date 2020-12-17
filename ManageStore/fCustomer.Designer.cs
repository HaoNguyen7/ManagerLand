
namespace ManageStore
{
    partial class fCustomer
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
            this.tabOwnerHouse = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBoxAsksCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxHouseTypes = new System.Windows.Forms.ListBox();
            this.lOAINHABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHADATDataSet = new ManageStore.QLNHADATDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDisplayAsksCustomer = new System.Windows.Forms.Button();
            this.btnDeleteAskCustomer = new System.Windows.Forms.Button();
            this.btnEditAsksCustomer = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvAsksCustomer = new System.Windows.Forms.DataGridView();
            this.tpStaff = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOAINHATableAdapter = new ManageStore.QLNHADATDataSetTableAdapters.LOAINHATableAdapter();
            this.tabOwnerHouse.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAINHABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHADATDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsksCustomer)).BeginInit();
            this.tpStaff.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOwnerHouse
            // 
            this.tabOwnerHouse.Controls.Add(this.tabPage1);
            this.tabOwnerHouse.Controls.Add(this.tpStaff);
            this.tabOwnerHouse.Location = new System.Drawing.Point(9, 12);
            this.tabOwnerHouse.Name = "tabOwnerHouse";
            this.tabOwnerHouse.SelectedIndex = 0;
            this.tabOwnerHouse.Size = new System.Drawing.Size(1238, 510);
            this.tabOwnerHouse.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Yêu cầu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(768, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 398);
            this.panel5.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBoxAsksCustomer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 42);
            this.panel2.TabIndex = 1;
            // 
            // tBoxAsksCustomer
            // 
            this.tBoxAsksCustomer.Location = new System.Drawing.Point(169, 8);
            this.tBoxAsksCustomer.Name = "tBoxAsksCustomer";
            this.tBoxAsksCustomer.Size = new System.Drawing.Size(260, 22);
            this.tBoxAsksCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yêu cầu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lBoxHouseTypes);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Nhà:";
            // 
            // lBoxHouseTypes
            // 
            this.lBoxHouseTypes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAINHABindingSource, "TENLOAINHA", true));
            this.lBoxHouseTypes.DataSource = this.lOAINHABindingSource;
            this.lBoxHouseTypes.DisplayMember = "TENLOAINHA";
            this.lBoxHouseTypes.FormattingEnabled = true;
            this.lBoxHouseTypes.ItemHeight = 16;
            this.lBoxHouseTypes.Location = new System.Drawing.Point(169, 2);
            this.lBoxHouseTypes.Name = "lBoxHouseTypes";
            this.lBoxHouseTypes.Size = new System.Drawing.Size(260, 36);
            this.lBoxHouseTypes.TabIndex = 0;
            this.lBoxHouseTypes.ValueMember = "TENLOAINHA";
            // 
            // lOAINHABindingSource
            // 
            this.lOAINHABindingSource.DataMember = "LOAINHA";
            this.lOAINHABindingSource.DataSource = this.qLNHADATDataSet;
            // 
            // qLNHADATDataSet
            // 
            this.qLNHADATDataSet.DataSetName = "QLNHADATDataSet";
            this.qLNHADATDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDisplayAsksCustomer);
            this.panel4.Controls.Add(this.btnDeleteAskCustomer);
            this.panel4.Controls.Add(this.btnEditAsksCustomer);
            this.panel4.Controls.Add(this.btnAddStaff);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 62);
            this.panel4.TabIndex = 4;
            // 
            // btnDisplayAsksCustomer
            // 
            this.btnDisplayAsksCustomer.Location = new System.Drawing.Point(247, 3);
            this.btnDisplayAsksCustomer.Name = "btnDisplayAsksCustomer";
            this.btnDisplayAsksCustomer.Size = new System.Drawing.Size(75, 55);
            this.btnDisplayAsksCustomer.TabIndex = 3;
            this.btnDisplayAsksCustomer.Text = "Xem";
            this.btnDisplayAsksCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAskCustomer
            // 
            this.btnDeleteAskCustomer.Location = new System.Drawing.Point(166, 4);
            this.btnDeleteAskCustomer.Name = "btnDeleteAskCustomer";
            this.btnDeleteAskCustomer.Size = new System.Drawing.Size(75, 55);
            this.btnDeleteAskCustomer.TabIndex = 2;
            this.btnDeleteAskCustomer.Text = "Xóa";
            this.btnDeleteAskCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditAsksCustomer
            // 
            this.btnEditAsksCustomer.Location = new System.Drawing.Point(85, 4);
            this.btnEditAsksCustomer.Name = "btnEditAsksCustomer";
            this.btnEditAsksCustomer.Size = new System.Drawing.Size(75, 55);
            this.btnEditAsksCustomer.TabIndex = 1;
            this.btnEditAsksCustomer.Text = "Sửa";
            this.btnEditAsksCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(4, 4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 55);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvAsksCustomer);
            this.panel3.Location = new System.Drawing.Point(6, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 398);
            this.panel3.TabIndex = 3;
            // 
            // dtgvAsksCustomer
            // 
            this.dtgvAsksCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAsksCustomer.ColumnHeadersVisible = false;
            this.dtgvAsksCustomer.Location = new System.Drawing.Point(4, 4);
            this.dtgvAsksCustomer.Name = "dtgvAsksCustomer";
            this.dtgvAsksCustomer.RowHeadersWidth = 51;
            this.dtgvAsksCustomer.RowTemplate.Height = 24;
            this.dtgvAsksCustomer.Size = new System.Drawing.Size(738, 391);
            this.dtgvAsksCustomer.TabIndex = 0;
            // 
            // tpStaff
            // 
            this.tpStaff.Controls.Add(this.panel11);
            this.tpStaff.Controls.Add(this.panel26);
            this.tpStaff.Controls.Add(this.panel27);
            this.tpStaff.Location = new System.Drawing.Point(4, 25);
            this.tpStaff.Name = "tpStaff";
            this.tpStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tpStaff.Size = new System.Drawing.Size(1230, 481);
            this.tpStaff.TabIndex = 4;
            this.tpStaff.Text = "Đánh giá";
            this.tpStaff.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel20);
            this.panel11.Location = new System.Drawing.Point(757, 75);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(438, 370);
            this.panel11.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.textBox15);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Location = new System.Drawing.Point(6, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(429, 40);
            this.panel13.TabIndex = 6;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(127, 8);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(291, 22);
            this.textBox15.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Nhà:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.textBox18);
            this.panel20.Controls.Add(this.label10);
            this.panel20.Location = new System.Drawing.Point(6, 50);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(429, 40);
            this.panel20.TabIndex = 5;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(127, 8);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(291, 22);
            this.textBox18.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhận xét:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.button2);
            this.panel26.Controls.Add(this.button3);
            this.panel26.Controls.Add(this.button4);
            this.panel26.Controls.Add(this.button5);
            this.panel26.Location = new System.Drawing.Point(6, 7);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(326, 62);
            this.panel26.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 1;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 55);
            this.button5.TabIndex = 0;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.dataGridView1);
            this.panel27.Location = new System.Drawing.Point(6, 75);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(745, 370);
            this.panel27.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // lOAINHATableAdapter
            // 
            this.lOAINHATableAdapter.ClearBeforeFill = true;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 527);
            this.Controls.Add(this.tabOwnerHouse);
            this.Name = "fCustomer";
            this.Text = "fCustomer";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.tabOwnerHouse.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAINHABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHADATDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAsksCustomer)).EndInit();
            this.tpStaff.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOwnerHouse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDisplayAsksCustomer;
        private System.Windows.Forms.Button btnDeleteAskCustomer;
        private System.Windows.Forms.Button btnEditAsksCustomer;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvAsksCustomer;
        private System.Windows.Forms.TabPage tpStaff;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBoxAsksCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxHouseTypes;
        private QLNHADATDataSet qLNHADATDataSet;
        private System.Windows.Forms.BindingSource lOAINHABindingSource;
        private QLNHADATDataSetTableAdapters.LOAINHATableAdapter lOAINHATableAdapter;
    }
}