using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class LargeImgForm : Form
    {
        Bitmap bitmap;
        string caption;
        public LargeImgForm()
        {
            InitializeComponent();
        }
        public LargeImgForm(Bitmap bitmap, string caption)
        {
            this.caption = caption;
            this.bitmap = new Bitmap(bitmap);
            InitializeComponent();
        }

        private void LargeImgForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = bitmap;
            this.Text = caption;
        }
    }
}
