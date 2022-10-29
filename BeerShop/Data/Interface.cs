using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BeerShop.Data
{
   interface IConverter
    {
        string DataToStr();
    }
    interface IFormater
    {
        void Deserialize();
        void Serialize();
    }
}
