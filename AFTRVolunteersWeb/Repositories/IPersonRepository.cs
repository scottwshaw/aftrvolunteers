using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Repositories
{
    public interface IPersonRepository
    {
        Person CreatePerson(string firstname, string lastname, string emailAddress);
    }
}