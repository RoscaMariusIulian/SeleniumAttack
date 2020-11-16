namespace DictionaryAttack
{
    partial class GUI
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
            this.labelPasswords = new System.Windows.Forms.Label();
            this.labelUsernames = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.checkBoxBackground = new System.Windows.Forms.CheckBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelButton = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxButton = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.buttonHit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPasswords
            // 
            this.labelPasswords.AutoSize = true;
            this.labelPasswords.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelPasswords.Location = new System.Drawing.Point(403, 286);
            this.labelPasswords.Name = "labelPasswords";
            this.labelPasswords.Size = new System.Drawing.Size(102, 23);
            this.labelPasswords.TabIndex = 27;
            this.labelPasswords.Text = "Passwords: ";
            // 
            // labelUsernames
            // 
            this.labelUsernames.AutoSize = true;
            this.labelUsernames.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelUsernames.Location = new System.Drawing.Point(403, 242);
            this.labelUsernames.Name = "labelUsernames";
            this.labelUsernames.Size = new System.Drawing.Size(107, 23);
            this.labelUsernames.TabIndex = 26;
            this.labelUsernames.Text = "Usernames: ";
            
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelResults.Location = new System.Drawing.Point(393, 194);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(159, 30);
            this.labelResults.TabIndex = 25;
            this.labelResults.Text = "Results found:";
            // 
            // checkBoxBackground
            // 
            this.checkBoxBackground.AutoSize = true;
            this.checkBoxBackground.Location = new System.Drawing.Point(55, 138);
            this.checkBoxBackground.Name = "checkBoxBackground";
            this.checkBoxBackground.Size = new System.Drawing.Size(84, 17);
            this.checkBoxBackground.TabIndex = 24;
            this.checkBoxBackground.Text = "Background";
            this.checkBoxBackground.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(638, 92);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 23;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelButton.Location = new System.Drawing.Point(33, 302);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(149, 23);
            this.labelButton.TabIndex = 22;
            this.labelButton.Text = "xPath for Button:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelPass.Location = new System.Drawing.Point(33, 239);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(169, 23);
            this.labelPass.TabIndex = 21;
            this.labelPass.Text = "xPath for Password:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.labelUser.Location = new System.Drawing.Point(32, 178);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(174, 23);
            this.labelUser.TabIndex = 20;
            this.labelUser.Text = "xPath for Username:";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrl.Location = new System.Drawing.Point(85, 62);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(126, 30);
            this.labelUrl.TabIndex = 19;
            this.labelUrl.Text = "Insert Url:";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(36, 265);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(152, 20);
            this.textBoxPass.TabIndex = 18;
            // 
            // textBoxButton
            // 
            this.textBoxButton.Location = new System.Drawing.Point(37, 328);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(150, 20);
            this.textBoxButton.TabIndex = 17;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(36, 204);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(152, 20);
            this.textBoxUser.TabIndex = 16;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(86, 95);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(439, 20);
            this.textBoxUrl.TabIndex = 15;
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(544, 92);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(75, 23);
            this.buttonHit.TabIndex = 14;
            this.buttonHit.Text = "Hit!";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 411);
            this.Controls.Add(this.labelPasswords);
            this.Controls.Add(this.labelUsernames);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.checkBoxBackground);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.buttonHit);
            this.Name = "GUI";
            this.Text = "Graphical Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPasswords;
        private System.Windows.Forms.Label labelUsernames;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.CheckBox checkBoxBackground;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxButton;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button buttonHit;
    }
}

