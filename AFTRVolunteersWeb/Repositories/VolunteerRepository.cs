using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        public Volunteer createVolunteer(string firstname, string lastname, string emailAddress)
        {
            return new Volunteer(firstname, lastname, emailAddress);
        }
    }
}