using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Repositories
{
    public interface IVolunteerRepository
    {
        Volunteer createVolunteer(string firstname, string lastname, string emailAddress);
    }
}