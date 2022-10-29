using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace BeerShop.Data
{
    [Serializable]
    public class Basket
    {
        private List<Product> ProductsList;
        public Basket()
        {
            ProductsList = new List<Product>();
        }
        public Product GetProductFromDatabase(int index)
        {
            return ProductsList[index];
        }
        public int GetTotalCoast()
        {
            int coast = 0;
            foreach (Product product in ProductsList)
            {
                coast += product.price;
            }
            return coast;
        }
        public void PushProduct(Product pr)
        {
            ProductsList.Add(pr);
        }
        public void DeleteProduct(int id)
        {
            ProductsList.RemoveAt(id);
        }
        public int GetCount()
        {
            return ProductsList.Count();
        }

        public string DataToString()
        {
            string toReturn = string.Empty;
            int counter = 0;
            foreach (Product product in ProductsList)
            {
                ++counter;
                toReturn += counter.ToString() + ". " + product.DataToStr() + '\n';
            }
            return toReturn;
        }

    }

}