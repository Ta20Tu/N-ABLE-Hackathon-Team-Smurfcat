using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Smurfcat_proiect.Properties.User_Controls
{
    public partial class Forum : UserControl
    {
        String user;
        public Forum(String u)
        {
            InitializeComponent();
            user = u;
            SqlConnection con = new SqlConnection("Data Source = TATU\\SQLEXPRESS; Initial Catalog = Smurfcat; Integrated Security = True");
            con.Open();

            int coordY = 30;
            String querry = "SELECT * FROM forum";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Label p = new Label();
                Label mes = new Label();
                p.BackColor = Color.Transparent;
                p.Font = new Font("Arial", 17F, FontStyle.Bold, GraphicsUnit.Point);
                p.ForeColor = Color.White;
                p.Location = new Point(60, coordY);
                p.TabIndex = 4;
                p.Size = new Size(150, 25);
                p.Text = dtable.Rows[i]["utilizator"].ToString() + " : ";
                p.TabIndex = 0;
                pan.Controls.Add(p);

                mes.BackColor = Color.Transparent;
                mes.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
                mes.ForeColor = Color.White;
                mes.Location = new Point(350, coordY);

                mes.Size = new Size(300, 37);
                mes.TabIndex = 4;
                mes.Text = dtable.Rows[i]["mesaj"].ToString();
                pan.Controls.Add(mes);
                coordY = coordY + 50;


            }
        }

        private void parere_Enter(object sender, EventArgs e)
        {

        }

        private void parere_Enter_1(object sender, EventArgs e)
        {
            if (parere.Text == "Scrie parerea ta...")
            {
                parere.Clear();
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (parere.Text != "")
            {

                SqlConnection con = new SqlConnection("Data Source = TATU\\SQLEXPRESS; Initial Catalog = Smurfcat; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into forum(utilizator, mesaj) values ('" + user + "','" + parere.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Mesaj trimis cu succes!");
                }
                else
                {
                    MessageBox.Show("A aparut o eroare!");
                }

            }
            else
            {
                MessageBox.Show("Campul pentru mesaj nu poate fi gol!");
            }
        }

        private void send_MouseEnter(object sender, EventArgs e)
        {
            send.BackColor = Color.FromArgb(192, 0, 192);
            send.ForeColor = Color.White;
        }

        private void send_MouseLeave(object sender, EventArgs e)
        {
            send.BackColor = Color.White;
            send.ForeColor = Color.Black;
        }
    }
}
