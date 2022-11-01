global using Xunit;
namespace BearShop.Tests
{
   
    public class orderTest
    {
        [Fact]
        public void Order_Test_FIO()
        {
            var sut = new BeerShop.Data.order();
            string name ,surname ,patronymic,expected,actual;

            name = "Oleg";surname =  "Pietsukh";patronymic = "Petrovich";
            
            sut.Name = name;
            sut.Surname = surname;
            sut.Patronymic = patronymic;

            expected = name + surname + patronymic;
            actual = sut.GetFIO();
            
            Assert.Matches(expected,actual);
          
        }
        [Fact]
        public void Order_Test_Address()
        {
            var sut = new BeerShop.Data.order();
            var address = new BeerShop.Data.Address("Mayakovskogo","Greece","Vinnitsia");
            string expected , actual;
           

            
            expected = address.Country + " Ì." + address.City + " Âóë." + address.Street;
            sut.UserAddress = address.GetFullAddress();
            actual = sut.UserAddress;
            Assert.Matches(expected, actual);
        }
        public void Order_Test_Time()
        {
            var sut = new BeerShop.Data.order();
            DateTime dateTime;

            dateTime = DateTime.Now;
            sut.OrderTime = dateTime.ToString();

            Assert.StartsWith(dateTime.ToString(), sut.OrderTime);
        }
    }
}