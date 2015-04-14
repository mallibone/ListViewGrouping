namespace ListViewGrouping.Model
{
    public class Person
    {
        public Person(string firstname, string lastname, string description)
        {
            Firstname = firstname;
            Lastname = lastname;
            Description = description;
        }

        public string Lastname { get; private set; }
        public string Firstname { get; private set; }

        public string Fullname { get { return Firstname + " " + Lastname; } }

        public string Description { get; private set; }
    }
}