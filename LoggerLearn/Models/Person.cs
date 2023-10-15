namespace LoggerLearn
{
    public class Person
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public DateOnly? BirthDay { get; set; }

        protected Person() { }
    }
}