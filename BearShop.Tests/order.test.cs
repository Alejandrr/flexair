global using Xunit;
using BeerShop.Data;

namespace BearShop.Tests
{

    public class orderTest
    {
        [Fact]
        public void Order_Test_FIO_get()
        {
            var sut = new BeerShop.Data.order();
            string name, surname, patronymic, expected, actual;

            name = "Oleg"; surname = "Pietsukh"; patronymic = "Petrovich";

            sut.Name = name;
            sut.Surname = surname;
            sut.Patronymic = patronymic;

            expected = name + " " + surname + " " + patronymic;
            actual = sut.GetFIO();

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Order_Test_FIO_set()
        {
            var sut = new BeerShop.Data.order();
            string name, surname, patronymic, expected, actual;

            name = "Oleg"; surname = "Pietsukh"; patronymic = "Petrovich";

            sut.SetFIO(name, surname, patronymic);
            expected = name + surname + patronymic;
            actual = sut.Name + sut.Surname + sut.Patronymic;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Order_Test_Address()
        {
            var sut = new BeerShop.Data.order();
            var address = new BeerShop.Data.Address("Mayakovskogo", "Greece", "Vinnitsia");
            string expected, actual;



            expected = address.Country + " Ì." + address.City + " Âóë." + address.Street;
            sut.UserAddress = address.Country + "|" + address.City + "|" + address.Street;
            actual = sut.UserAddress;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Order_Test_Time()
        {
            var sut = new BeerShop.Data.order();
            DateTime dateTime;

            dateTime = DateTime.Now;
            sut.OrderTime = dateTime.ToString();

            Assert.StartsWith(dateTime.ToString().Substring(0, 8), sut.OrderTime);
        }
        [Fact]
        public void Order_AddToBasket_ShouldReturnLastAddedProduct()
        {
            var sut = new Product("Chips", 80);
            order ord = new order();

            ord.AddToBasket(new Product("Meet", 100));
            ord.AddToBasket(new Product("Dark beer", 200));
            ord.AddToBasket(sut);
            var LastAdded = ord.GetBasket().GetProductFromDatabase(ord.GetBasket().GetCount() - 1);
            string expected = sut.DataToStr(),
                   actual = LastAdded.DataToStr();


            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Order_AddToBasket_TotalCoastShouldBe15()
        {
            var sut = new order();

            sut.AddToBasket(new Product("Meet", 1));
            sut.AddToBasket(new Product("Beermix", 2));
            sut.AddToBasket(new Product("LAger", 3));
            sut.AddToBasket(new Product("Teteriv", 4));
            sut.AddToBasket(new Product("eL", 5));

            Assert.True(sut.GetBasket().GetTotalCoast() == 15);
        }
        [Fact]
        public void Order_GetBasket_ShouldReturnSameInstance()
        {
            var sut = new order();
            var value1 = sut.GetBasket();
            sut.AddToBasket(new Product("Food", 1));
            var value2 = sut.GetBasket();

            Assert.Same(value1,value2);
        }
        [Fact]
        public void Order_DeleteFromBasket_ShouldMakeBasketEmpty()
        {
            var sut = new order();
            sut.AddToBasket(new Product("food", 2));
            sut.DeleteFromBasket(0);
            
            Assert.True(sut.GetBasket().GetCount() == 0);
        }
        [Fact]
        public void Order_DeleteFromBasket_ShouldReturnNextItemAfterDeleted()
        {
            var sut = new order();
            var item1 = new Product("item1", 2);
            var item2 = new Product("item2", 3);
            sut.AddToBasket(item1);
            sut.AddToBasket(item2);
            sut.DeleteFromBasket(0);
            
            var result = sut.GetBasket().GetProductFromDatabase(0);
            Assert.Equal(item2,result);
        }
        [Fact]
        public void Order_DeleteFromBasket_ShouldThrowException()
        {
            var sut = new order();

            Assert.Throws<ArgumentOutOfRangeException>(delegate { sut.DeleteFromBasket(2); }) ;
        }
    }
}