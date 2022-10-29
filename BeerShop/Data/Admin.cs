using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerShop.Data
{
    class Admin
    {
        private  AdminCatalog DataBase;
      
        public Admin()
        {
            DataBase = null;
        }
       
        public Admin(Database database)
        {
            DataBase = (AdminCatalog)database;
        }

        public void AddDatabase(Database database)
        {
            DataBase = (AdminCatalog)database;
        }
        public void AddProductToDatabase(Product product)
        {
            DataBase.PushProduct(product);
        }
        public void DeleteProductFromDatabase(int id)
        {
            DataBase.DeleteProduct(id);
        }
        public void EditDatabaseProductName(int id, string Name)
        {
            DataBase.EditProductName(id, Name);
        }
        public void EditDatabaseProductPrice(int id,  int Price )
        {
            DataBase.EditProductPrice(id,  Price);
        }
        public void EditDatabaseProductWeight(int id , int weight)
        {
            DataBase.EditProductWeight(id, weight);
        }
        public void EditDatabseProductType(int id , string type)
        {
            DataBase.EditProductsType(id, type);
        }
        public void EditDatabaseProductStrength(int id,  double AlcoholStrength)
        {
            DataBase.EditProductStrenght(id,  AlcoholStrength);
        }
        public void EditDatabaseProductBrand(int id,  string Brand)
        {
            DataBase.EditProductBrand(id,  Brand);
        }
        public Product GetProductFromDatabase(int index)
        {
            return DataBase.GetProductFromDatabase(index);
        }
        public int GetCount()
        {
            return DataBase.GetCount();
        }
        
    }
}
