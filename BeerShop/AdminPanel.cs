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
    public partial class AdminPanel : Form
    {
        private Authentication AuthenticationForm;
        private AdminCatalog database;
        private Admin admin;
        public AdminPanel(Authentication authentication)
        {
            InitializeComponent();
            AuthenticationForm = authentication;
        }


        private void add_button_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(name_TextBox.Text) && !string.IsNullOrWhiteSpace(price_TextBox.Text ) && !string.IsNullOrWhiteSpace(alcohol_TextBox.Text))//exception
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (!string.IsNullOrWhiteSpace(brand_TextBox.Text))
                    {
                        Beer product;
                        try
                        {
                            product = new Beer(name_TextBox.Text, Convert.ToInt32(price_TextBox.Text), double.Parse(alcohol_TextBox.Text), brand_TextBox.Text);
                        }
                        catch(BeerStrenghtException ex) {
                            MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                            return;
                        }
                        catch(PriceException ex)
                        {
                            MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                            return;
                        }
                        catch(FormatException)
                        {
                            MessageBox.Show("Введіть корректно ціну та міцність","Error");
                            return;
                        }
                        admin.AddProductToDatabase(product);
                        dataGridView1.Rows.Add(product.name, product.price + " грн", product.alcoholStrenght +" %", product.brand);
                        alcohol_TextBox.Clear();
                        name_TextBox.Clear();
                        price_TextBox.Clear();
                        brand_TextBox.Clear();
                    }
                }
                else
                {
                    Food product;
                    try
                    {
                        product = new Food(name_TextBox.Text, comboBox1.SelectedItem.ToString(), Convert.ToInt32(price_TextBox.Text), Convert.ToInt32(alcohol_TextBox.Text));
                    }
                    catch (PriceException ex)
                    {
                        MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                        return;
                    }
                    catch(FoodTypeError ex)
                    {
                        MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                        return;
                    }
                    catch(FoodWeightException ex)
                    {
                        MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                        return;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введіть корректно ціну та вагу", "Error");
                        return;
                    }
                    
                    admin.AddProductToDatabase(product);
                    dataGridView1.Rows.Add(product.name, product.price + " грн", product.Weight+ " грамм", product.Type);
                    alcohol_TextBox.Clear();
                    name_TextBox.Clear();
                    price_TextBox.Clear();
                }
                
                
            }
           

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            database = new AdminCatalog();
            database.Deserialize();
            admin = new Admin(database);
            comboBox2.Items.Add("Пиво");
            comboBox2.Items.Add("Закуска");
            comboBox1.Items.AddRange(new string[]{ "Риба", "В'ялка", "Снеки"});
            label3.Text = "Вміст алкоголю :"; label2.Text = "Бренд товару :";
            brand_TextBox.Show();
            comboBox1.Hide();
            UpdateTable(dataGridView1,database);
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            database.Deserialize();

            Application.Exit();
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                try
                {
                    if (name_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductName(dataGridView1.CurrentRow.Index, name_TextBox.Text);
                        dataGridView1.CurrentRow.Cells[0].Value = name_TextBox.Text;
                    }
                    if (price_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductPrice(dataGridView1.CurrentRow.Index, Convert.ToInt32(price_TextBox.Text));
                        dataGridView1.CurrentRow.Cells[1].Value = price_TextBox.Text +" грн";
                    }
                    if (alcohol_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductStrength(dataGridView1.CurrentRow.Index, double.Parse(alcohol_TextBox.Text));
                        dataGridView1.CurrentRow.Cells[2].Value = alcohol_TextBox.Text + '%';
                    }
                    if (brand_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductBrand(dataGridView1.CurrentRow.Index, brand_TextBox.Text);
                        dataGridView1.CurrentRow.Cells[3].Value = brand_TextBox.Text;
                    }
                }
                catch (BeerStrenghtException ex)
                {
                    MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                    return;
                }
                catch (PriceException ex)
                {
                    MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                    return;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введіть корректно ціну та міцність", "Error");
                    return;
                }

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                try
                {
                    if (name_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductName(dataGridView1.CurrentRow.Index, name_TextBox.Text);
                        dataGridView1.CurrentRow.Cells[0].Value = name_TextBox.Text;
                    }
                    if (price_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductPrice(dataGridView1.CurrentRow.Index, Convert.ToInt32(price_TextBox.Text));
                        dataGridView1.CurrentRow.Cells[1].Value = price_TextBox.Text + " грн";
                    }
                    if (alcohol_TextBox.Text != string.Empty)
                    {
                        admin.EditDatabaseProductWeight(dataGridView1.CurrentRow.Index, Convert.ToInt32(alcohol_TextBox.Text));
                        dataGridView1.CurrentRow.Cells[2].Value = alcohol_TextBox.Text + " грамм";
                    }
                    admin.EditDatabseProductType(dataGridView1.CurrentRow.Index, comboBox1.Text);
                    dataGridView1.CurrentRow.Cells[3].Value = comboBox1.Text;
                }
                catch (PriceException ex)
                {
                    MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                    return;
                }
                catch (FoodTypeError ex)
                {
                    MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                    return;
                }
                catch (FoodWeightException ex)
                {
                    MessageBox.Show(ex.value, "Error", MessageBoxButtons.OK);
                    return;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введіть корректно ціну та вагу", "Error");
                    return;
                }
                catch (EmptyDataGrid ex)
                {
                    MessageBox.Show(ex.value, "ERORR", MessageBoxButtons.OK);
                    return;
                }

            }

            alcohol_TextBox.Clear();
            name_TextBox.Clear();
            brand_TextBox.Clear();
            price_TextBox.Clear();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            database.Serialize();
            AuthenticationForm.Show();  
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                admin.DeleteProductFromDatabase(dataGridView1.CurrentRow.Index);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch(EmptyDataGrid ex)
            {
                MessageBox.Show(ex.value, "ERORR", MessageBoxButtons.OK);
                return;
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

      
        
       private void dataGridView1_RowEnter(object sender , DataGridViewCellEventArgs e)
        {
            if(admin.GetProductFromDatabase(e.RowIndex) is Beer)
            {
                comboBox2.SelectedIndex = 0;
                label3.Text = "Вміст алкоголю :";label2.Text = "Бренд товару :";
                brand_TextBox.Show();
                comboBox1.Hide();
            }
            else if(admin.GetProductFromDatabase(e.RowIndex) is Food)
            {
                comboBox2.SelectedIndex= 1;
                label3.Text = "             Вага :"; label2.Text = "           Тип :";
                comboBox1.Show();
                brand_TextBox.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label3.Text = "Вміст алкоголю :"; label2.Text = "Бренд товару :";
                brand_TextBox.Show();
                comboBox1.Hide();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                label3.Text = "             Вага :"; label2.Text = "           Тип :";
                comboBox1.Show();
                brand_TextBox.Hide();
            }
        }

    }
}
