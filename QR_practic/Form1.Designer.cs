namespace QR_practic
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
            label1 = new Label();
            t_login = new TextBox();
            t_password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Reg_Button = new Button();
            Ent_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // t_login
            // 
            t_login.Location = new Point(12, 68);
            t_login.Name = "t_login";
            t_login.Size = new Size(362, 23);
            t_login.TabIndex = 1;
            // 
            // t_password
            // 
            t_password.Location = new Point(12, 128);
            t_password.Name = "t_password";
            t_password.Size = new Size(362, 23);
            t_password.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 4;
            label3.Text = "Enter password";
            // 
            // Reg_Button
            // 
            Reg_Button.Location = new Point(12, 171);
            Reg_Button.Name = "Reg_Button";
            Reg_Button.Size = new Size(178, 23);
            Reg_Button.TabIndex = 5;
            Reg_Button.Text = "registration";
            Reg_Button.UseVisualStyleBackColor = true;
            Reg_Button.Click += Reg_Button_Click;
            // 
            // Ent_Button
            // 
            Ent_Button.Location = new Point(196, 171);
            Ent_Button.Name = "Ent_Button";
            Ent_Button.Size = new Size(178, 23);
            Ent_Button.TabIndex = 6;
            Ent_Button.Text = "Entry";
            Ent_Button.UseVisualStyleBackColor = true;
            Ent_Button.Click += Ent_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 268);
            Controls.Add(Ent_Button);
            Controls.Add(Reg_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(t_password);
            Controls.Add(t_login);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox t_login;
        private TextBox t_password;
        private Label label2;
        private Label label3;
        private Button Reg_Button;
        private Button Ent_Button;
    }
}
