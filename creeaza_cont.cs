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
    public partial class creeaza_cont : Form
    {
        public creeaza_cont()
        {
            InitializeComponent();
        }

        private void creeaza_cont_btn_2_Click(object sender, EventArgs e)
        {
            if (nume_creat.Text != "" && prenume_creat.Text != "" && email_creat.Text != "" && telefon_creat.Text != "" && parola_creat.Text != "")
            {
                MessageBox.Show("Cont creat cu succes!");
                SqlConnection con = new SqlConnection("Data Source = TATU\\SQLEXPRESS; Initial Catalog = Smurfcat; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users(nume, prenume, email, telefon, parola,usernames) values ('" + nume_creat.Text + "','" + prenume_creat.Text + "','" + email_creat.Text + "','" + telefon_creat.Text + "','" + parola_creat.Text + "','" + username_creat.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("A aparut o eroare!");
                }

            }
            else
            {
                MessageBox.Show("Username sau Parola necesare!");
            }
        }

        private void creeaza_cont_btn_2_MouseEnter(object sender, EventArgs e)
        {
            creeaza_cont_btn_2.Size = new Size(225, 69);
            creeaza_cont_btn_2.Location = new Point(180, 659);

        }

        private void creeaza_cont_btn_2_MouseLeave(object sender, EventArgs e)
        {
            creeaza_cont_btn_2.Size = new Size(215, 59);
            creeaza_cont_btn_2.Location = new Point(185, 664);
        }
    }
}
