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
    abstract class Database:IFormater
    {
      
        protected  List<Product> ProductsList;

        public Database()
        {
             ProductsList = new List<Product>();
        }
        public Database(List<Product> list)
        {
            ProductsList = list;
        }

        public Product GetProductFromDatabase(int index)
        {
            return ProductsList[index];
        }
        public int GetCount()
        {
            return ProductsList.Count();
        }


        abstract public void Serialize();
       
      
        abstract public void Deserialize();
        

        public List<Product> GetAll()
        {
            return new List<Product>(ProductsList);
        }
        public void SetAll(List<Product> list)
        {
            ProductsList = list;
        }
    }
}
