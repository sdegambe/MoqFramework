namespace MoqFramework
{
    public interface IManagePersons
    {
        IPerson AddPerson(IPerson person);
        bool VerifyAge();
    }
}