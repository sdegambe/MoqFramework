namespace MoqFramework
{
    public interface IPerson
    {
        int PresonId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        IAddress PersonAddress { get; set; }
        int Age { get; set; }
        bool VerifyAge();
        string GetName();
    }
}