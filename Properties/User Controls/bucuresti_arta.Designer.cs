﻿namespace Smurfcat_proiect.Properties.User_Controls
{
    partial class bucuresti_arta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bucuresti_arta));
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 58);
            label1.Name = "label1";
            label1.Size = new Size(829, 540);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // bucuresti_arta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(81, 43, 129);
            Controls.Add(label1);
            Name = "bucuresti_arta";
            Size = new Size(964, 702);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}
