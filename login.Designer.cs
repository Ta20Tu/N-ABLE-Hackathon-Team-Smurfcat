

namespace Smurfcat_proiect
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            connect = new Button();
            creeaza_cont_btn = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(153, 126);
            label1.Name = "label1";
            label1.Size = new Size(302, 44);
            label1.TabIndex = 0;
            label1.Text = "BINE ATI VENIT!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(128, 170);
            label2.Name = "label2";
            label2.Size = new Size(352, 24);
            label2.TabIndex = 1;
            label2.Text = "Conecteaza-te sau creeaza un cont!";
            // 
            // username
            // 
            username.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(155, 330);
            username.Name = "username";
            username.Size = new Size(303, 32);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(155, 407);
            password.Name = "password";
            password.Size = new Size(303, 32);
            password.TabIndex = 2;
            // 
            // connect
            // 
            connect.BackColor = Color.FromArgb(192, 0, 192);
            connect.FlatStyle = FlatStyle.Flat;
            connect.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            connect.ForeColor = Color.White;
            connect.Location = new Point(192, 514);
            connect.Name = "connect";
            connect.Size = new Size(213, 59);
            connect.TabIndex = 3;
            connect.Text = "Conecteaza-te";
            connect.UseVisualStyleBackColor = false;
            connect.Click += connect_Click;
            connect.MouseEnter += connect_MouseEnter;
            connect.MouseLeave += connect_MouseLeave;
            // 
            // creeaza_cont_btn
            // 
            creeaza_cont_btn.AutoSize = true;
            creeaza_cont_btn.BackColor = Color.Transparent;
            creeaza_cont_btn.Cursor = Cursors.Hand;
            creeaza_cont_btn.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            creeaza_cont_btn.ForeColor = Color.LightGray;
            creeaza_cont_btn.Location = new Point(186, 716);
            creeaza_cont_btn.Name = "creeaza_cont_btn";
            creeaza_cont_btn.Size = new Size(225, 22);
            creeaza_cont_btn.TabIndex = 4;
            creeaza_cont_btn.Text = "Nu ai cont? Creeaza unul!";
            creeaza_cont_btn.Click += creeaza_cont_btn_Click;
            creeaza_cont_btn.MouseEnter += creeaza_cont_btn_MouseEnter;
            creeaza_cont_btn.MouseLeave += creeaza_cont_btn_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(160, 299);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(160, 377);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 6;
            label4.Text = "Parola";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_nite;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(535, 745);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(577, 787);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(creeaza_cont_btn);
            Controls.Add(connect);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button connect;
        private Label creeaza_cont_btn;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}