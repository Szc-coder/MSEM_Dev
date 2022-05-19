namespace MSEM_Dev.page
{
    partial class EqDeclare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.resonBox = new System.Windows.Forms.TextBox();
            this.eqNumBox = new System.Windows.Forms.TextBox();
            this.superBox = new System.Windows.Forms.ComboBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "申请设备名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "申请数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "详细购买原因、理由";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "供应商";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "分类";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(378, 90);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 5;
            // 
            // resonBox
            // 
            this.resonBox.AcceptsReturn = true;
            this.resonBox.Location = new System.Drawing.Point(378, 314);
            this.resonBox.Multiline = true;
            this.resonBox.Name = "resonBox";
            this.resonBox.Size = new System.Drawing.Size(410, 120);
            this.resonBox.TabIndex = 6;
            // 
            // eqNumBox
            // 
            this.eqNumBox.Location = new System.Drawing.Point(667, 90);
            this.eqNumBox.Name = "eqNumBox";
            this.eqNumBox.Size = new System.Drawing.Size(100, 23);
            this.eqNumBox.TabIndex = 7;
            // 
            // superBox
            // 
            this.superBox.FormattingEnabled = true;
            this.superBox.Location = new System.Drawing.Point(667, 218);
            this.superBox.Name = "superBox";
            this.superBox.Size = new System.Drawing.Size(121, 25);
            this.superBox.TabIndex = 8;
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(378, 218);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(121, 25);
            this.classBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "提交申请";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EqDeclare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.superBox);
            this.Controls.Add(this.eqNumBox);
            this.Controls.Add(this.resonBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EqDeclare";
            this.Text = "EqDeclare";
            this.Load += new System.EventHandler(this.EqDeclare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameBox;
        private TextBox resonBox;
        private TextBox eqNumBox;
        private ComboBox superBox;
        private ComboBox classBox;
        private Button button1;
    }
}