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
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(170, 129);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(228, 32);
            this.FName.TabIndex = 0;
            this.FName.Text = "{Binding FName}";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(170, 252);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(312, 48);
            this.Email.TabIndex = 1;
            this.Email.Text = "{Binding Email}";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(170, 192);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(360, 48);
            this.Address.TabIndex = 1;
            this.Address.Text = "{Binding Address}";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(170, 313);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(354, 48);
            this.Number.TabIndex = 2;
            this.Number.Text = "{Binding Number}";
            // 
            // courselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}