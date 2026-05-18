using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear() {
            if (pb.Image == null)
            {
                pb.Image = new Bitmap(pb.Width, pb.Height);
            }
            using (Graphics g = Graphics.FromImage(pb.Image))
            {
                g.Clear(Color.White);
            }
            pb.Refresh();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
