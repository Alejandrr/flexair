using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace BeerShop.Data
{
   
    [Serializable]
    public class order
    {
        public order()
        {
            UserBasket = new Basket();
            userAddress = new Address();
            name = surname = patronymic = string.Empty;
        }
        private string name;
        private DateTime orderTime;
        public string  OrderTime
        {
            get
            {
                return orderTime.ToString().Remove(orderTime.ToString().Length - 3) ;
            }
            set
            {
                orderTime=DateTime.Now;
            }
        }
        public string Name { get { return name; } set { name = value; } }
        private string surname;
        public string Surname { get { return surname; } set { surname = value; } }
        private string patronymic;
        public  string Patronymic { get { return patronymic; } set { patronymic = value; } }
        private Address userAddress;
        public string UserAddress { get { return userAddress.GetFullAddress(); } set { userAddress.SetFullAddress(value); } }
        private Basket UserBasket;
       
        public Basket GetBasket()
        {
            return UserBasket;
        }
        public void AddToBasket(Product product) {
            UserBasket.PushProduct(product);
        }
        public void DeleteFromBasket(int id)
        {
            UserBasket.DeleteProduct(id);
        }
        public  string GetFIO()
        {
            return name + " " + surname + " " + patronymic;
        }
        public void SetFIO(string Name,string Surname,string Patronymic)
        {
            name = Name;surname = Surname;patronymic = Patronymic;
        }
        ~order()
        {
            
        }
    }
    
}
