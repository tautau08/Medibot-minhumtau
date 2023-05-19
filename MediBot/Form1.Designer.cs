namespace MediBot
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_User_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Recoverpassbutton = new System.Windows.Forms.Button();
            this.Show_Password = new System.Windows.Forms.CheckBox();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.Login_Button = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(53, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login To Your Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(29, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login_User_Name
            // 
            this.Login_User_Name.BackColor = System.Drawing.Color.White;
            this.Login_User_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Login_User_Name.Location = new System.Drawing.Point(35, 278);
            this.Login_User_Name.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Login_User_Name.Multiline = true;
            this.Login_User_Name.Name = "Login_User_Name";
            this.Login_User_Name.Size = new System.Drawing.Size(233, 24);
            this.Login_User_Name.TabIndex = 2;
            this.Login_User_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightPink;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "MediBot";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Recoverpassbutton);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Show_Password);
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Controls.Add(this.Login_Button);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Login_Password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Login_User_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(617, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 456);
            this.panel1.TabIndex = 4;
            // 
            // Recoverpassbutton
            // 
            this.Recoverpassbutton.Location = new System.Drawing.Point(213, 409);
            this.Recoverpassbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Recoverpassbutton.Name = "Recoverpassbutton";
            this.Recoverpassbutton.Size = new System.Drawing.Size(100, 28);
            this.Recoverpassbutton.TabIndex = 8;
            this.Recoverpassbutton.Text = "Click Here";
            this.Recoverpassbutton.UseVisualStyleBackColor = true;
            this.Recoverpassbutton.Click += new System.EventHandler(this.Recoverpassbutton_Click);
            // 
            // Show_Password
            // 
            this.Show_Password.AutoSize = true;
            this.Show_Password.Location = new System.Drawing.Point(35, 372);
            this.Show_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show_Password.Name = "Show_Password";
            this.Show_Password.Size = new System.Drawing.Size(18, 17);
            this.Show_Password.TabIndex = 6;
            this.Show_Password.UseVisualStyleBackColor = true;
            this.Show_Password.CheckedChanged += new System.EventHandler(this.Show_Password_CheckedChanged);
            // 
            // Login_Password
            // 
            this.Login_Password.BackColor = System.Drawing.Color.White;
            this.Login_Password.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login_Password.Location = new System.Drawing.Point(35, 338);
            this.Login_Password.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Login_Password.Multiline = true;
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(233, 24);
            this.Login_Password.TabIndex = 2;
            this.Login_Password.UseSystemPasswordChar = true;
            this.Login_Password.WordWrap = false;
            this.Login_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(29, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Forgot Password?";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(29, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MediBot.Properties.Resources.download_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(60, 367);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MediBot.Properties.Resources._removebg_preview__2_;
            this.pictureBox2.Location = new System.Drawing.Point(137, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediBot.Properties.Resources.lol_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC2.ButtonColor = System.Drawing.Color.PaleVioletRed;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Location = new System.Drawing.Point(333, 14);
            this.button_WOC2.Margin = new System.Windows.Forms.Padding(4);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC2.Size = new System.Drawing.Size(115, 39);
            this.button_WOC2.TabIndex = 5;
            this.button_WOC2.Text = "Sign Up";
            this.button_WOC2.TextColor = System.Drawing.Color.LightGray;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.BorderColor = System.Drawing.Color.Silver;
            this.Login_Button.ButtonColor = System.Drawing.Color.PaleVioletRed;
            this.Login_Button.FlatAppearance.BorderSize = 0;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(333, 401);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Login_Button.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.Login_Button.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Login_Button.Size = new System.Drawing.Size(95, 37);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.TextColor = System.Drawing.Color.LightGray;
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1076, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_User_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login_Password;
        private ePOSOne.btnProduct.Button_WOC Login_Button;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox Show_Password;
        private System.Windows.Forms.Button Recoverpassbutton;
        private System.Windows.Forms.Label label5;
    }
}

