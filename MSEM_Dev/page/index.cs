using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSEM_Dev.page;

namespace MSEM_Dev.page
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }


        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(userForm);
            userForm.Show();
        }

        private void 设备管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqForm eqForm = new EqForm();
            eqForm.FormBorderStyle= FormBorderStyle.None;
            eqForm.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eqForm);
            eqForm.Show();
        }

        private void 设备入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqWhForm eqWhForm = new EqWhForm();
            eqWhForm.FormBorderStyle = FormBorderStyle.None;
            eqWhForm.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eqWhForm);
            eqWhForm.Show();
        }

        private void 设备借还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqLBForm eqLBForm = new EqLBForm();
            eqLBForm.FormBorderStyle = FormBorderStyle.None;
            eqLBForm.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eqLBForm);
            eqLBForm.Show();
        }

        private void 设备申报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqDeclare eqDeclare = new EqDeclare();
            eqDeclare.FormBorderStyle = FormBorderStyle.None;
            eqDeclare.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eqDeclare);
            eqDeclare.Show();
        }

        private void 设备维修申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqReairForm eq = new EqReairForm();
            eq.FormBorderStyle = FormBorderStyle.None;
            eq.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eq);
            eq.Show();
        }

        private void 消息发布ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageForm message = new MessageForm();
            message.FormBorderStyle = FormBorderStyle.None;
            message.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(message);
            message.Show();
        }

        private void 申报审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            applicationReview applicationReview = new applicationReview();
            applicationReview.FormBorderStyle = FormBorderStyle.None;
            applicationReview.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(applicationReview);
            applicationReview.Show();
        }

        private void 设备维修申请受理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EqRepairReview eqRepairReview = new EqRepairReview();
            eqRepairReview.FormBorderStyle = FormBorderStyle.None;
            eqRepairReview.TopLevel = false;
            this.indexPanel.Controls.Clear();
            this.indexPanel.Controls.Add(eqRepairReview);
            eqRepairReview.Show();
        }
    }
}
