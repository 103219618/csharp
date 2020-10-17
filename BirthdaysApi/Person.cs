namespace BirthdaysApi
{
    public class Person
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("Birthday")]
        public date Birthday { get; set; }

        public Person()
        {
        }

        public Person(string firstname, string lastname, date birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Birthday = birthday;
        }
    }
}