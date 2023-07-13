namespace ccis_roadmap
{
    partial class courselist
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
            this.FName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(272, 121);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(228, 32);
            this.FName.TabIndex = 0;
            this.FName.Text = "{Binding FName}";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(272, 226);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(208, 32);
            this.Email.TabIndex = 1;
            this.Email.Text = "{Binding Email}";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(272, 175);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(240, 32);
            this.Address.TabIndex = 1;
            this.Address.Text = "{Binding Address}";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(272, 281);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(236, 32);
            this.Number.TabIndex = 2;
            this.Number.Text = "{Binding Number}";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(278, 335);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(148, 36);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(532, 115);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(356, 44);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.Text = "TName";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.Location = new System.Drawing.Point(532, 169);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(356, 44);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.Text = "TAddress";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(532, 220);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(356, 44);
            this.emailTextbox.TabIndex = 6;
            this.emailTextbox.Text = "TEmail";
            // 
            // numberTextbox
            // 
            this.numberTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextbox.Location = new System.Drawing.Point(532, 275);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.Size = new System.Drawing.Size(356, 44);
            this.numberTextbox.TabIndex = 7;
            this.numberTextbox.Text = "TNumber";
            // 
            // courselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 482);
            this.Controls.Add(this.numberTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FName);
            this.Name = "courselist";
            this.Text = "courselist";
            this.Load += new System.EventHandler(this.courselist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox numberTextbox;
    }
}