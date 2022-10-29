
namespace BeerShop
{
    partial class OrderedProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedProducts));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Товари замовлені";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(717, 139);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("back_button.InitialImage")));
            this.back_button.Location = new System.Drawing.Point(-8, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(59, 36);
            this.back_button.TabIndex = 42;
            this.back_button.TabStop = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_button.BackgroundImage")));
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.InitialImage = ((System.Drawing.Image)(resources.GetObject("close_button.InitialImage")));
            this.close_button.Location = new System.Drawing.Point(693, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(44, 38);
            this.close_button.TabIndex = 43;
            this.close_button.TabStop = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // OrderedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 207);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderedProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderedProducts";
            this.Load += new System.EventHandler(this.OrderedProducts_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrderedProducts_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrderedProducts_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox back_button;
        private System.Windows.Forms.PictureBox close_button;
    }
}