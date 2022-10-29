
namespace BeerShop
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.back_button = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.lavel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.alcohol_TextBox = new System.Windows.Forms.TextBox();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.brand_TextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("back_button.InitialImage")));
            this.back_button.Location = new System.Drawing.Point(-8, 1);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(59, 36);
            this.back_button.TabIndex = 25;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_button.InitialImage")));
            this.close_button.Location = new System.Drawing.Point(688, 1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(44, 38);
            this.close_button.TabIndex = 26;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(725, 165);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Панель адміна";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Transparent;
            this.add_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.ForeColor = System.Drawing.Color.Indigo;
            this.add_button.Image = ((System.Drawing.Image)(resources.GetObject("add_button.Image")));
            this.add_button.Location = new System.Drawing.Point(538, 462);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(187, 34);
            this.add_button.TabIndex = 29;
            this.add_button.Text = "Додати товар";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.ForeColor = System.Drawing.Color.Indigo;
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.Location = new System.Drawing.Point(280, 462);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(198, 34);
            this.delete_button.TabIndex = 30;
            this.delete_button.Text = "Видалити товар";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Transparent;
            this.edit_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.ForeColor = System.Drawing.Color.Indigo;
            this.edit_button.Image = ((System.Drawing.Image)(resources.GetObject("edit_button.Image")));
            this.edit_button.Location = new System.Drawing.Point(10, 462);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(222, 34);
            this.edit_button.TabIndex = 31;
            this.edit_button.Text = "Редагувати товар";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // lavel2
            // 
            this.lavel2.AutoSize = true;
            this.lavel2.BackColor = System.Drawing.Color.Transparent;
            this.lavel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lavel2.ForeColor = System.Drawing.Color.Navy;
            this.lavel2.Location = new System.Drawing.Point(12, 306);
            this.lavel2.Name = "lavel2";
            this.lavel2.Size = new System.Drawing.Size(165, 23);
            this.lavel2.TabIndex = 32;
            this.lavel2.Text = "Назва товару:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(386, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Бренд товару:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(362, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Вміст алкоголю:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(28, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ціна товару:";
            // 
            // name_TextBox
            // 
            this.name_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.name_TextBox.Location = new System.Drawing.Point(184, 306);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(170, 27);
            this.name_TextBox.TabIndex = 36;
            // 
            // alcohol_TextBox
            // 
            this.alcohol_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.alcohol_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alcohol_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alcohol_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.alcohol_TextBox.Location = new System.Drawing.Point(557, 302);
            this.alcohol_TextBox.Name = "alcohol_TextBox";
            this.alcohol_TextBox.Size = new System.Drawing.Size(170, 27);
            this.alcohol_TextBox.TabIndex = 37;
            // 
            // price_TextBox
            // 
            this.price_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.price_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.price_TextBox.Location = new System.Drawing.Point(184, 347);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(170, 27);
            this.price_TextBox.TabIndex = 38;
            // 
            // brand_TextBox
            // 
            this.brand_TextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.brand_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brand_TextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brand_TextBox.ForeColor = System.Drawing.Color.Navy;
            this.brand_TextBox.Location = new System.Drawing.Point(557, 335);
            this.brand_TextBox.Name = "brand_TextBox";
            this.brand_TextBox.Size = new System.Drawing.Size(170, 27);
            this.brand_TextBox.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(557, 340);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 238);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Додати:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 507);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.brand_TextBox);
            this.Controls.Add(this.price_TextBox);
            this.Controls.Add(this.alcohol_TextBox);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lavel2);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label lavel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.TextBox alcohol_TextBox;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.TextBox brand_TextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}