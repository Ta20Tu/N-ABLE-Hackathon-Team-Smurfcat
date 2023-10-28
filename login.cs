using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smurfcat_proiect
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void creeaza_cont_btn_MouseEnter(object sender, EventArgs e)
        {
            creeaza_cont_btn.Font = new Font(creeaza_cont_btn.Font, FontStyle.Underline);
        }

        private void creeaza_cont_btn_MouseLeave(object sender, EventArgs e)
        {
            creeaza_cont_btn.Font = new Font(creeaza_cont_btn.Font, FontStyle.Regular);
        }

        private void creeaza_cont_btn_Click(object sender, EventArgs e)
        {
            creeaza_cont cnt = new creeaza_cont();
            cnt.Show();

        }

        private void connect_Click(object sender, EventArgs e)
        {
            String u, p;
            if (username.Text != "" && password.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source = TATU\\SQLEXPRESS; Initial Catalog = Smurfcat; Integrated Security = True");
                con.Open();
                u = username.Text;
                p = password.Text;

                String querry = "SELECT * FROM users WHERE usernames = '" + username.Text + "' AND parola = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    u = username.Text;
                    p = password.Text;
                    Form1 f1 = new Form1(username.Text);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datele de conectare sunt gresite!");
                    username.Clear();
                    password.Clear();
                    username.Focus();
                }



            }
            else
            {
                MessageBox.Show("Username sau Parola necesare!");
            }
        }

        private void connect_MouseEnter(object sender, EventArgs e)
        {
            connect.Size = new Size(223, 69);
            connect.Location = new Point(187, 509);
        }

        private void connect_MouseLeave(object sender, EventArgs e)
        {
            connect.Size = new Size(213, 59);
            connect.Location = new Point(192, 514);
        }
    }

}
