namespace MSEM_Dev.page
{
    partial class EqForm
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
            this.EqDataGridView = new System.Windows.Forms.DataGridView();
            this.AddEq = new System.Windows.Forms.Button();
            this.Reflash = new System.Windows.Forms.Button();
            this.deleteEq = new System.Windows.Forms.Button();
            this.updataEq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectByIdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectBySer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectByName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectByBuyTime = new System.Windows.Forms.DateTimePicker();
            this.selectByBuyTime2 = new System.Windows.Forms.DateTimePicker();
            this.selectDpBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehousing_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible_dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EqDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EqDataGridView
            // 
            this.EqDataGridView.AllowUserToAddRows = false;
            this.EqDataGridView.AllowUserToDeleteRows = false;
            this.EqDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EqDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EqDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.serial_number,
            this.purchase_time,
            this.warehousing_time,
            this.location,
            this.responsible_dp,
            this.state,
            this.price,
            this.supplier_id,
            this.Column1,
            this.Column2});
            this.EqDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.EqDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EqDataGridView.MultiSelect = false;
            this.EqDataGridView.Name = "EqDataGridView";
            this.EqDataGridView.RowHeadersVisible = false;
            this.EqDataGridView.RowTemplate.Height = 25;
            this.EqDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EqDataGridView.Size = new System.Drawing.Size(922, 568);
            this.EqDataGridView.TabIndex = 0;
            // 
            // AddEq
            // 
            this.AddEq.Location = new System.Drawing.Point(944, 22);
            this.AddEq.Name = "AddEq";
            this.AddEq.Size = new System.Drawing.Size(75, 23);
            this.AddEq.TabIndex = 2;
            this.AddEq.Text = "添加设备";
            this.AddEq.UseVisualStyleBackColor = true;
            this.AddEq.Click += new System.EventHandler(this.AddEq_Click);
            // 
            // Reflash
            // 
            this.Reflash.Location = new System.Drawing.Point(1055, 22);
            this.Reflash.Name = "Reflash";
            this.Reflash.Size = new System.Drawing.Size(75, 23);
            this.Reflash.TabIndex = 3;
            this.Reflash.Text = "刷新";
            this.Reflash.UseVisualStyleBackColor = true;
            this.Reflash.Click += new System.EventHandler(this.Reflash_Click);
            // 
            // deleteEq
            // 
            this.deleteEq.Location = new System.Drawing.Point(944, 68);
            this.deleteEq.Name = "deleteEq";
            this.deleteEq.Size = new System.Drawing.Size(75, 23);
            this.deleteEq.TabIndex = 4;
            this.deleteEq.Text = "删除设备";
            this.deleteEq.UseVisualStyleBackColor = true;
            this.deleteEq.Click += new System.EventHandler(this.deleteEq_Click);
            // 
            // updataEq
            // 
            this.updataEq.Location = new System.Drawing.Point(1055, 68);
            this.updataEq.Name = "updataEq";
            this.updataEq.Size = new System.Drawing.Size(75, 23);
            this.updataEq.TabIndex = 5;
            this.updataEq.Text = "修改设备";
            this.updataEq.UseVisualStyleBackColor = true;
            this.updataEq.Click += new System.EventHandler(this.updataEq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "查询设备:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(946, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID查询";
            // 
            // selectByIdBox
            // 
            this.selectByIdBox.Location = new System.Drawing.Point(1014, 171);
            this.selectByIdBox.Name = "selectByIdBox";
            this.selectByIdBox.Size = new System.Drawing.Size(100, 23);
            this.selectByIdBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "序列号";
            // 
            // selectBySer
            // 
            this.selectBySer.Location = new System.Drawing.Point(1014, 205);
            this.selectBySer.Name = "selectBySer";
            this.selectBySer.Size = new System.Drawing.Size(100, 23);
            this.selectBySer.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "设备名";
            // 
            // selectByName
            // 
            this.selectByName.Location = new System.Drawing.Point(1014, 242);
            this.selectByName.Name = "selectByName";
            this.selectByName.Size = new System.Drawing.Size(100, 23);
            this.selectByName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "购买时间";
            // 
            // selectByBuyTime
            // 
            this.selectByBuyTime.Location = new System.Drawing.Point(990, 301);
            this.selectByBuyTime.Name = "selectByBuyTime";
            this.selectByBuyTime.Size = new System.Drawing.Size(155, 23);
            this.selectByBuyTime.TabIndex = 19;
            this.selectByBuyTime.ValueChanged += new System.EventHandler(this.selectByWTime_ValueChanged);
            // 
            // selectByBuyTime2
            // 
            this.selectByBuyTime2.Location = new System.Drawing.Point(990, 332);
            this.selectByBuyTime2.Name = "selectByBuyTime2";
            this.selectByBuyTime2.Size = new System.Drawing.Size(154, 23);
            this.selectByBuyTime2.TabIndex = 21;
            this.selectByBuyTime2.ValueChanged += new System.EventHandler(this.selectByWTime_ValueChanged);
            // 
            // selectDpBox
            // 
            this.selectDpBox.FormattingEnabled = true;
            this.selectDpBox.Location = new System.Drawing.Point(1014, 423);
            this.selectDpBox.Name = "selectDpBox";
            this.selectDpBox.Size = new System.Drawing.Size(121, 25);
            this.selectDpBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(945, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "负责部门";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(1005, 469);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 24;
            this.selectButton.Text = "联合查询";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "购买时间重置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(948, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "起始";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(948, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "结束";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(990, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "设备维修申请";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 82;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "name";
            this.name.Frozen = true;
            this.name.HeaderText = "设备名";
            this.name.Name = "name";
            this.name.Width = 82;
            // 
            // serial_number
            // 
            this.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.serial_number.DataPropertyName = "serial_number";
            this.serial_number.Frozen = true;
            this.serial_number.HeaderText = "序列号";
            this.serial_number.Name = "serial_number";
            this.serial_number.Width = 82;
            // 
            // purchase_time
            // 
            this.purchase_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.purchase_time.DataPropertyName = "purchase_time";
            this.purchase_time.Frozen = true;
            this.purchase_time.HeaderText = "购买时间";
            this.purchase_time.Name = "purchase_time";
            this.purchase_time.Width = 82;
            // 
            // warehousing_time
            // 
            this.warehousing_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.warehousing_time.DataPropertyName = "warehousing_time";
            this.warehousing_time.Frozen = true;
            this.warehousing_time.HeaderText = "入库时间";
            this.warehousing_time.Name = "warehousing_time";
            this.warehousing_time.Width = 82;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.location.DataPropertyName = "location";
            this.location.Frozen = true;
            this.location.HeaderText = "位置";
            this.location.Name = "location";
            this.location.Width = 83;
            // 
            // responsible_dp
            // 
            this.responsible_dp.DataPropertyName = "responsible_dp";
            this.responsible_dp.HeaderText = "负责部门";
            this.responsible_dp.Name = "responsible_dp";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            // 
            // supplier_id
            // 
            this.supplier_id.DataPropertyName = "supplier_id";
            this.supplier_id.HeaderText = "供应商id";
            this.supplier_id.Name = "supplier_id";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "class";
            this.Column1.HeaderText = "分类";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "respon_user_id";
            this.Column2.HeaderText = "负责人";
            this.Column2.Name = "Column2";
            // 
            // EqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 568);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectDpBox);
            this.Controls.Add(this.selectByBuyTime2);
            this.Controls.Add(this.selectByBuyTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectBySer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectByIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updataEq);
            this.Controls.Add(this.deleteEq);
            this.Controls.Add(this.Reflash);
            this.Controls.Add(this.AddEq);
            this.Controls.Add(this.EqDataGridView);
            this.Name = "EqForm";
            this.Text = "EqForm";
            this.Load += new System.EventHandler(this.EqForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EqDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EqDataGridView;
        private DataGridViewTextBoxColumn users;
        private Button AddEq;
        private Button Reflash;
        private Button deleteEq;
        private Button updataEq;
        private Label label1;
        private Label label2;
        private TextBox selectByIdBox;
        private Label label3;
        private TextBox selectBySer;
        private Label label4;
        private TextBox selectByName;
        private Label label5;
        private DateTimePicker selectByBuyTime;
        private DateTimePicker selectByBuyTime2;
        private ComboBox selectDpBox;
        private Label label7;
        private Button selectButton;
        private Button button1;
        private Label label6;
        private Label label8;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn serial_number;
        private DataGridViewTextBoxColumn purchase_time;
        private DataGridViewTextBoxColumn warehousing_time;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn responsible_dp;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn supplier_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}