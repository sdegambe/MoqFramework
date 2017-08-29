using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqFramework.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CreatePerson()
        {            
            var manager = new Mock<IManagePersons>();
            manager.SetupAllProperties();
            manager.Object.AddPerson(CreateMockPerson());
            manager.Setup(e => e.VerifyAge()).Returns(true);
            Assert.IsTrue(manager.Object.VerifyAge());
        }

        [TestMethod]

        public void Verify_Address()
        {
            var address = new Mock<IAddress>();

            address.Setup(e => e.PostCode).Returns("30-376");
            address.Setup(e => e.Street).Returns("maczki");
            address.Setup(e => e.GetPostCode()).Returns(address.Object.Street);
            Assert.AreSame(address.Object.GetPostCode(), "maczki");
        }

        [TestMethod]
        public void Check_Person_Age()
        {
            var age = new Mock<IPerson>();
            age.Setup(e => e.FirstName).Returns("tttt");
            age.Setup(e => e.Age).Returns(25);
            age.Setup(e => e.VerifyAge()).Returns(true);
            Assert.IsTrue(age.Object.VerifyAge());
        }



        private IPerson CreateMockPerson()
        {
            IPerson person = Mock.Of<IPerson>(e => e.FirstName == "test" && e.LastName == "test2" && e.Age == 100);
            var address = Mock.Of<IAddress>(e => e.PostCode == "30-376" && e.PersonId == 1 && e.Street == "maczki");
            person.PersonAddress = address;
            return person;
        }
    }
}
