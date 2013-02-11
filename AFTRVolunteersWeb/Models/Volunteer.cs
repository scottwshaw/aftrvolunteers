namespace AFTRVolunteersWeb.Models
{
    public class Volunteer
    {
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Volunteer(string firstname, string lastname, string emailAddress)
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailAddress;
        }
    }
}