
namespace BeerShop
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.order_product = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.product_in_cart_button = new System.Windows.Forms.Button();
            this.delete_product_from_cart_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.check_ordered_products_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filter_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surname_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.patronymic_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.street_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 350);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(755, 143);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(225, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Перелік обраних товарів";
            // 
            // order_product
            // 
            this.order_product.BackColor = System.Drawing.Color.Transparent;
            this.order_product.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_product.ForeColor = System.Drawing.Color.Indigo;
            this.order_product.Image = ((System.Drawing.Image)(resources.GetObject("order_product.Image")));
            this.order_product.Location = new System.Drawing.Point(259, 508);
            this.order_product.Name = "order_product";
            this.order_product.Size = new System.Drawing.Size(222, 34);
            this.order_product.TabIndex = 30;
            this.order_product.Text = "Замовити обрані товари";
            this.order_product.UseVisualStyleBackColor = false;
            this.order_product.Click += new System.EventHandler(this.order_product_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(254, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Перелік товарів";
            // 
            // product_in_cart_button
            // 
            this.product_in_cart_button.BackColor = System.Drawing.Color.Transparent;
            this.product_in_cart_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_in_cart_button.ForeColor = System.Drawing.Color.Indigo;
            this.product_in_cart_button.Image = ((System.Drawing.Image)(resources.GetObject("product_in_cart_button.Image")));
            this.product_in_cart_button.Location = new System.Drawing.Point(426, 218);
            this.product_in_cart_button.Name = "product_in_cart_button";
            this.product_in_cart_button.Size = new System.Drawing.Size(332, 34);
            this.product_in_cart_button.TabIndex = 34;
            this.product_in_cart_button.Text = "Занести товар до кошику";
            this.product_in_cart_button.UseVisualStyleBackColor = false;
            this.product_in_cart_button.Click += new System.EventHandler(this.product_in_cart_button_Click);
            // 
            // delete_product_from_cart_button
            // 
            this.delete_product_from_cart_button.BackColor = System.Drawing.Color.Transparent;
            this.delete_product_from_cart_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_product_from_cart_button.ForeColor = System.Drawing.Color.Indigo;
            this.delete_product_from_cart_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_product_from_cart_button.Image")));
            this.delete_product_from_cart_button.Location = new System.Drawing.Point(12, 508);
            this.delete_product_from_cart_button.Name = "delete_product_from_cart_button";
            this.delete_product_from_cart_button.Size = new System.Drawing.Size(241, 34);
            this.delete_product_from_cart_button.TabIndex = 35;
            this.delete_product_from_cart_button.Text = "Видалити товар з кошику";
            this.delete_product_from_cart_button.UseVisualStyleBackColor = false;
            this.delete_product_from_cart_button.Click += new System.EventHandler(this.delete_product_from_cart_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(757, 139);
            this.dataGridView1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 16);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_button.InitialImage")));
            this.close_button.Location = new System.Drawing.Point(731, 1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(44, 38);
            this.close_button.TabIndex = 40;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("back_button.InitialImage")));
            this.back_button.Location = new System.Drawing.Point(-7, 1);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(59, 36);
            this.back_button.TabIndex = 41;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // check_ordered_products_button
            // 
            this.check_ordered_products_button.BackColor = System.Drawing.Color.Transparent;
            this.check_ordered_products_button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_ordered_products_button.ForeColor = System.Drawing.Color.Indigo;
            this.check_ordered_products_button.Image = ((System.Drawing.Image)(resources.GetObject("check_ordered_products_button.Image")));
            this.check_ordered_products_button.Location = new System.Drawing.Point(491, 508);
            this.check_ordered_products_button.Name = "check_ordered_products_button";
            this.check_ordered_products_button.Size = new System.Drawing.Size(276, 34);
            this.check_ordered_products_button.TabIndex = 42;
            this.check_ordered_products_button.Text = "Переглянути замовлені товари";
            this.check_ordered_products_button.UseVisualStyleBackColor = false;
            this.check_ordered_products_button.Click += new System.EventHandler(this.check_ordered_products_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(21, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Фільтр:";
            // 
            // filter_combobox
            // 
            this.filter_combobox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.filter_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_combobox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filter_combobox.ForeColor = System.Drawing.Color.Navy;
            this.filter_combobox.FormattingEnabled = true;
            this.filter_combobox.Items.AddRange(new object[] {
            "Цена",
            "Крепость",
            "Производитель"});
            this.filter_combobox.Location = new System.Drawing.Point(135, 222);
            this.filter_combobox.Name = "filter_combobox";
            this.filter_combobox.Size = new System.Drawing.Size(250, 31);
            this.filter_combobox.TabIndex = 43;
            this.filter_combobox.SelectedIndexChanged += new System.EventHandler(this.filter_combobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(21, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Одержувач";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(125, 587);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(76, 26);
            this.name_textBox.TabIndex = 46;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(51, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ім\'я -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(220, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Фамілія -";
            // 
            // surname_textBox
            // 
            this.surname_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_textBox.Location = new System.Drawing.Point(334, 587);
            this.surname_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surname_textBox.Name = "surname_textBox";
            this.surname_textBox.Size = new System.Drawing.Size(76, 26);
            this.surname_textBox.TabIndex = 51;
            this.surname_textBox.TextChanged += new System.EventHandler(this.surname_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(434, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 52;
            this.label7.Text = "По-батькові -";
            // 
            // patronymic_textBox
            // 
            this.patronymic_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic_textBox.Location = new System.Drawing.Point(595, 590);
            this.patronymic_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patronymic_textBox.Name = "patronymic_textBox";
            this.patronymic_textBox.Size = new System.Drawing.Size(76, 26);
            this.patronymic_textBox.TabIndex = 53;
            this.patronymic_textBox.TextChanged += new System.EventHandler(this.patronymic_textBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(21, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 54;
            this.label8.Text = "Адрес";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(19, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 55;
            this.label9.Text = "Країна -";
            // 
            // country_textBox
            // 
            this.country_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_textBox.Location = new System.Drawing.Point(125, 672);
            this.country_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(76, 26);
            this.country_textBox.TabIndex = 56;
            this.country_textBox.TextChanged += new System.EventHandler(this.country_textBox_TextChanged);
            // 
            // city_textBox
            // 
            this.city_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city_textBox.Location = new System.Drawing.Point(334, 674);
            this.city_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(76, 26);
            this.city_textBox.TabIndex = 57;
            this.city_textBox.TextChanged += new System.EventHandler(this.city_textBox_TextChanged);
            // 
            // street_textBox
            // 
            this.street_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.street_textBox.Location = new System.Drawing.Point(595, 674);
            this.street_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.street_textBox.Name = "street_textBox";
            this.street_textBox.Size = new System.Drawing.Size(76, 26);
            this.street_textBox.TabIndex = 58;
            this.street_textBox.TextChanged += new System.EventHandler(this.street_textBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(243, 672);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 26);
            this.label10.TabIndex = 59;
            this.label10.Text = "Місто -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(484, 674);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 26);
            this.label11.TabIndex = 60;
            this.label11.Text = "Вулиця -";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 712);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.street_textBox);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.country_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.patronymic_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.surname_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filter_combobox);
            this.Controls.Add(this.check_ordered_products_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_product_from_cart_button);
            this.Controls.Add(this.product_in_cart_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button product_in_cart_button;
        private System.Windows.Forms.Button delete_product_from_cart_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox close_button;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.Button check_ordered_products_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox filter_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surname_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox patronymic_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.TextBox street_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}