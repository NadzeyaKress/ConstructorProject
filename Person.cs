namespace ConstructorProject
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; } 
        
        public Person(string firstname, string lastName, Address address) 
        {
            FirstName = firstname;
            LastName = lastName;
            Address = address;
        }
    }
}
