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
    
    public partial class MainMenu : Form
    {
        public MainMenu(Authentication authentication)
        {
            InitializeComponent();
            this.authenticationForm = authentication;
        }
        private Authentication authenticationForm;
        private order user;
        private Catalog database;
        private OrderedBusket orderedBusket;
        private Counter counter;
        private Counter counter_fio; 
        private void check_ordered_products_button_Click(object sender, EventArgs e)
        {
            orderedBusket.Serialize();
            OrderedProducts orderedProducts = new OrderedProducts(this);
            orderedProducts.Show();
            this.Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            authenticationForm.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

            database = new Catalog();
            user = new order();
            orderedBusket = new OrderedBusket();


            counter = new Counter(3);
            counter_fio = new Counter(3);
            counter.UserDataCompletely += AdressReceived;
            counter_fio.UserDataCompletely += FIOReceived;
            UpdateTable(dataGridView1, database);
            UpdateTable(dataGridView2, user.GetBasket());

            filter_combobox.Items.Clear();
            filter_combobox.Items.Add("Назва");
            filter_combobox.Items.Add("Ціна");
        }

        Point point;

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void order_product_Click(object sender, EventArgs e)
        {
            if (user.GetBasket().GetCount() != 0)
            {
                if (!string.IsNullOrWhiteSpace(user.UserAddress)&& !user.UserAddress.Equals(" М. Вул."))
                    {
                    if (!string.IsNullOrWhiteSpace(user.GetFIO()))
                    {
                        user.OrderTime = string.Empty;
                        orderedBusket.PushOrder(user);
                        user = new order();


                        name_textBox.Clear();
                        surname_textBox.Clear();
                        patronymic_textBox.Clear();

                        street_textBox.Clear();
                        city_textBox.Clear();
                        country_textBox.Clear();
                        counter.Refresh();
                        counter_fio.Refresh();
                        UpdateTable(dataGridView2, user.GetBasket());
                    }
                    else
                    {
                        MessageBox.Show("Заповніть ФІО отримувача", "Error", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {
                    MessageBox.Show("Вкажіть адресу", "Error", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Виберіть товари", "Error", MessageBoxButtons.OKCancel);
            }

        }

        private void product_in_cart_button_Click(object sender, EventArgs e)
        {
            Product product;
            try
            {
                product =  database.GetProductFromDatabase(dataGridView1.CurrentRow.Index);
                Exception exd =new NullReferenceException();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "System erorr");
                return;
            }
            user.AddToBasket(product);
            if (product is Beer)
            {
                dataGridView2.Rows.Add(product.name, product.price + " грн", ((Beer)product).alcoholStrenght + " %", ((Beer)product).brand);
            }
            else
            {
                dataGridView2.Rows.Add(product.name, product.price+ " грн", ((Food)product).Weight+"грамм", ((Food)product).Type);
            }
           
        }

        private void UpdateTable(DataGridView table, Database database)
        {
            table.Rows.Clear();
            table.ColumnCount = 4;
            table.Columns[0].HeaderText = "Назва товару";
            table.Columns[0].Width = 250;
            table.Columns[1].HeaderText = "Ціна товару";
            table.Columns[1].Width = 120;
            table.Columns[2].HeaderText = "Вміст алкоголю/Вага";
            table.Columns[3].HeaderText = "Бренд/Тип";
            table.Columns[3].Width = 217;
            for (int i = 0; i < database.GetCount(); i++)
            {
                Product product = database.GetProductFromDatabase(i);
                if (product is Beer)
                {
                    table.Rows.Add(product.name, product.price + " грн", ((Beer)product).alcoholStrenght + " %", ((Beer)product).brand);
                }
                else
                {
                    table.Rows.Add(product.name, product.price + " грн", ((Food)product).Weight + " грамм", ((Food)product).Type);
                }
            }
        }
        private void UpdateTable(DataGridView table, Basket database)
        {
            table.Rows.Clear();
            table.ColumnCount = 4;
            table.Columns[0].HeaderText = "Назва товару";
            table.Columns[0].Width = 250;
            table.Columns[1].HeaderText = "Ціна товару";
            table.Columns[1].Width = 120;
            table.Columns[2].HeaderText = "Вміст алкоголю";
            table.Columns[3].HeaderText = "Бренд";
            table.Columns[3].Width = 217;
            for (int i = 0; i < database.GetCount(); i++)
            {
                Product product = database.GetProductFromDatabase(i);
                if (product is Beer)
                {
                    table.Rows.Add(product.name, product.price+" грн", ((Beer)product).alcoholStrenght + " %", ((Beer)product).brand);
                }
                else
                {
                    table.Rows.Add(product.name, product.price + " грн", ((Food)product).Weight + " грамм", ((Food)product).Type);
                }
            }
        }


        private void filter_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (filter_combobox.SelectedIndex == 0)
            {
                database.Sort(compareBy.Alphabet);
            }
            else if (filter_combobox.SelectedIndex == 1)
            {
                database.Sort(compareBy.Price);

            }

            UpdateTable(dataGridView1, database);
        }


        private void surname_textBox_TextChanged(object sender, EventArgs e)
        {
            counter_fio.DataHandler(surname_textBox.Text,client.surname);
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            counter_fio.DataHandler(name_textBox.Text,client.name);
        }

        private void patronymic_textBox_TextChanged(object sender, EventArgs e)
        {
            counter_fio.DataHandler(patronymic_textBox.Text,client.patronimic);
        }

        private void country_textBox_TextChanged(object sender, EventArgs e)
        {
            counter.DataHandler(country_textBox.Text, address.country);
        }

        private void city_textBox_TextChanged(object sender, EventArgs e)
        {
            counter.DataHandler(city_textBox.Text, address.city);
        }

        private void street_textBox_TextChanged(object sender, EventArgs e)
        {
            counter.DataHandler(street_textBox.Text, address.street);
        }

        private void FIOReceived(object sender ,UserDataAddedEventArgs e)
        {
            user.SetFIO(e.dataStr[0] ,e.dataStr[1] ,e.dataStr[2]);
        }
        private void AdressReceived(object sender, UserDataAddedEventArgs e)
        {
          user.UserAddress =  e.dataStr[0] + '|' + e.dataStr[1] + '|' + e.dataStr[2];
        }

       
        private void delete_product_from_cart_button_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 1)
            {



                user.DeleteFromBasket(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }

        
    }
}
