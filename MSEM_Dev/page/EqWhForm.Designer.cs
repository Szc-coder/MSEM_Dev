namespace MSEM_Dev.page
{
    partial class EqWhForm
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
            this.DpComBox = new System.Windows.Forms.ComboBox();
            this.buyTimeBox = new System.Windows.Forms.DateTimePicker();
            this.WhTimeBox = new System.Windows.Forms.DateTimePicker();
            this.numCob = new System.Windows.Forms.TextBox();
            this.EqNameBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.supllierBox = new System.Windows.Forms.ComboBox();
            this.claBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.serBox = new System.Windows.Forms.TextBox();
            this.单价 = new System.Windows.Forms.Label();
            this.onePriBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DpComBox
            // 
            this.DpComBox.FormattingEnabled = true;
            this.DpComBox.Location = new System.Drawing.Point(307, 54);
            this.DpComBox.Name = "DpComBox";
            this.DpComBox.Size = new System.Drawing.Size(121, 25);
            this.DpComBox.TabIndex = 0;
            // 
            // buyTimeBox
            // 
            this.buyTimeBox.Location = new System.Drawing.Point(575, 104);
            this.buyTimeBox.Name = "buyTimeBox";
            this.buyTimeBox.Size = new System.Drawing.Size(200, 23);
            this.buyTimeBox.TabIndex = 1;
            // 
            // WhTimeBox
            // 
            this.WhTimeBox.Location = new System.Drawing.Point(575, 184);
            this.WhTimeBox.Name = "WhTimeBox";
            this.WhTimeBox.Size = new System.Drawing.Size(200, 23);
            this.WhTimeBox.TabIndex = 2;
            // 
            // numCob
            // 
            this.numCob.Location = new System.Drawing.Point(307, 246);
            this.numCob.Name = "numCob";
            this.numCob.Size = new System.Drawing.Size(100, 23);
            this.numCob.TabIndex = 3;
            // 
            // EqNameBox
            // 
            this.EqNameBox.Location = new System.Drawing.Point(307, 134);
            this.EqNameBox.Name = "EqNameBox";
            this.EqNameBox.Size = new System.Drawing.Size(100, 23);
            this.EqNameBox.TabIndex = 4;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(575, 278);
            this.locationBox.Multiline = true;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(200, 98);
            this.locationBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 64);
            this.button1.TabIndex = 6;
            this.button1.Text = "入库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "负责部门";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "购买时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "入库时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "设备名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "设备数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "提供商";
            // 
            // supllierBox
            // 
            this.supllierBox.FormattingEnabled = true;
            this.supllierBox.Location = new System.Drawing.Point(307, 306);
            this.supllierBox.Name = "supllierBox";
            this.supllierBox.Size = new System.Drawing.Size(121, 25);
            this.supllierBox.TabIndex = 15;
            // 
            // claBox
            // 
            this.claBox.FormattingEnabled = true;
            this.claBox.Location = new System.Drawing.Point(307, 368);
            this.claBox.Name = "claBox";
            this.claBox.Size = new System.Drawing.Size(121, 25);
            this.claBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "分类";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "序列号";
            // 
            // serBox
            // 
            this.serBox.Location = new System.Drawing.Point(307, 197);
            this.serBox.Name = "serBox";
            this.serBox.Size = new System.Drawing.Size(100, 23);
            this.serBox.TabIndex = 19;
            // 
            // 单价
            // 
            this.单价.AutoSize = true;
            this.单价.Location = new System.Drawing.Point(239, 432);
            this.单价.Name = "单价";
            this.单价.Size = new System.Drawing.Size(32, 17);
            this.单价.TabIndex = 20;
            this.单价.Text = "单价";
            // 
            // onePriBox
            // 
            this.onePriBox.Location = new System.Drawing.Point(307, 429);
            this.onePriBox.Name = "onePriBox";
            this.onePriBox.Size = new System.Drawing.Size(100, 23);
            this.onePriBox.TabIndex = 21;
            // 
            // EqWhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
            this.Controls.Add(this.onePriBox);
            this.Controls.Add(this.单价);
            this.Controls.Add(this.serBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.claBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.supllierBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.EqNameBox);
            this.Controls.Add(this.numCob);
            this.Controls.Add(this.WhTimeBox);
            this.Controls.Add(this.buyTimeBox);
            this.Controls.Add(this.DpComBox);
            this.Name = "EqWhForm";
            this.Text = "EqWhForm";
            this.Load += new System.EventHandler(this.EqWhForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox DpComBox;
        private DateTimePicker buyTimeBox;
        private DateTimePicker WhTimeBox;
        private TextBox numCob;
        private TextBox EqNameBox;
        private TextBox locationBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox supllierBox;
        private ComboBox claBox;
        private Label label8;
        private Label label9;
        private TextBox serBox;
        private Label 单价;
        private TextBox onePriBox;
    }
}