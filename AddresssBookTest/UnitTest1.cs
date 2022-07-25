using AddressBookADO;
namespace AddresssBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RetrieveContactByDate()
        {
            AddressBook addressBook = new AddressBook();
            var result = addressBook.RetrieveContactByDate();
            Assert.AreEqual("Nidhi" , result);
        }
        [TestMethod]
        public void CountContactByCity()
        {
            AddressBook addressBook = new AddressBook();
            var result = addressBook.RetrieveNumOfContactByCity();
            Assert.AreEqual(2, result);
        }
    }
}