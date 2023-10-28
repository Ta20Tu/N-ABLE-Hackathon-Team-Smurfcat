using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smurfcat_proiect.Properties.User_Controls
{
    public partial class Acasa : UserControl
    {
        public Acasa()
        {
            InitializeComponent();
            text_bucuresti.Location = new Point(1500, 1500);
            label6.Location = new Point(1500, 1500);
            label7.Location = new Point(1500, 1500);
            label8.Location = new Point(1500, 1500);

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            label1.Location = new Point(58, 30);
            text_bucuresti.Location = new Point(56, 94);

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {

            label1.Location = new Point(58, 136);
            text_bucuresti.Location = new Point(1500, 1500);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text_bucuresti_MouseEnter(object sender, EventArgs e)
        {

        }

        private void text_bucuresti_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            label2.Location = new Point(76, 30);
            label6.Location = new Point(54, 95);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            label2.Location = new Point(76, 136);
            label6.Location = new Point(1500, 1500);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Location = new Point(101, 30);
            label7.Location = new Point(57, 91);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Location = new Point(101, 138);
            label7.Location = new Point(1500, 1500);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            label5.Location = new Point(103, 30);
            label8.Location = new Point(54, 91);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            label5.Location = new Point(103, 138);
            label8.Location = new Point(1500, 1500);
        }
    }
}
