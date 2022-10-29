using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerShop.Data
{
   
  [Serializable]
    class Catalog:Database
    {
        public Catalog() : base()
        {
            this.Deserialize();
        }
        public Catalog(List<Product> products) : base(products) { }
        
        private static int CompareByName(Product left, Product right) =>
             left.name.CompareTo(right.name);
        private static int CompareByPrice(Product left, Product right) =>
           left.price.CompareTo(right.price);
        
        public void Sort(compareBy cmp) {
          
            if (cmp == compareBy.Alphabet)
                ProductsList.Sort(CompareByName);
          
            else if (cmp == compareBy.Price)
                ProductsList.Sort(CompareByPrice); 
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
            catch (FileNotFoundException)
            {
                File.Create(@"cat_bin");
                return;
            }

        }
    }
}
