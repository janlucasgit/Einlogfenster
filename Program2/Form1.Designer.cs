﻿namespace Program2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Ausgabe_Textbox = new TextBox();
            Eingabe = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(91, 62);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ausgabe_Textbox
            // 
            Ausgabe_Textbox.Enabled = false;
            Ausgabe_Textbox.Location = new Point(435, 167);
            Ausgabe_Textbox.Multiline = true;
            Ausgabe_Textbox.Name = "Ausgabe_Textbox";
            Ausgabe_Textbox.Size = new Size(250, 118);
            Ausgabe_Textbox.TabIndex = 1;
            // 
            // Eingabe
            // 
            Eingabe.Location = new Point(435, 73);
            Eingabe.Name = "Eingabe";
            Eingabe.PasswordChar = '•';
            Eingabe.Size = new Size(250, 47);
            Eingabe.TabIndex = 2;
            Eingabe.TextChanged += Eingabe_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Eingabe);
            Controls.Add(Ausgabe_Textbox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Ausgabe_Textbox;
        private TextBox Eingabe;
    }
}
