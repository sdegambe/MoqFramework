namespace MoqFramework
{
    internal class Person : IPerson
    {
        public int PresonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAddress PersonAddress { get; set; }

        public int Age { get; set; }

        public bool VerifyAge()
        {
            return Age > 18;
        }

        public string GetName()
        {
            return FirstName;
        }
    }
}
