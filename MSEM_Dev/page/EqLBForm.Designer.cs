namespace MSEM_Dev.page
{
    partial class EqLBForm
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
            this.showJustLending = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Button();
            this.lendingApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // showJustLending
            // 
            this.showJustLending.AutoSize = true;
            this.showJustLending.Location = new System.Drawing.Point(120, 397);
            this.showJustLending.Name = "showJustLending";
            this.showJustLending.Size = new System.Drawing.Size(111, 21);
            this.showJustLending.TabIndex = 1;
            this.showJustLending.Text = "只显示已借设备";
            this.showJustLending.UseVisualStyleBackColor = true;
            this.showJustLending.CheckStateChanged += new System.EventHandler(this.showJustLending_CheckStateChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(568, 424);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "归还";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lendingApply
            // 
            this.lendingApply.Location = new System.Drawing.Point(407, 424);
            this.lendingApply.Name = "lendingApply";
            this.lendingApply.Size = new System.Drawing.Size(114, 23);
            this.lendingApply.TabIndex = 3;
            this.lendingApply.Text = "申请借设备";
            this.lendingApply.UseVisualStyleBackColor = true;
            this.lendingApply.Click += new System.EventHandler(this.lendingApply_Click);
            // 
            // EqLBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
            this.Controls.Add(this.lendingApply);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showJustLending);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EqLBForm";
            this.Text = "EqLBForm";
            this.Load += new System.EventHandler(this.EqLBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private CheckBox showJustLending;
        private Button back;
        private Button lendingApply;
    }
}