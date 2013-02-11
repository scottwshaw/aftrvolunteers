using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public Person CreatePerson(string firstname, string lastname, string emailAddress)
        {
            return new Person {FirstName = firstname, LastName = lastname, EmailAddress = emailAddress};
        }
    }
}