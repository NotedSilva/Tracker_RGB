using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_TRACKBAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            painel1.BackColor = Color.FromArgb(track1.Value, track2.Value, track3.Value);
            label1.Text = track1.Value.ToString();
        }

        private void track2_Scroll(object sender, EventArgs e)
        {
            painel1.BackColor = Color.FromArgb(track1.Value, track2.Value, track3.Value);
            label2.Text = track2.Value.ToString();
        }

        private void track3_Scroll(object sender, EventArgs e)
        {
           painel1.BackColor = Color.FromArgb(track1.Value, track2.Value, track3.Value);
            label3.Text = track3.Value.ToString();
        }
    }
}
