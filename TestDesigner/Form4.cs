using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesigner
{
    public partial class PictureForm : Form
    {
        Bitmap bitmap;
        public PictureForm()
        {
            InitializeComponent();
        }
        public PictureForm(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            InitializeComponent();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = bitmap;
        }
    }
}
