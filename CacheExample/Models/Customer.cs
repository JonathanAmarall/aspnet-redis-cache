namespace CacheExample.Models
{
    public class Customer
    {
        protected Customer() { }
        public Customer(string name, string lastName)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
        }

        public Guid Id { get; private set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
    }
}
