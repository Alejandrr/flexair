using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace BeerShop.Data
{
    [Serializable]
    class AdminCatalog:Database
    {
        public AdminCatalog() : base() 
        {
        }
        public AdminCatalog(List<Product> list) : base(list) { }
        public void EditProductPrice(int id, int Price)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else
            ProductsList[id].price = Price;
        }
        public void EditProductsType(int id , string type)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else 
            ((Food)ProductsList[id]).Type = type;                              
        }
        public void EditProductWeight(int id , int weight)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else
            ((Food)ProductsList[id]).Weight = weight;
        }
        public void EditProductStrenght(int id, double AlcoholStrength)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else
            ((Beer)ProductsList[id]).alcoholStrenght = AlcoholStrength;
        }
        public void EditProductBrand(int id, string Brand)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else
            ((Beer)ProductsList[id]).brand = Brand;
        }
        public void EditProductName(int id, string Name)
        {
            if (id == -1)
                throw new EmptyDataGrid("Редагування");
            else
            ProductsList[id].name = Name;
        }
        public void PushProduct(Product pr)
        {
            ProductsList.Add(pr);
        }
        public void DeleteProduct(int id)
        {
            if (id == -1)
                throw new EmptyDataGrid("Видалення");
            else
            ProductsList.RemoveAt(id);
        }
        public override void Serialize()
        {
            BinaryFormatter _bin = new BinaryFormatter();

            using (Stream stream = File.Open(@"cat_bin", FileMode.OpenOrCreate))
            {
                try
                {
                    _bin.Serialize(stream, ProductsList);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message, "Database failed");
                    return;
                }
            }
        }
        public override void Deserialize()
        {
            ProductsList = new List<Product>();
            BinaryFormatter _bin = new BinaryFormatter();
            try
            {
                using (Stream stream = File.Open(@"cat_bin", FileMode.Open))
                {
                    try
                    {
                        ProductsList = (List<Product>)_bin.Deserialize(stream);
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(ex.Message, "Database failed");   
                        return;
                    }
                }
            }
            catch(FileNotFoundException )
            {
                File.Create(@"cat_bin");
                return;
            }

        }
    }
}
