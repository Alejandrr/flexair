using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerShop.Data
{
    [Serializable]
    public class Food : Product
    {
        public Food() : base()
        {
            type = "NONE";
            weight = 0;
        }
        public Food(string name, string type, int price, int weight) : base(name, price)
        {
            this.type = type;
            this.weight = weight;
        }
        public Food(Food food)
        {
            name = food.name;
            price = food.price;
            this.type = food.type;
            this.weight = food.weight;
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set 
            {
                if (value < 1000&&value>0)
                {
                    weight = value;
                }
                else
                {
                    throw new FoodWeightException("Заважке ,людина стільки не з'їсть :(");
                }
            }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set
            {
                if (value == "Риба" || value == "В'ялка" || value == "Снеки")
                {
                    type = value;
                }
                else
                {
                    throw new FoodTypeError("Неправильний тип закуски ");
                }
            }
        }
        public void SetAll(string name, int price, int weight, string type)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
            this.type = type;
        }
        public override string DataToStr()
        {
            return base.DataToStr() + "\n\tТип : " + type + "\n\tВага" + weight +" грам";
        }
    }
}
