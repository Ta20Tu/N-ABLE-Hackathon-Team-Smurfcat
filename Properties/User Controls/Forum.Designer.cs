namespace Smurfcat_proiect.Properties.User_Controls
{
    partial class Forum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            parere = new RichTextBox();
            send = new Button();
            pan = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // parere
            // 
            parere.BackColor = Color.White;
            parere.BorderStyle = BorderStyle.None;
            parere.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            parere.Location = new Point(43, 517);
            parere.Name = "parere";
            parere.Size = new Size(888, 62);
            parere.TabIndex = 1;
            parere.Text = "";
            parere.Enter += parere_Enter_1;
            // 
            // send
            // 
            send.BackColor = Color.White;
            send.Cursor = Cursors.Hand;
            send.FlatStyle = FlatStyle.Flat;
            send.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            send.Location = new Point(403, 620);
            send.Name = "send";
            send.Size = new Size(179, 42);
            send.TabIndex = 2;
            send.Text = "Trimite";
            send.UseVisualStyleBackColor = false;
            send.Click += send_Click;
            send.MouseEnter += send_MouseEnter;
            send.MouseLeave += send_MouseLeave;
            // 
            // pan
            // 
            pan.Dock = DockStyle.Top;
            pan.Location = new Point(0, 0);
            pan.Name = "pan";
            pan.Size = new Size(964, 475);
            pan.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 488);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "Scrie parerea ta aici...";
            // 
            // Forum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 43, 129);
            Controls.Add(label1);
            Controls.Add(pan);
            Controls.Add(send);
            Controls.Add(parere);
            Name = "Forum";
            Size = new Size(964, 702);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox parere;
        private Button send;
        private Panel pan;
        private Label label1;
    }
}
