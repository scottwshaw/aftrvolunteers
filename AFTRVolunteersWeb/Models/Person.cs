namespace AFTRVolunteersWeb.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}