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
            this.supplier_id});
            this.EqDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.EqDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EqDataGridView.MultiSelect = false;
            this.EqDataGridView.Name = "EqDataGridView";
            this.EqDataGridView.RowHeadersVisible = false;
            this.EqDataGridView.RowTemplate.Height = 25;
            this.EqDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EqDataGridView.Size = new System.Drawing.Size(906, 527);
            this.EqDataGridView.TabIndex = 1;
            // 
            // AddEq
            // 
            this.AddEq.Location = new System.Drawing.Point(973, 41);
            this.AddEq.Name = "AddEq";
            this.AddEq.Size = new System.Drawing.Size(75, 23);
            this.AddEq.TabIndex = 2;
            this.AddEq.Text = "添加设备";
            this.AddEq.UseVisualStyleBackColor = true;
            this.AddEq.Click += new System.EventHandler(this.AddEq_Click);
            // 
            // Reflash
            // 
            this.Reflash.Location = new System.Drawing.Point(973, 85);
            this.Reflash.Name = "Reflash";
            this.Reflash.Size = new System.Drawing.Size(75, 23);
            this.Reflash.TabIndex = 3;
            this.Reflash.Text = "刷新";
            this.Reflash.UseVisualStyleBackColor = true;
            this.Reflash.Click += new System.EventHandler(this.Reflash_Click);
            // 
            // deleteEq
            // 
            this.deleteEq.Location = new System.Drawing.Point(973, 134);
            this.deleteEq.Name = "deleteEq";
            this.deleteEq.Size = new System.Drawing.Size(75, 23);
            this.deleteEq.TabIndex = 4;
            this.deleteEq.Text = "删除设备";
            this.deleteEq.UseVisualStyleBackColor = true;
            this.deleteEq.Click += new System.EventHandler(this.deleteEq_Click);
            // 
            // updataEq
            // 
            this.updataEq.Location = new System.Drawing.Point(973, 182);
            this.updataEq.Name = "updataEq";
            this.updataEq.Size = new System.Drawing.Size(75, 23);
            this.updataEq.TabIndex = 5;
            this.updataEq.Text = "修改设备";
            this.updataEq.UseVisualStyleBackColor = true;
            this.updataEq.Click += new System.EventHandler(this.updataEq_Click);
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
            // EqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
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

        }

        #endregion

        private DataGridView EqDataGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn serial_number;
        private DataGridViewTextBoxColumn purchase_time;
        private DataGridViewTextBoxColumn warehousing_time;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn responsible_dp;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn users;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn supplier_id;
        private Button AddEq;
        private Button Reflash;
        private Button deleteEq;
        private Button updataEq;
    }
}