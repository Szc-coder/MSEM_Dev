namespace MSEM_Dev.page
{
    partial class applicationReview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eq_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eq_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apply_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eq_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheak = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.apply_dp,
            this.apply_user,
            this.eq_name,
            this.eq_num,
            this.state,
            this.apply_date,
            this.remark,
            this.eq_class,
            this.supplier_id,
            this.cheak});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // apply_dp
            // 
            this.apply_dp.HeaderText = "申请部门";
            this.apply_dp.Name = "apply_dp";
            // 
            // apply_user
            // 
            this.apply_user.HeaderText = "申请人";
            this.apply_user.Name = "apply_user";
            // 
            // eq_name
            // 
            this.eq_name.HeaderText = "设备名称";
            this.eq_name.Name = "eq_name";
            // 
            // eq_num
            // 
            this.eq_num.HeaderText = "申请数量";
            this.eq_num.Name = "eq_num";
            // 
            // state
            // 
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            // 
            // apply_date
            // 
            this.apply_date.HeaderText = "申请时间";
            this.apply_date.Name = "apply_date";
            // 
            // remark
            // 
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            // 
            // eq_class
            // 
            this.eq_class.HeaderText = "设备分类";
            this.eq_class.Name = "eq_class";
            // 
            // supplier_id
            // 
            this.supplier_id.HeaderText = "供应商";
            this.supplier_id.Name = "supplier_id";
            // 
            // cheak
            // 
            this.cheak.HeaderText = "选择";
            this.cheak.Name = "cheak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "同意";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择某一行的备注可以查看完整备注";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "驳回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // applicationReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "applicationReview";
            this.Text = "applicationReview";
            this.Load += new System.EventHandler(this.applicationReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn apply_dp;
        private DataGridViewTextBoxColumn apply_user;
        private DataGridViewTextBoxColumn eq_name;
        private DataGridViewTextBoxColumn eq_num;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn apply_date;
        private DataGridViewTextBoxColumn remark;
        private DataGridViewTextBoxColumn eq_class;
        private DataGridViewTextBoxColumn supplier_id;
        private DataGridViewCheckBoxColumn cheak;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}