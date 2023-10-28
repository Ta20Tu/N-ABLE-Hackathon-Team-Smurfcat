using Smurfcat_proiect.Properties.User_Controls;

namespace Smurfcat_proiect
{

    public partial class Form1 : Form
    {
        public String user;
        int x = 0;
        int var = 0;
        public Form1(String s1)
        {
            InitializeComponent();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();


            label1.Text = s1;
            Bucuresti_btn.Hide();
            Brasov_btn.Hide();
            Sibiu_btn.Hide();
            Cluj_btn.Hide();
            Acasa a = new Acasa();
            addUserControl(a);

        }

        public String val
        {
            get { return user; }
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(uc);
            uc.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelnav.Height = acasa_btn.Height;
            panelnav.Top = acasa_btn.Top;
            panelnav.Left = acasa_btn.Left;

        }

        private void orase_btn_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            label2.Text = "Forum";
            panelnav.Height = orase_btn.Height;
            panelnav.Top = orase_btn.Top;
            panelnav.Left = orase_btn.Left;
            if (x % 2 == 0)
            {
                Bucuresti_btn.Show();
                Brasov_btn.Show();
                Sibiu_btn.Show();
                Cluj_btn.Show();
            }
            else
            {
                Bucuresti_btn.Hide();
                Brasov_btn.Hide();
                Sibiu_btn.Hide();
                Cluj_btn.Hide();
            }
            x++;
        }

        private void acasa_btn_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panelnav.Height = acasa_btn.Height;
            panelnav.Top = acasa_btn.Top;
            panelnav.Left = acasa_btn.Left;
            label2.Text = "Acasa";
            Acasa a = new Acasa();
            addUserControl(a);

        }

        private void forum_btn_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panelnav.Height = forum_btn.Height;
            panelnav.Top = forum_btn.Top;
            panelnav.Left = forum_btn.Left;
            label2.Text = "Forum";
            Forum f = new Forum(label1.Text);
            addUserControl(f);
        }
        ////////////////////////////////////////////////////////////////
        private void acasa_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void acasa_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void forum_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void forum_btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void orase_btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void orase_btn_MouseLeave(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////
        private void acasa_btn_Enter(object sender, EventArgs e)
        {
            acasa_btn.BackColor = Color.FromArgb(42, 16, 74);
        }

        private void acasa_btn_Leave(object sender, EventArgs e)
        {
            acasa_btn.BackColor = Color.FromArgb(53, 21, 93);
        }

        private void forum_btn_Enter(object sender, EventArgs e)
        {
            forum_btn.BackColor = Color.FromArgb(42, 16, 74);
        }

        private void forum_btn_Leave(object sender, EventArgs e)
        {
            forum_btn.BackColor = Color.FromArgb(53, 21, 93);
        }

        private void orase_btn_Enter(object sender, EventArgs e)
        {
            orase_btn.BackColor = Color.FromArgb(42, 16, 74);
        }

        private void orase_btn_Leave(object sender, EventArgs e)
        {
            orase_btn.BackColor = Color.FromArgb(53, 21, 93);
        }

        private void Bucuresti_btn_Click(object sender, EventArgs e)
        {
            label2.Text = "Bucuresti";
            container.Controls.Clear();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
            var = 1;
        }

        private void Brasov_btn_Click(object sender, EventArgs e)
        {
            label2.Text = "Brasov";
            container.Controls.Clear();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
            var = 2;
        }

        private void Sibiu_btn_Click(object sender, EventArgs e)
        {
            label2.Text = "Sibiu";
            container.Controls.Clear();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
            var = 3;
        }

        private void Cluj_btn_Click(object sender, EventArgs e)
        {
            label2.Text = "Cluj";
            container.Controls.Clear();
            panel4.Show();
            panel5.Show();
            panel6.Show();
            panel7.Show();
            var = 4;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                Bucuresti_concerte f = new Bucuresti_concerte();
                addUserControl(f);
            }
            else if (var == 2)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                brasov_concerte f = new brasov_concerte();
                addUserControl(f);
            }
            else if (var == 3)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                sibiu_concerte f = new sibiu_concerte();
                addUserControl(f);
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                bucuresti_dining f = new bucuresti_dining();
                addUserControl(f);
            }
            else if (var == 2)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                brasov_dining f = new brasov_dining();
                addUserControl(f);
            }
            else if (var == 3)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                sibiu_dining f = new sibiu_dining();
                addUserControl(f);
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                bucuresti_arta f = new bucuresti_arta();
                addUserControl(f);
            }
            else if (var == 2)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                brasov_arte f = new brasov_arte();
                addUserControl(f);
            }
            else if (var == 3)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                sibiu_arte f = new sibiu_arte();
                addUserControl(f);
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                bucurestii_spatii f = new bucurestii_spatii();
                addUserControl(f);
            }
            else if (var == 2)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                brasov_spatii f = new brasov_spatii();
                addUserControl(f);
            }
            else if (var == 3)
            {
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                panel7.Hide();
                sibiu_spatii f = new sibiu_spatii();
                addUserControl(f);
            }
        }
    }
}