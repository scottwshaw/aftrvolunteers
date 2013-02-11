using AFTRVolunteersWeb.Repositories;
using NUnit.Framework;

namespace AFTRVolunteersTest.Models
{
    [TestFixture]
    public class VolunteerTest
    {
        [Test]
        public void TestCreateVolunteer()
        {
            IVolunteerRepository repo = new VolunteerRepository();
            var v = repo.createVolunteer("test", "volunteer", "tvolunteer@mailinator.com");
            Assert.AreEqual("test", v.FirstName);
        }
    }
}
