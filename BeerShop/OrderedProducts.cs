using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeerShop.Data;

namespace BeerShop
{
    public partial class OrderedProducts : Form
    {
        private OrderedBusket ordered;
        private MainMenu MainMenuForm;
        public OrderedProducts(MainMenu mainMenu )
        {
            InitializeComponent();
            MainMenuForm = mainMenu;
        }

      

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenuForm.Show();
            this.Close();
        }

        Point point;

        private void OrderedProducts_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void OrderedProducts_MouseMove(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                MessageBox.Show(ordered.GetOrder(dataGridView1.CurrentRow.Index).GetBasket().DataToString() + "Сумма : " + ordered.GetOrder(dataGridView1.CurrentRow.Index).GetBasket().GetTotalCoast().ToString(), "Деталі замовлення", MessageBoxButtons.OK);
            }
        }
        private void OrderedProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].HeaderText = "ФІО замовника";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].HeaderText = "Адреса";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[2].Width = 150;
            ordered = new OrderedBusket();
            ordered.Deserialize();
            for(int i = 0;i <ordered.GetCount();i++ )
            {
                order order = ordered.GetOrder(i);
                dataGridView1.Rows.Add(order.GetFIO(), order.UserAddress, order.OrderTime);
            }

        }
    }
}
