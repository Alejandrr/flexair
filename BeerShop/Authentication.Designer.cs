
namespace BeerShop
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.enter_button = new System.Windows.Forms.Button();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.close_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.Transparent;
            this.enter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.enter_button, "enter_button");
            this.enter_button.ForeColor = System.Drawing.Color.Navy;
            this.enter_button.Name = "enter_button";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // password_TextBox
            // 
            this.password_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.password_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.password_TextBox, "password_TextBox");
            this.password_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.password_TextBox.Name = "password_TextBox";
            // 
            // login_TextBox
            // 
            this.login_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.login_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.login_TextBox, "login_TextBox");
            this.login_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.login_TextBox.Name = "login_TextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Name = "label3";
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.close_button, "close_button");
            this.close_button.Name = "close_button";
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Authentication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.login_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox login_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox close_button;
    }
}