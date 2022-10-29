using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
namespace BeerShop.Data
{
   
    [Serializable]
    public class Product:IConverter

    {
        private string Name;
        public string name
        {
            get { return Name; } set { Name = value; }
        }

        private int Price;
        public int price {
            get { return Price; }
            set {
                if (value < 1 || value > 10000)
                    throw new PriceException("Нашим покупцям даний товар не по кишені");
                Price = value;
            }
        }

        public Product(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public Product()
        {
            this.Name = "0";
            this.Price = 0;
        }
        public Product(Product product)
        {
            this.Name = product.Name;
            this.Price = product.Price;
        }

        virtual public string DataToStr() {
            {
                return "Назва товару : " + Name + "\n\tЦіна : " + Price +" грн";
            }
        }
    }
    [Serializable]
    public class Beer : Product
    {
        public Beer() : base()
        {
            this.AlcoholStrength = 0;
            this.Brand = "0";
        }
        public Beer(string Name, int Price, double AlcoholStrength, string Brand) : base(Name, Price)
        {
            this.AlcoholStrength = AlcoholStrength;
            this.Brand = Brand;
        }
        public Beer(Beer beer)
        {
            this.Brand = beer.Brand;
            this.AlcoholStrength = beer.AlcoholStrength;
            this.name = beer.name;
            this.price = beer.price;
        }
        private double AlcoholStrength { get; set; }
        public double alcoholStrenght { get { return AlcoholStrength; }
            set
            {
                if (value > 10 || value < 0)
                    throw new BeerStrenghtException("Пиво занадто міцне , це точно пиво?");
                AlcoholStrength = value;
            }
        }
        private string Brand { get; set; }
        public string brand { get { return Brand; } set { Brand = value; } }
        public override string DataToStr()
        {
            return base.DataToStr() + "\n\tМіцність : " + AlcoholStrength + " %"+"\n\tБренд : " + Brand;
        }
        public void SetAll(string name, int price, double alcoholStrength, string brand)
        {
            this.name = name;
            this.price = price;
            AlcoholStrength = alcoholStrength;
            Brand = brand;
        }

    }
  
}
