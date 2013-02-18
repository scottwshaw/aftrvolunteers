using AFTRVolunteersWeb.Repositories;
using NUnit.Framework;

namespace AFTRVolunteersTest.Models
{
    [TestFixture]
    public class PersonTest
    {
        private IPersonRepository repository = new PersonRepository();

        [Test]
        public void ShouldCreateNewPerson()
        {
            var v = repository.CreatePerson("test", "volunteer", "tvolunteer@mailinator.com");
            Assert.AreEqual("test", v.FirstName);
        }
        [Test]
        public void 
            ShouldMakeFullNameFromFirstAndLast()
        {
            var p = repository.CreatePerson("test", "volunteer", "a@b.c");
            Assert.AreEqual("test volunteer", p.FullName());
        }
    }
}
