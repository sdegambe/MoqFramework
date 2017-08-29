namespace MoqFramework
{
    public interface IAddress
    {
        int PersonId { get; set; }
        string Street { get; set; }
        string PostCode { get; set; }
        bool Verify(IAddress address);
        string GetPostCode();
    }
}