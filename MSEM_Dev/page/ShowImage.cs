using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSEM_Dev.page
{
    public partial class ShowImage : Form
    {
        public string EqName;

        public ShowImage()
        {
            InitializeComponent();
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Prod_Images/"+EqName+".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
