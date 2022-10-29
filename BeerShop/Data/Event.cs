using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeerShop.Data
{
    class Counter
    {
       
     
        private string[] data ;
        private int total;
        private int limit;
        public Counter()
        {
            total = 0;
        }
        public Counter(int lim)
        {
            limit = lim;
            data = new string[limit];
        }
        public void SetLimit(int lim)
        {
            limit = lim;
            data = new string[limit];
        }
        public void Refresh()
        {
            data = new string[limit];
            total = 0;
        }
        public void DataHandler(string data ,Enum value)
        {
            if(data == string.Empty)
            {
                Delete(value);
            }
            else
            {
                Add(data, value);
            }
        }
        
        public void  Delete(Enum value) {
            data[Convert.ToInt32(value)] = string.Empty;
            total--;
        }
        public void  Add(string data,Enum value) 
        {
            string AddedData = (string.IsNullOrWhiteSpace(data) == true) ? string.Empty : data;
            if (AddedData != string.Empty)
            {
                if (this.data[Convert.ToInt32(value)] == null)
                {
                    this.data[Convert.ToInt32(value)] = string.Empty;
                }
                if (this.data[Convert.ToInt32(value)] == string.Empty)
                {
                    total++;
                }
                this.data[Convert.ToInt32(value)] = AddedData;
            }
            if (total >= limit)                                                 //условие события
            {
                UserDataAddedEventArgs e = new UserDataAddedEventArgs();
                e.dataStr = this.data;e.total = total;
                DataWasFully(e);
            }

        }
      
        protected virtual void DataWasFully(UserDataAddedEventArgs e)       // Запуск события
        {
            UserDataAddedEventHandler handler = UserDataCompletely;
            if(handler!=null)
               handler(this, e);
        }
        public event UserDataAddedEventHandler UserDataCompletely;

        
    }
     delegate void UserDataAddedEventHandler(object sender, UserDataAddedEventArgs e);// Обработка события
    class UserDataAddedEventArgs : EventArgs
    {
        public int total { get; set; }
        public string[] dataStr { get; set; }
        
    }

   
}
