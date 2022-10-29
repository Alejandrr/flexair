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
    class  OrderedBusket 
    {
        

        private List<order> orders;
        public OrderedBusket()
        {
            this.Deserialize();
        }
        public OrderedBusket(OrderedBusket ordered)
        {
            orders = ordered.orders;
        }
        public void PushOrder(order user)
        {
            orders.Add(user);
        }
        public void DeleteOrder(order user)
        {
            orders.Remove(user);
        }
        public void DeleteOrder(int pos)
        {
            orders.RemoveAt(pos);
        }
        public order  GetOrder(int pos)
        {
            return orders[pos];
        }
        public int GetCount()
        {
            return orders.Count();
        }
        public  void Serialize()
        {
            BinaryFormatter _bin = new BinaryFormatter();

            using (Stream stream = File.Open(@"ord_bin", FileMode.OpenOrCreate))
            {
                try
                {
                    _bin.Serialize(stream, orders);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message, "Database failed");
                    return;
                }
            }
        }
        public  void Deserialize()
        {
            orders = new List<order>();
            BinaryFormatter _bin = new BinaryFormatter();
            try
            {
                using (Stream stream = File.Open(@"ord_bin", FileMode.Open))
                {
                    try
                    {
                        orders = (List<order>)_bin.Deserialize(stream);
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
        ~OrderedBusket()
        {
            this.Serialize();
        }
    }
}
